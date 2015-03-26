using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IArticleRepository
    {
        public List<Article> AllArticlesList;
        
        public ArticleRepository()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
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
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return AllArticlesList;
        }

        public Article GetArticleEntityById(int articleIdForSearch)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            Article articleToReturn = new Article();
            foreach (Article articleInList in this.GetAllArticles())
            {
                
                if (articleInList.Get_currentArticleId() == articleIdForSearch)
                {
                    articleToReturn = articleInList;
                    break;
                }
            }
            return articleToReturn;
        }

        public Article GetRandomArticle()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            Article articleToReturn = new Article();
            Random rand = new Random();
            return this.GetArticleEntityById(rand.Next(this.GetAllArticles().Count));
        }
    }
}