using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceBlogBackend.Models.Blog
{
    public class GamerBlog
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
       public string Content { get; set; }
    }
}
