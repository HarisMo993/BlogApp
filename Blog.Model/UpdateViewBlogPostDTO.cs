using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model
{
    public class UpdateViewBlogPostDTO
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<string> listOfTags { get; set; }
    }
}
