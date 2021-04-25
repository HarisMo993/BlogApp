using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Model;

namespace Blog.Api.Services.IRepository
{
    public interface IBlogPostRepository 
    {
        Model.MultipleBlogPostDto Get(Model.BlogSearchRequest search = null);

        public Model.BlogPostDTO GetById(string slug);

        Model.InsertViewBlogPostDTO Insert(Model.InsertBlogPostDTO request);

        Model.MultipleBlogPostDto Delete(string slug);

        Model.UpdateViewBlogPostDTO Update(string slug, Model.UpdateBlogPostDTO request);

        TagDTO GetTags();
    }
}
