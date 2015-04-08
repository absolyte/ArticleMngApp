using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {
        private ReviewFacade _mReviewFacade;
        private CommentFacade _mCommentFacade;
        private ArticleFacade _mArticleFacade;

        public static void PrintMessage(string messageString)
        {
            Console.WriteLine(messageString);
        }

        public static void PrintDelimiter()
        {
            Console.WriteLine("---------------------------------------\n");
        }

        public PrintReports()
        {
            this._mReviewFacade = new ReviewFacade();
            this._mCommentFacade = new CommentFacade();
            this._mArticleFacade = new ArticleFacade();        
        }

        public ReviewFacade GetReviewFacadeUnit
        {
            get { return _mReviewFacade; }
        }

        public CommentFacade GetCommentFacadeUnit
        {
            get { return _mCommentFacade; }
        }

        public ArticleFacade GetArticleFacadeUnit
        {
            get { return _mArticleFacade; }
        }

        public void PrintArticleTitles()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintDelimiter();
            PrintReports.PrintMessage("Article Title\n");
            foreach (Article articleToPrint in GetArticleFacadeUnit.GetAllArticlesList())
            {
                PrintReports.PrintMessage(articleToPrint.Title);
            }
            PrintReports.PrintDelimiter();
        }

        public void PrintArticleById(int idArticleToPrint)
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintDelimiter();
            Article articleToPrint = GetArticleFacadeUnit.GetAllArticlesList().Find(article => article.CurrentArticleId.Equals(idArticleToPrint));
            PrintReports.PrintMessage("Article Title    Article content\n");
            PrintReports.PrintMessage(articleToPrint.Title + "  " + articleToPrint.Content);
            PrintReports.PrintDelimiter();
        }

        public void PrintRandomArticle()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintDelimiter();
            Article articleToPrint = GetArticleFacadeUnit.GetRandomArticle();
            if (articleToPrint == null)
            {
                PrintReports.PrintMessage("no title with incoming random ID");
                PrintReports.PrintDelimiter();
            }
            else 
            {
                PrintReports.PrintMessage("Article Title    Article content\n");
                PrintReports.PrintMessage(articleToPrint.Title + "  " + articleToPrint.Content);
                PrintReports.PrintDelimiter();
            }

            
        }


        public void PrintArticleTitlesAndContent()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintDelimiter();
            PrintReports.PrintMessage("Article Title    Article content\n");
            foreach (Article articleToPrint in GetArticleFacadeUnit.GetAllArticlesList())
            {
                PrintReports.PrintMessage(articleToPrint.Title + "          " + articleToPrint.Content);
            }
            PrintReports.PrintDelimiter();
        }

        public void PrintAverageRatingForEveryArticle()
        {
                DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
                PrintReports.PrintDelimiter();
                PrintReports.PrintMessage("Article Title    Article average rating\n");
            foreach (Article articleToPrintAverageRating in GetArticleFacadeUnit.GetAllArticlesList())
                {
                    articleToPrintAverageRating.ShowAverageRating();
                }
                Console.WriteLine("\nSpecific average rating -1 means that rating not yet specified or calculated for this article. Please run articleFacade.RefreshAverageRatingForAllArticles method");
                PrintReports.PrintDelimiter();
        }

        public void RefreshAverageRating()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToRefreshRating in GetArticleFacadeUnit.GetAllArticlesList())
            {
               articleToRefreshRating.SetAverageRating(GetArticleFacadeUnit.CalculateAverageRating(articleToRefreshRating.CurrentArticleId,GetReviewFacadeUnit.GetAllReviewsList()));
            }
        }

        public void ChangeArticles()
        {
            GetArticleFacadeUnit.AddArticleToDb(0, "title0", "content of article 0", 1);
           GetArticleFacadeUnit.AddArticleToDb(50, "title0", "content of article 50", 1);
         GetArticleFacadeUnit.AddArticleToDb(60, "title0", "content of article 60", 1);
            GetArticleFacadeUnit.AddArticleToDb(70, "title0", "content of article 70", 1);
            GetArticleFacadeUnit.AddArticleToDb(80, "title0", "content of article 80", 1);
            PrintArticleTitlesAndContent();
            GetArticleFacadeUnit.DeleteArticleToDb(80);
            GetArticleFacadeUnit.DeleteArticleToDb(90);
            PrintArticleTitlesAndContent();
            GetArticleFacadeUnit.AddArticleToDb(80, "title5", "content of article2346234", 5);
            GetArticleFacadeUnit.AddArticleToDb(90, "title0", "content of article 90", 1);
            GetArticleFacadeUnit.AddArticleToDb(55, "title0", "content of article 55", 1);
            GetArticleFacadeUnit.AddArticleToDb(32, "title0", "content of article 32", 1);
            PrintArticleTitlesAndContent();
            GetArticleFacadeUnit.GetRandomArticle();
        }




        
    }
    
    }
   