using System;
using System.Collections.Generic;

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
            foreach (Article articleToRefreshRating in articleRepository.GetAllArticles())
            {
               articleToRefreshRating.SetAverageRating(gettedArticleFacade.CalculateAverageRating(articleToRefreshRating.Get_currentArticleId(),
                    reviewRepository.GetAllEntitiesList()));
            }
        }

        public void PrintArticleTitles(ArticleRepository articleRepository1) 
        {
            foreach (Article articleToPrint in articleRepository1.GetAllArticles())
            {
                System.Console.WriteLine(articleToPrint.getTitle());
            }
        }

        public float CalculateAverageRating(int idArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
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
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}