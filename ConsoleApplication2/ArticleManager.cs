using System;
using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    class ArticleManager
    { 
        // void addUser();
        // void deleteUser();
        // void modifyUser();
      
        // void addArticle();
        // void deleteArticle();
        // void modifyArticle();
        
        
        //public void printArticleTitles(List<Article> currentListOfArticles)
        //{ 
        
        // }

        public void Run() {
            System.Console.WriteLine("1. view list of all articles");
            System.Console.WriteLine("2. average rating of article #");
            System.Console.WriteLine("3. List of all Admin <#> privilegies");
            System.Console.WriteLine("4. average rating of article #");
            
            int consoleinput = System.Convert.ToInt32(Console.ReadLine());
            if (consoleinput == 1)
            {
                PrintReports report1 = new PrintReports();
                // report1.PrintArticleTitles(allArticlesList);
                this.Run();
            }

            if (consoleinput == 2)
            {   
                PrintReports report2 = new PrintReports();
              //  report2.PrintAverageRatingForEveryArticle(allArticlesList, allReviewsList);
                this.Run();
            }

        }

        
    }
}