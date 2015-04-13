using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ArticleApp.Models
{
    public class ArticleModel
    {
        public int ArticleId { get; set; }

        [Required]
        [Display(Name = "Article title")]
        public string articleTitle { get; set;}

        [Required]
        [Display(Name = "Article content")]
        public string articleContent { get; set;}


        public int author { get; set; }

        public int articleAuthor { get; set; }
    }
}
