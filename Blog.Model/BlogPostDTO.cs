using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blog.Model
{
    public class BlogPostDTO
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<string> listOfTags { get; set; }
    }

    public class MultipleBlogPostDto
    {
        public List<BlogPostDTO> blogPosts { get; set; }
        public int postsCount { get; set; }
    }

}
