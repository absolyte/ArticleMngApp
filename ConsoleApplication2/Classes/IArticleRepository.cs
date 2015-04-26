using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public interface IArticleRepository
    {
        List<Article> GetAllArticles();
        void InitializeRepository();
        Article GetRandomArticle();
        void AddNewArticle(int currentArticleId, string title, string content, int authorId);
        void DeleteArticleWithId(int currentArticleId);

        Article GetArticleEntityById(int articleIdForSearch);
    }
}