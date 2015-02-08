using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IArticleRepository
    {
        
        public ArticleRepository()
        {
            List<Article> allArticlesList = new List<Article>();
            allArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            allArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            allArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            allArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            allArticlesList.Add(new Article(4, "title4", "content of article 4", 3));  
        }

        public List<Article> GetAllArticles()
        {
            return allArticlesList;
        }
    }
}