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
        public string ArticleTitle { get; set;}

        [Required]
        [Display(Name = "Article content")]
        public string ArticleContent { get; set;}


        public int Author { get; set; }

        public int ArticleAuthor { get; set; }
    }
}
