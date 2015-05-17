using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using ConsoleApplication2.Classes;
using ConsoleApplication2;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleRepository : IEntityRepository<Article>
    {
        private List<Article> m_allArticlesList;
        
        public ArticleRepository()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            this.m_allArticlesList = new List<Article>();
            
      }

        public List<Article> GetAllEntities()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_allArticlesList;
        }

        public Article GetEntityById(int articleIdForSearch)
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_allArticlesList.Find(article => article.CurrentArticleId.Equals(articleIdForSearch));
        }

        public Article GetRandomEntity()
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            Random rand = new Random();
            return this.GetEntityById(rand.Next(this.GetAllEntities().Count));
        }

        public void AddNewEntity(int currentArticleId, string title, string content, int authorId)
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());

            if (this.m_allArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId +"already exists. Operation cancelled.");
            }
            else
            {
                this.m_allArticlesList.Add(new Article(currentArticleId, title, content, authorId));
               // PrintReports.PrintMessage("Article with Id =" + currentArticleId + "sended to repository");
            }
        }


        public void DeleteEntityWithId(int currentArticleId)
        {
            if (this.m_allArticlesList.Exists(x => x.CurrentArticleId.Equals(currentArticleId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "founded. Delete procedure started.");
                this.m_allArticlesList.Remove(this.m_allArticlesList.Find(article => article.CurrentArticleId.Equals(currentArticleId)));
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + " deleted.");
            }
            else
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentArticleId + "not founded. Delete procedure not started."); ;
            }

        }
      
        public void InitializeRepository()
        {
            this.m_allArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            this.m_allArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            this.m_allArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            this.m_allArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            this.m_allArticlesList.Add(new Article(4, "title4", "content of article 4", 3));
        }
    }
}