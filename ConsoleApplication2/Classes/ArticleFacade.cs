using System;
using System.Collections.Generic;
using System.Reflection;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleFacade
    {
        public ArticleRepository CreateArticles()
        {
            ArticleRepository articlesR = new ArticleRepository();
            return articlesR;
        }

        public void RefreshAverageRatingForAllArticles(ReviewRepository reviewRepository, ArticleRepository articleRepository, ArticleFacade gettedArticleFacade)
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToRefreshRating in articleRepository.GetAllArticles())
            {
               articleToRefreshRating.SetAverageRating(gettedArticleFacade.CalculateAverageRating(articleToRefreshRating.Get_currentArticleId(),
                    reviewRepository.GetAllEntitiesList()));
            }
        }

        public void PrintArticleTitles(ArticleRepository articleRepository1) 
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToPrint in articleRepository1.GetAllArticles())
            {
                System.Console.WriteLine(articleToPrint.getTitle());
            }
        }

        public float CalculateAverageRating(int idArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            int numberOfSuitableArticles = 0;
            int summaryRatingToCalculateAverageRating = 0;
            foreach (Review currentReview in fullListOfReviews)
            {
                if (currentReview.ArticleIdInList == idArticleRatingToCalculate)
                {
                    numberOfSuitableArticles += 1;
                    summaryRatingToCalculateAverageRating += currentReview.MRating;
                }
                else
                {
                    //System.Console.WriteLine("skips article #" + currentReview.ArticleIdInList + "rating calculation due to insufficient number of article." + "current article to calculate average rating(which has been passed to calculation method) is #" + IdArticleRatingToCalculate);
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



        internal void PrintAverageRating(ArticleRepository gettedArticleRepository)
        {
            foreach (Article articleToPrintAverageRating in gettedArticleRepository.GetAllArticles())
            {
                articleToPrintAverageRating.ShowAverageRating();
            }
            Console.WriteLine("Specific average rating -1 means that rating not yet specified or calculated for this article. Please run articleFacade.RefreshAverageRatingForAllArticles method");
        }

        public Article GetArticleById(int articleIdForSearch, ArticleRepository inputtedArticleRepository)
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return inputtedArticleRepository.GetArticleEntityById(articleIdForSearch);
        }

        public Article GetRandomArticle(ArticleRepository inputtedArticleRepository)
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return inputtedArticleRepository.GetRandomArticle();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}