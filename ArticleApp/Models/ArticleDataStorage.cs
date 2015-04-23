using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArticleApp.Models
{
    public class ArticleDataStorage
    {
        public static ArticleDataStorage Instance = new ArticleDataStorage();

        private List<ArticleModel> m_articleList = new List<ArticleModel>();

        public ArticleDataStorage()
        {
            this.m_articleList.Add(new ArticleModel{ArticleId =  0,ArticleTitle = "title0",ArticleContent = "content of article 0",ArticleAuthor = 1});
            this.m_articleList.Add(new ArticleModel { ArticleId = 1, ArticleTitle = "title1", ArticleContent = "content of article 1", ArticleAuthor = 2 });
            this.m_articleList.Add(new ArticleModel { ArticleId = 2, ArticleTitle = "title2", ArticleContent = "content of article 2", ArticleAuthor = 4 });
            this.m_articleList.Add(new ArticleModel { ArticleId = 3, ArticleTitle = "title3", ArticleContent = "content of article 3", ArticleAuthor = 4 });
            this.m_articleList.Add(new ArticleModel { ArticleId = 4, ArticleTitle = "title4", ArticleContent = "content of article 4", ArticleAuthor = 4 });
            this.m_articleList.Add(new ArticleModel { ArticleId = 5, ArticleTitle = "title5", ArticleContent = "content of article 5", ArticleAuthor = 3 });
        }

        public List<ArticleModel> GetAllArticles()
        {
            return this.m_articleList;
        }
    }
}