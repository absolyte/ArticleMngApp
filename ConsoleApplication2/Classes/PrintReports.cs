using System;
using System.Collections.Generic;
using System.Reflection;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {
        public void PrintArticleTitles(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
            PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            gettedArticleFacade.PrintArticleTitles(gettedArticleRepository);
        }

        public void PrintAverageRatingForEveryArticle(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
                PrintReports.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
                gettedArticleFacade.PrintAverageRating(gettedArticleRepository);
        }

        public static void DiagnosticOutput(string nameOfStartedMethod, string nameOfClassWhichWeAreCurrentlyIn)
        {
            Console.WriteLine("Method {0} started in class {1}." + "\n" , nameOfStartedMethod, nameOfClassWhichWeAreCurrentlyIn);
        }



    }

    
        

    }
    // list of all Admin privilegies? 

        // list of commenters for a specified article? 
       /*  */
 //   }
