using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IArticleRepository
    {
        private List<Article> _allArticlesList;
        
        public ArticleRepository()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            _allArticlesList = new List<Article>();
            _allArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            _allArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            _allArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            _allArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            _allArticlesList.Add(new Article(4, "title4", "content of article 4", 3));
      }

        public List<Article> GetAllArticles()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return _allArticlesList;
        }

        public Article GetArticleEntityById(int articleIdForSearch)
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return _allArticlesList.Find(article => article.CurrentArticleId.Equals(articleIdForSearch));
        }

        public Article GetRandomArticle()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            Random rand = new Random();
            return this.GetArticleEntityById(rand.Next(this.GetAllArticles().Count));
        }

        internal void AddNewArticle(int currentArticleId, string title, string content, int authorId)
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());

            if (_allArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId +"already exists");
            }
            else
            {
                _allArticlesList.Add(new Article(currentArticleId, title, content, authorId));
            }
        }


        internal void DeleteArticleWithId(int currentArticleId)
        {
            if (_allArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "founded. Delete procedure started.");
                _allArticlesList.Remove(_allArticlesList.Find(article => article.CurrentArticleId.Equals(currentArticleId)));
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + " deleted.");
            }
            else
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "not founded. Delete procedure not started."); ;
            }
        }
    }
}