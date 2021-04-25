using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Mapping
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Database.Post, Model.BlogPostDTO>();
            CreateMap<Database.Post, Model.InsertViewBlogPostDTO>();
            CreateMap<Database.Post, Model.UpdateViewBlogPostDTO>();
            CreateMap<Database.Post, Model.InsertBlogPostDTO>();
            CreateMap<Database.Post, Model.UpdateBlogPostDTO>();

            CreateMap<Model.InsertBlogPostDTO, Database.Post>();

        }
    }
}
