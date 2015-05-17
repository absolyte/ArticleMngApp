using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
   public class PrintReports
    {
        private ReviewFacade m_reviewFacade;
        private CommentFacade m_commentFacade;
        private ArticleFacade m_articleFacade;
        private AdminFacade m_adminFacade;
        private UserFacade m_userFacade;
        private AuthorFacade m_authorFacade;

        public ReviewFacade GetReviewFacadeUnit
        {
            get { return m_reviewFacade; }
        }

        public CommentFacade GetCommentFacadeUnit
        {
            get { return m_commentFacade; }
        }

        public PrintReports()
        {
            this.m_reviewFacade = new ReviewFacade();
            this.m_commentFacade = new CommentFacade();
            this.m_articleFacade = new ArticleFacade();

            m_adminFacade = new AdminFacade();
            m_authorFacade = new AuthorFacade();
            m_userFacade = new UserFacade();
        }

        public static void PrintMessage(string messageString)
        {
            Console.WriteLine(messageString);
        }

        public static void PrintDelimiter()
        {
            Console.WriteLine("---------------------------------------\n");
        }

        public void Initialize()
        {
            m_articleFacade.InitializeData();
            m_commentFacade.InitializeData();
            m_reviewFacade.InitializeData();
            m_adminFacade.InitializeData();
            m_authorFacade.InitializeData();
            m_userFacade.InitializeData();

        }

        public ArticleFacade GetArticleFacadeUnit
        {
            get { return m_articleFacade; }
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
               articleToRefreshRating.SetAverageRating(GetArticleFacadeUnit.CalculateAverageRating(articleToRefreshRating.CurrentArticleId,GetReviewFacadeUnit.GetAllEntities()));
            }
        }

        public void ChangeArticles()
        {
            GetArticleFacadeUnit.AddArticleToDb(0, "title0", "content of article 0", 1);
            GetArticleFacadeUnit.AddArticleToDb(50, "title50", "content of article 50", 1);
            GetArticleFacadeUnit.AddArticleToDb(60, "title60", "content of article 60", 1);
            GetArticleFacadeUnit.AddArticleToDb(70, "title70", "content of article 70", 1);
            GetArticleFacadeUnit.AddArticleToDb(80, "title80", "content of article 80", 1);
            PrintArticleTitlesAndContent();
            GetArticleFacadeUnit.DeleteArticleFromDb(80);
            GetArticleFacadeUnit.DeleteArticleFromDb(90);
            PrintArticleTitlesAndContent();
            GetArticleFacadeUnit.AddArticleToDb(80, "title80", "content of article2346234", 5);
            GetArticleFacadeUnit.AddArticleToDb(90, "title90", "content of article 90", 1);
            GetArticleFacadeUnit.AddArticleToDb(55, "title55", "content of article 55", 1);
            GetArticleFacadeUnit.AddArticleToDb(32, "title32", "content of article 32", 1);
            PrintArticleTitlesAndContent();

            GetCommentFacadeUnit.AddComment(70, 11, 3, "Admin", "comment by admin fedor ryabchikov to article 70");
            GetCommentFacadeUnit.AddComment(70, 12, 0, "Author", "comment by author ivan suslikov to article 70");
            GetCommentFacadeUnit.AddComment(70, 13, 5, "User", "comment by user broneslav Vryn to article 70");      
            }

        public void PrintCommentsForArticleWithId(int articleIdForWhichToRetrieveComments)
        {
            //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            PrintReports.PrintDelimiter();
            if (GetArticleFacadeUnit.GetArticleById(articleIdForWhichToRetrieveComments) != null)
            {
                PrintReports.PrintMessage("Article Title=" + GetArticleFacadeUnit.GetArticleById(articleIdForWhichToRetrieveComments).Title);
                int commentFlag = 0;
                foreach (Comment commentToPrint in GetCommentFacadeUnit.GetAllCommentsList())
                {
                    if (commentToPrint.ArticleIdInList == articleIdForWhichToRetrieveComments)
                    {
                        commentFlag += 1;
                        PrintReports.PrintMessage(commentToPrint.Content);
                    }
                 }
                if (commentFlag == 0)
                {
                    PrintReports.PrintMessage("Article Title=" + GetArticleFacadeUnit.GetArticleById(articleIdForWhichToRetrieveComments).Title + "doesn't have comments");
                }
                PrintReports.PrintMessage("\n");
            }
            else
            {
                System.Console.WriteLine("Article with incoming ID={0} wasn't found", articleIdForWhichToRetrieveComments);
            }
           PrintReports.PrintDelimiter();
            
        }

        public void PrintAllCommentersForSpecifiedArticle(int articleIdForWhichToRetrieveCommenters)
       {
           //DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
           PrintReports.PrintDelimiter();
           PrintReports.PrintMessage(MethodBase.GetCurrentMethod().Name);
           if (GetArticleFacadeUnit.GetArticleById(articleIdForWhichToRetrieveCommenters) != null)
           {
               PrintReports.PrintMessage("Article Title=" + GetArticleFacadeUnit.GetArticleById(articleIdForWhichToRetrieveCommenters).Title);
               
               foreach (Comment commentToGetCommenters in GetCommentFacadeUnit.GetAllCommentsList())
               {
                   if (commentToGetCommenters.ArticleIdInList == articleIdForWhichToRetrieveCommenters)
                   {
                       if (commentToGetCommenters.userFlag == "Admin")
                       {
                           System.Console.WriteLine(this.m_adminFacade.GetAdminById(commentToGetCommenters.userId).FirstName + "\n" + this.m_adminFacade.GetAdminById(commentToGetCommenters.userId).LastName);
                       }

                      if (commentToGetCommenters.userFlag == "Author")
                      {
                           System.Console.WriteLine(this.m_authorFacade.GetAuthorById(commentToGetCommenters.userId).FirstName + "\n" + this.m_authorFacade.GetAuthorById(commentToGetCommenters.userId).LastName);
                       }
                   
                       if (commentToGetCommenters.userFlag == "User")
                       {
                           System.Console.WriteLine(this.m_userFacade.GetUserById(commentToGetCommenters.userId).FirstName + "\n" + this.m_userFacade.GetUserById(commentToGetCommenters.userId).LastName);
                       }

                   }
               }
              }
           else
           {
               System.Console.WriteLine("Article with incoming ID={0} wasn't found", articleIdForWhichToRetrieveCommenters);
           }
           PrintReports.PrintDelimiter();

       }


       public void PrintCommentsForAllArticles()
       {
           foreach (Article articleToPrintComments in GetArticleFacadeUnit.GetAllArticlesList())
           {
               this.PrintCommentsForArticleWithId(articleToPrintComments.CurrentArticleId);
           }
       }
    }
    
}
