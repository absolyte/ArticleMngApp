using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    using global::ConsoleApplication2;

    public class ArticleFacade
    {
        private IEntityRepository<Article> m_articleRepositoryUnit;
       
        public ArticleFacade()
        {
           this.m_articleRepositoryUnit = new ArticleRepository();
        }

        //trying use DI
        public ArticleFacade(IEntityRepository<Article> repository)
        {
            m_articleRepositoryUnit = repository;
        }

        public void InitializeData()
        {
            this.m_articleRepositoryUnit.InitializeRepository();
        }
        
       public float CalculateAverageRating(int idArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
          //  DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            int numberOfSuitableArticles = 0;
            int summaryRatingToCalculateAverageRating = 0;
            foreach (Review currentReview in fullListOfReviews)
                {
                    if (currentReview.ArticleIdInList == idArticleRatingToCalculate)
                    {
                        numberOfSuitableArticles += 1;
                        summaryRatingToCalculateAverageRating += currentReview.MRating;
                    }
                }
            if (numberOfSuitableArticles == 0)
                {
                    //System.Console.WriteLine("article to calculate average rating is #" + IdArticleRatingToCalculate + "this article don't have any reviews yet. calculation of average rating is unavailable");
                    return -1;
                }
            else
                {
                    return (float)summaryRatingToCalculateAverageRating / numberOfSuitableArticles;
                }   
        }

        public List<Article> GetAllArticlesList()
        {
           return this.m_articleRepositoryUnit.GetAllEntities();
        }

        public Article GetArticleById(int articleIdForSearch)
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_articleRepositoryUnit.GetEntityById(articleIdForSearch);
        }

        public Article GetRandomArticle()
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_articleRepositoryUnit.GetRandomEntity();
        }

        public void AddArticleToDb(int currentArticleId, string title, string content, int authorId)
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            this.m_articleRepositoryUnit.AddNewEntity(currentArticleId, title, content, authorId);
        }

        public void DeleteArticleFromDb(int currentArticleId)
        {
            this.m_articleRepositoryUnit.DeleteEntityWithId(currentArticleId);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}