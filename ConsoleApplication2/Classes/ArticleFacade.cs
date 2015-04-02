using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ArticleFacade
    {
        private ArticleRepository articleRepositoryUnit;

        public ArticleFacade()
        {
            ArticleRepository ar = new ArticleRepository();
            this.articleRepositoryUnit = ar;
        }

        public float CalculateAverageRating(int idArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
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

        public List<Article> GetAllArticlesList()
        {
           return articleRepositoryUnit.GetAllArticles();
        }

        public Article GetArticleById(int articleIdForSearch, ArticleRepository inputtedArticleRepository)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return inputtedArticleRepository.GetArticleEntityById(articleIdForSearch);
        }

        public Article GetRandomArticle(ArticleRepository inputtedArticleRepository)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            return inputtedArticleRepository.GetRandomArticle();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}