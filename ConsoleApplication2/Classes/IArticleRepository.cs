using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public interface IArticleRepository
    {
        List<Article> GetAllArticles();
        void InitializeRepository();
    }
}