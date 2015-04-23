using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleFacade
    {
        private ArticleRepository m_articleRepositoryUnit;
       //private IArticleRepository m_articleRepositoryUnitForTest;   //DI member

        public ArticleFacade()
        {
           this.m_articleRepositoryUnit = new ArticleRepository();
        }

        //trying use DI
       // public ArticleFacade(IArticleRepository repository)
       // {
       //     m_articleRepositoryUnitForTest = repository;
      //  }

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
           return this.m_articleRepositoryUnit.GetAllArticles();
        }

        public Article GetArticleById(int articleIdForSearch)
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_articleRepositoryUnit.GetArticleEntityById(articleIdForSearch);
        }

        public Article GetRandomArticle()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return this.m_articleRepositoryUnit.GetRandomArticle();
        }

        public void AddArticleToDb(int currentArticleId, string title, string content, int authorId)
        {
           // DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            this.m_articleRepositoryUnit.AddNewArticle(currentArticleId, title, content, authorId);
        }

        public void DeleteArticleFromDb(int currentArticleId)
        {
            this.m_articleRepositoryUnit.DeleteArticleWithId(currentArticleId);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}