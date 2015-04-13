using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.Models
{
    public class ArticleDataStorage
    {
        public static ArticleDataStorage Instance = new ArticleDataStorage();

        private List<ArticleModel> articleList = new List<ArticleModel>();

        public ArticleDataStorage()
        {
            this.articleList.Add(new ArticleModel{ArticleId =  0,articleTitle = "title0",articleContent = "content of article 0",articleAuthor = 1});
            this.articleList.Add(new ArticleModel { ArticleId = 1, articleTitle = "title1", articleContent = "content of article 1", articleAuthor = 2 });
            this.articleList.Add(new ArticleModel { ArticleId = 2, articleTitle = "title2", articleContent = "content of article 2", articleAuthor = 4 });
            this.articleList.Add(new ArticleModel { ArticleId = 3, articleTitle = "title3", articleContent = "content of article 3", articleAuthor = 4 });
            this.articleList.Add(new ArticleModel { ArticleId = 4, articleTitle = "title4", articleContent = "content of article 4", articleAuthor = 4 });
            this.articleList.Add(new ArticleModel { ArticleId = 5, articleTitle = "title5", articleContent = "content of article 5", articleAuthor = 3 });
        }

        public List<ArticleModel> GetAllArticles()
        {
            return this.articleList;
        }
    }
}