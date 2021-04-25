using Blog.Api.Services.IRepository;
using Blog.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    
    public class BlogPostsController : ControllerBase
    {
        protected readonly IBlogPostRepository _service;

        public BlogPostsController(IBlogPostRepository service)
        {
            _service = service;
        }


        [HttpGet]
        public virtual Model.MultipleBlogPostDto Get([FromQuery] Model.BlogSearchRequest search)
        {
            return _service.Get(search);
        }


        [HttpGet("Tags")]
        public virtual TagDTO GetTags()
        {
            return _service.GetTags();
        }

        [HttpGet("{slug}")]
        public virtual Model.BlogPostDTO GetById(string slug)
        {
            return _service.GetById(slug);
        }

       [HttpPost]
        public Model.InsertViewBlogPostDTO Insert([FromBody] Model.InsertBlogPostDTO request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{slug}")]
        public Model.UpdateViewBlogPostDTO Update(string slug, [FromBody] Model.UpdateBlogPostDTO request)
        {
            return _service.Update(slug, request);
        }

        [HttpDelete("{slug}")]
        public Model.MultipleBlogPostDto Delete(string slug)
        {
            return _service.Delete(slug);
        }
    }
}
