using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model
{
    public class InsertViewBlogPostDTO
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> listOfTags { get; set; }
    }
}
