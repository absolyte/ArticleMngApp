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

        public void SetAverageRatingForAllArticles()
        {
        
        
        }

        public float CalculateAverageRating(int IdArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
            int numberOfSuitableArticles = 0;
            int summaryRatingToCalculateAverageRating = 0;
            foreach (Review currentReview in fullListOfReviews)
            {
                if (currentReview.ArticleIdInList == IdArticleRatingToCalculate)
                {
                    numberOfSuitableArticles += 1;
                    summaryRatingToCalculateAverageRating += currentReview.MRating;
                }
                else
                {
                    System.Console.WriteLine("skips article #" + currentReview.ArticleIdInList + "rating calculation due to insufficient number of article." + "current article to calculate average rating(which has been passed to calculation method) is #" + IdArticleRatingToCalculate);
                }
            }
            if (numberOfSuitableArticles == 0)
            {
                System.Console.WriteLine("article to calculate average rating is #" + IdArticleRatingToCalculate + "this article don't have any reviews yet. calculation of average rating is unavailable");
                return -1;
            }
            else
            {
                return (float)Convert.ToDouble(summaryRatingToCalculateAverageRating / numberOfSuitableArticles);
            }
        }


    }
}