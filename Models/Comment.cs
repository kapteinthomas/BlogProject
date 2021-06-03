using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Comment
    {
        [Required]
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public int BlogID { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
    }
}