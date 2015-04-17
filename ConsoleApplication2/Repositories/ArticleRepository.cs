using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IArticleRepository
    {
        private List<Article> m_AllArticlesList;
        
        public ArticleRepository()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            m_AllArticlesList = new List<Article>();
            
      }

        public List<Article> GetAllArticles()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return m_AllArticlesList;
        }

        public Article GetArticleEntityById(int articleIdForSearch)
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return m_AllArticlesList.Find(article => article.CurrentArticleId.Equals(articleIdForSearch));
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

            if (m_AllArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId +"already exists. Operation cancelled.");
            }
            else
            {
                m_AllArticlesList.Add(new Article(currentArticleId, title, content, authorId));
               // PrintReports.PrintMessage("Article with Id =" + currentArticleId + "sended to repository");
            }
        }


        internal void DeleteArticleWithId(int currentArticleId)
        {
            if (m_AllArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "founded. Delete procedure started.");
                m_AllArticlesList.Remove(m_AllArticlesList.Find(article => article.CurrentArticleId.Equals(currentArticleId)));
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + " deleted.");
            }
            else
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "not founded. Delete procedure not started."); ;
            }

            
       

        }
      
        public void InitializeRep()
        {
            m_AllArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            m_AllArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            m_AllArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            m_AllArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            m_AllArticlesList.Add(new Article(4, "title4", "content of article 4", 3));
        }
    }
}