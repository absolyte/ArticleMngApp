using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class PrintReports
    {
        private ManageUtility m_inMemoryManageUtilityUnit;
        
        public PrintReports()
        {
            this.m_inMemoryManageUtilityUnit = new ManageUtility();
        }

        public void PrintArticleTitles()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToPrint in m_inMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
            {
                System.Console.WriteLine(articleToPrint.GetTitle());
            }
        }

        public void PrintAverageRatingForEveryArticle()
        {
                DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
                foreach (Article articleToPrintAverageRating in m_inMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
                {
                    articleToPrintAverageRating.ShowAverageRating();
                }
                Console.WriteLine("Specific average rating -1 means that rating not yet specified or calculated for this article. Please run articleFacade.RefreshAverageRatingForAllArticles method");    
        }

        public void RefreshAverageRating()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            foreach (Article articleToRefreshRating in m_inMemoryManageUtilityUnit.GetArticleFacadeUnit.GetAllArticlesList())
            {
               articleToRefreshRating.SetAverageRating(m_inMemoryManageUtilityUnit.GetArticleFacadeUnit.CalculateAverageRating(articleToRefreshRating.Get_currentArticleId(),m_inMemoryManageUtilityUnit.GetReviewFacadeUnit.GetAllReviewsList()));
            }
        }




        }
    
    }
   