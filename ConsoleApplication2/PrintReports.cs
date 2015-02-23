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

        public void PrintAverageRatingForEveryArticle(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
                gettedArticleFacade.PrintAverageRating(gettedArticleRepository);
        }



    }

    
        

    }
    // list of all Admin privilegies? 

        // list of commenters for a specified article? 
       /*  */
 //   }
