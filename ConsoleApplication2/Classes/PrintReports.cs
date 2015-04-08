using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {
        private ManageUtility _mInMemoryManageUtilityUnit;
        public static void PrintMessage(string messageString)
        {
            Console.WriteLine(messageString);
        }
        public PrintReports()
        {
            this._mInMemoryManageUtilityUnit = new ManageUtility();
        }

        public void PrintArticleTitles()
        {
            
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintMessage("Article Title\n");
            foreach (Article articleToPrint in _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
            {
                PrintReports.PrintMessage(articleToPrint.Title);
                
            }
        }

        public void PrintArticleTitlesAndContent()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintMessage("Article Title    Article content\n");
            foreach (Article articleToPrint in _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
            {
                PrintReports.PrintMessage(articleToPrint.Title + "          " + articleToPrint.Content);

            }
        }

        public void PrintAverageRatingForEveryArticle()
        {
                DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
                foreach (Article articleToPrintAverageRating in _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
                {
                    articleToPrintAverageRating.ShowAverageRating();
                }
                Console.WriteLine("Specific average rating -1 means that rating not yet specified or calculated for this article. Please run articleFacade.RefreshAverageRatingForAllArticles method");    
        }

        public void RefreshAverageRating()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToRefreshRating in _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
            {
               articleToRefreshRating.SetAverageRating(_mInMemoryManageUtilityUnit.GetArticleFacadeUnit.CalculateAverageRating(articleToRefreshRating.CurrentArticleId,_mInMemoryManageUtilityUnit.GetReviewFacadeUnit.GetAllReviewsList()));
            }
        }

        public void ChangeArticles()
        {
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(0, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(50, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(60, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(70, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(80, "title0", "content of article 0", 1);
            PrintArticleTitlesAndContent();
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.DeleteArticleToDb(80);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(80, "title5", "content of article2346234", 5);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(90, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(55, "title0", "content of article 0", 1);
            _mInMemoryManageUtilityUnit.GetArticleFacadeUnit.AddArticleToDb(32, "title0", "content of article 0", 1);
        }



    }
    
    }
   