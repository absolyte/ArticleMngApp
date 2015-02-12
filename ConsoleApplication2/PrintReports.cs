using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {

        /* list of all article titles? */

        public void PrintArticleTitles(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
            gettedArticleFacade.PrintArticleTitles(gettedArticleRepository);
        }
   }

}    
        
      /*  public void PrintAverageRatingForEveryArticle(List<Article> gettedListOfArticles, List<Review> gettedListOfReviews)
        {
            foreach (Article articleToCalculateAverageRating in gettedListOfArticles)
            {
               // System.Console.WriteLine(articleToCalculateAverageRating.ShowAverageRating(articleToCalculateAverageRating.Get_currentArticleId(), gettedListOfReviews));
            }
        }

        // list of all Admin privilegies? 

        // list of commenters for a specified article? 
       /*  */
 //   }
