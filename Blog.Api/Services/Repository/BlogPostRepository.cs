using AutoMapper;
using Blog.Api.Database;
using Blog.Api.Services.IRepository;
using Blog.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Services.Repository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogContext _context;
        protected readonly IMapper _mapper;

        public BlogPostRepository(BlogContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public TagDTO GetTags()
        {
            TagDTO tag = new TagDTO();
            List<string> tags = new List<string>();

            foreach (var item in _context.Posts.ToList())
            {
                if (item.tags != null)
                    tags.AddRange(JsonConvert.DeserializeObject<List<string>>(item.tags));
            }


            tag.tags = tags.Distinct().ToList();
            return tag;
        }
        public Model.MultipleBlogPostDto Delete(string slug)
        {
            var entity = _context.Posts.FirstOrDefault(x => x.Slug == slug);
            _context.Posts.Remove(entity);
            _context.SaveChanges();

            var list = _context.Posts.ToList();

            Model.MultipleBlogPostDto blogs = new MultipleBlogPostDto();
            blogs.blogPosts = new List<BlogPostDTO>();
            foreach (var item in list)
            {
                var lists = _mapper.Map<Model.BlogPostDTO>(item);
                if (item.tags != null)
                {
                    lists.listOfTags = JsonConvert.DeserializeObject<List<string>>(item.tags);
                }
                blogs.blogPosts.Add(lists);
            }

            blogs.postsCount = blogs.blogPosts.Count();
            return blogs;
        }


        public MultipleBlogPostDto Get(Model.BlogSearchRequest search)
        {

            MultipleBlogPostDto blogsToReturn = new MultipleBlogPostDto();
            blogsToReturn.blogPosts = new List<BlogPostDTO>();

            if (search.tag != null)
            {
                foreach (var item in _context.Posts.ToList())
                {
                    if (item.tags != null)
                    {
                        var tags = JsonConvert.DeserializeObject<List<string>>(item.tags);

                        var found = tags.Where(t => t.Contains(search.tag)).FirstOrDefault();

                        if (found != null)
                        {
                            var mapped = _mapper.Map<Model.BlogPostDTO>(item);

                            mapped.listOfTags = tags;

                            blogsToReturn.blogPosts.Add(mapped);
                        }
                    }
                }
            }

            if (blogsToReturn.blogPosts.Count() == 0)
            {
                foreach (var item in _context.Posts.ToList())
                {
                    var tags = new List<string>();
                    if (item.tags != null)
                    {
                        tags = JsonConvert.DeserializeObject<List<string>>(item.tags);
                    }
                    var mapped = _mapper.Map<Model.BlogPostDTO>(item);
                    mapped.listOfTags = tags;
                    blogsToReturn.blogPosts.Add(mapped);
                }
            }


                blogsToReturn.postsCount = blogsToReturn.blogPosts.Count();
                return blogsToReturn;
        }

        public BlogPostDTO GetById(string slug)
        {
            var blog = _context.Posts.FirstOrDefault(x => x.Slug == slug);

            var test = _mapper.Map<Model.BlogPostDTO>(blog);

            if(blog.tags != null)
            {
                test.listOfTags = JsonConvert.DeserializeObject<List<string>>(blog.tags);
            }

            return test;
        }

        public InsertViewBlogPostDTO Insert(InsertBlogPostDTO request)
        {
            var set = _context.Set<Database.Post>();

            var slug = GetSlug(request.Title);

            var entity = new Post
            {
                Slug = slug,
                Title = request.Title,
                Description = request.Description,
                Body = request.Body,
                CreatedAt = DateTime.Now,
                tags = JsonConvert.SerializeObject(request.listOfTags)
            };

            set.Add(entity);

            _context.SaveChanges();

            var test = _mapper.Map<Model.InsertViewBlogPostDTO>(entity);

            if (entity.tags != null)
                test.listOfTags = JsonConvert.DeserializeObject<List<string>>(entity.tags);

            return test;
        }

        public UpdateViewBlogPostDTO Update(string slug, UpdateBlogPostDTO request)
        {
            var set = _context.Set<Database.Post>();

            var entity = _context.Posts.FirstOrDefault(x => x.Slug == slug);
            

            var slugUpdate = GetSlug(request.Title);

            entity.Slug = slugUpdate;
            entity.Title = request.Title;
            entity.Description = request.Description;
            entity.Body = request.Body;
            entity.UpdateAt = DateTime.Now;
            entity.tags = JsonConvert.SerializeObject(request.listOfTags);

            set.Update(entity);
            _context.SaveChanges();

            var test = _mapper.Map<Model.UpdateViewBlogPostDTO>(entity);

            if (entity.tags != null)
                test.listOfTags = JsonConvert.DeserializeObject<List<string>>(entity.tags);

            return test;
        }

        private string GetSlug<T>(T blog)
        {
            var AddSlug = FriendlyUrlHelper.GetFriendlyTitle(blog.ToString());

            return AddSlug;
        }
    }
}
