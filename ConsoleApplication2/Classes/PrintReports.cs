using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {
        public void PrintArticleTitles(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            gettedArticleFacade.PrintArticleTitles(gettedArticleRepository);
        }

        public void PrintAverageRatingForEveryArticle(ArticleFacade gettedArticleFacade, ArticleRepository gettedArticleRepository)
        {
                DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
                gettedArticleFacade.PrintAverageRating(gettedArticleRepository);
        }
    }

    
        

    }
    // list of all Admin privilegies? 

        // list of commenters for a specified article? 
       /*  */
 //   }
