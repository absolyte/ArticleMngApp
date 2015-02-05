using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace FLS.ArticleManager.ConsoleApplication2
{
    //Names of Namespaces   <Company>.(<Product>|<Technology>)[.<Feature>][.<Subnamespace>]

    /*
     * Case Rules
     
     * Pascal Case = UpperCamelCase = the first letter must be upper case
     * Do name classes, interfaces, and value types with nouns, noun phrases, or occasionally adjective phrases, using Pascal casing.
     * Do not give class names a prefix (such as the letter C).
     * Consider ending the name of derived classes with the name of the base class.
     * Do prefix interface names with the letter I to indicate that the type is an interface.
     * Do ensure that when defining a class/interface pair where the class is a standard implementation of the interface, the names differ only by the letter I prefix on the interface name.

     * Names of Generic Type Parameters
Do name generic type parameters with descriptive names, unless a single-letter name is completely self explanatory and a descriptive name would not add value. 
Consider using the letter T as the type parameter name for types with one single-letter type parameter. 
Do prefix descriptive type parameter names with the letter T. 
Consider indicating constraints placed on a type parameter in the name of parameter. For example, a parameter constrained to ISession may be called TSession. 

     * 
     
     
     */
    public class Article
    {
        private int m_currentArticleId;
        private string m_title;
        private string m_content;
        private int m_author;

        public Article(int currentArticleId, string title, string content, int authorId)
        {
            this.m_currentArticleId = currentArticleId;
            this.m_title = title;
            this.m_content = content;
            this.m_author = authorId;    
        }

        public void SetContent(string cnt)
        {
            this.m_content = cnt;
        }

        public void SetAuth(int auth)
        {
            this.m_author = auth;
        }

        public void AddCmnt()
        {

        }

        public int Get_currentArticleId()
        {
            return this.m_currentArticleId;
        }

        public float CalculateAverageRating(int IdArticleRatingToCalculate, List<Review> fullListOfReviews)
        {
            int numberOfSuitableArticles = 0;
            int summaryRatingToCalculateAverageRating = 0;
            foreach (Review currentReview in fullListOfReviews)
            {
                if (currentReview.ArticleIdInList == IdArticleRatingToCalculate)
                {
                    numberOfSuitableArticles += 1;
                    summaryRatingToCalculateAverageRating += currentReview.MRating;
                }
                else
                {
                    System.Console.WriteLine("skips article #" + currentReview.ArticleIdInList + "rating calculation due to insufficient number of article." + "current article to calculate average rating(which has been passed to calculation method) is #" + IdArticleRatingToCalculate);
                }

            }

            if (numberOfSuitableArticles == 0)
            {
                System.Console.WriteLine("article to calculate average rating is #" + IdArticleRatingToCalculate + "this article don't have any reviews yet. calculation of average rating is unavailable");
                return -1;
            }
            else
            {
                return (float)Convert.ToDouble(summaryRatingToCalculateAverageRating / numberOfSuitableArticles);
            }

        }
    }
    
    public abstract class BaseComment
    {
        public int ArticleIdInList { get; set; }
        public int RewiewOrCommentIdInList { get; set; }
        public string Content { get; set; }
        public abstract void GetEntityCode();
    }

    public class Comments : BaseComment
    {
        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }

    public class Review : BaseComment
    {
        private int m_ratingValue;
        public int MRating
        {
            get { return m_ratingValue; }
            set
            {
                if ( value > -1 && value < 5)
                m_ratingValue = value;
            }
        }

        public Review (int articleIdInList, int rewiewOrCommentIdInList, string content, int ratingValue)
        {
            this.ArticleIdInList = articleIdInList;
            this.m_ratingValue = ratingValue;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }

    public class Rating
    {
        private int m_currentArticleId;
        private int m_ratingValue;
    }

    interface IPersonManager
    {
        string TypeOfUser(int userId);
        float CalculatedUserSpecificValue(int userId);
        // void addUser();
        // void deleteUser();
        // void modifyUser();
        }

    public class User
    {
        //поля
        private int m_currentUserId;
        private string m_firstN;
        private string m_lastN;
        private string m_age;

    }

    public class Admin : User, IPersonManager
    {
        private bool m_isSleeping;
        private float m_karma;
        public string Privilegies { get; set; }
        public string TypeOfUser(int userid)
        {
            return "Admin";
        }
        public float CalculatedUserSpecificValue(int userid)
        {
            return m_karma;
        }
    }

    public class Author : User, IPersonManager
    {
        //fields of "Athor"  user
        //private int _currentAthrID; // ??? наверно не нужен.
        private float m_popularity;
        private string Nickname { get; set; }
        //unique properties of "Author"
        private bool m_isWriting;

        //propertie "TypeOfUser" of base class
        public string TypeOfUser(int userid)
        {
            return "Author";

        }
        //реализация метода "CalculateUserSpecificValue" базового класса

        public float CalculatedUserSpecificValue(int userid)
        {

            return m_popularity;
        }

        public void SetPopularity()
        {
            this.m_popularity = 1;
        }
    }

    class PrintReports
    {
        /* list of all article titles? 
        public void PrintArticleTitles(List<Article> gettedListOfArticles)
        { 
        foreach (Article articleToPrint in gettedListOfArticles)
        {
            System.Console.WriteLine(articleToPrint.getTitle());
        }
        }
         */
        // average article rating? 
        public void PrintAverageRatingForEveryArticle(List<Article> gettedListOfArticles, List<Review> gettedListOfReviews)
        {
            foreach (Article articleToCalculateAverageRating in gettedListOfArticles)
            {
                System.Console.WriteLine(articleToCalculateAverageRating.CalculateAverageRating(articleToCalculateAverageRating.Get_currentArticleId(), gettedListOfReviews));
            }
        }

        // list of all Admin privilegies? 

        // list of commenters for a specified article? 
    }

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
            List<Article> allArticlesList = new List<Article>();
            allArticlesList.Add(new Article(0, "title0", "content of article 0", 1));
            allArticlesList.Add(new Article(1, "title1", "content of article 1", 2));
            allArticlesList.Add(new Article(2, "title2", "content of article 2", 3));
            allArticlesList.Add(new Article(3, "title3", "content of article 3", 3));
            allArticlesList.Add(new Article(4, "title4", "content of article 4", 3));

            List<Review> allReviewsList = new List<Review>();
            allReviewsList.Add(new Review(2, 0, "review for article with position 2 in list and rating value = 5", 5));
            allReviewsList.Add(new Review(2, 1, "review for article with position 2 in list and rating value = 5", 5));
            allReviewsList.Add(new Review(2, 2, "review for article with position 2 in list and rating value = 3", 3));
            allReviewsList.Add(new Review(2, 3, "review for article with position 2 in list and rating value = 2", 2));
            allReviewsList.Add(new Review(2, 4, "review for article with position 2 in list and rating value = 3", 3));
            allReviewsList.Add(new Review(2, 5, "review for article with position 2 in list and rating value = 1", 1));
            allReviewsList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            allReviewsList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            allReviewsList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
           

            

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
                report2.PrintAverageRatingForEveryArticle(allArticlesList, allReviewsList);
                this.Run();
            }

        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            ArticleManager testAm = new ArticleManager();
            //testAM.printArticleTitles(AllArticlesList);

            testAm.Run();
            
            //persons[0].FirstName = "Новое имя";

           // foreach (Article articleobj in AllArticlesList)
             //   Console.WriteLine(articleobj.ToString());
            Console.ReadLine();
        }
    }

}


    
