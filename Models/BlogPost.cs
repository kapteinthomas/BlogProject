using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogPost
    {
        [Required]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public int Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}