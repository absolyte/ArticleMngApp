using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IArticleRepository
    {
        public List<Article> AllArticlesList;
        
        public ArticleRepository()
        {
            AllArticlesList = new List<Article>();
            AllArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            AllArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            AllArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            AllArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            AllArticlesList.Add(new Article(4, "title4", "content of article 4", 3));
            //return allArticlesList;
        }

        public List<Article> GetAllArticles()
        {
            return AllArticlesList;
        }
    }
}