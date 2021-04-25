using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blog.Model
{
    public class UpdateBlogPostDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Body { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<string> listOfTags { get; set; }
    }
}
