using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    public class Article
    {
        private int _currentArticleID;
        private string Title;
        private string Content;
        private int Author;
        // private string Comments;
        // private float avrgRating = 0;

        public Article(int num, string title, string content, int AuthorId)
        {
            this._currentArticleID = num;
            this.Title = title;
            this.Content = content;
            this.Author = AuthorId;
        }

        public void setTitle(string ttl)
        {
            this.Title = ttl;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public void setContent(string cnt)
        {
            this.Content = cnt;
        }

        public void setAuth(int auth)
        {
            this.Author = auth;
        }

        public void AddCmnt()
        {

        }

        public void setAvrgRating()
        {
            // this.avrgRating = CalcAvrgRating(this._currentArticleID);
        }

        public float CalcAvrgRating(int _currentArticleID)
        {
            float avrgRating = 0;
            return avrgRating;

        }
    }



    public class Comments
    {
        private int _currentCommentID;
        private string cmntContent;
    }


    public class Rating
    {
        private int _currentArticleID;
        private int _ratingValue;
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
        private int _currentUserID;
        private string FirstN;
        private string LastN;
        private string Age;

    }

    public class Admin : User, IPersonManager
    {
        private bool isSleeping;
        private float Karma;
        public string Privilegies { get; set; }
        public string TypeOfUser(int userid)
        {
            return "Admin";
        }
        public float CalculatedUserSpecificValue(int userid)
        {
            return Karma;
        }
    }

    public class Author : User, IPersonManager
    {
        //fields of "Athor"  user
        //private int _currentAthrID; // ??? наверно не нужен.
        private float Popularity;
        private string Nickname { get; set; }
        //unique properties of "Author"
        private bool isWriting;

        //propertie "TypeOfUser" of base class
        public string TypeOfUser(int userid)
        {
            return "Author";

        }
        //реализация метода "CalculateUserSpecificValue" базового класса

        public float CalculatedUserSpecificValue(int userid)
        {

            return Popularity;
        }

        public void setPopularity()
        {
            this.Popularity = 1;
        }
    }

    class PrintReports
    {
        // list of all article titles? 
        public void printArticleTitles(List<Article> gettedListOfArticles)
        { 
        foreach (Article articleToPrint in gettedListOfArticles)
        {
            System.Console.WriteLine(articleToPrint.getTitle());
        }
        }
        // average article rating? 

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
            List<Article> AllArticlesList = new List<Article>();
            AllArticlesList.Add(new Article(0, "title1", "content of article 0", 1));
            AllArticlesList.Add(new Article(1, "title2", "content of article 2", 2));
            AllArticlesList.Add(new Article(2, "title3", "content of article 3", 3));
            AllArticlesList.Add(new Article(3, "title4", "content of article 4", 3));
            AllArticlesList.Add(new Article(4, "title5", "content of article 5", 3));







            System.Console.WriteLine("1. view list of all articles");
            System.Console.WriteLine("2. average rating of article #");
            System.Console.WriteLine("3. List of all Admin <#> privilegies");
            System.Console.WriteLine("4. average rating of article #");
            
            int consoleinput = System.Convert.ToInt32(Console.ReadLine());
            if (consoleinput == 1)
            {
                PrintReports report1 = new PrintReports();
                report1.printArticleTitles(AllArticlesList);
                this.Run();
            }



        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           

            ArticleManager testAM = new ArticleManager();
            //testAM.printArticleTitles(AllArticlesList);

            testAM.Run();
            
            //persons[0].FirstName = "Новое имя";

           // foreach (Article articleobj in AllArticlesList)
             //   Console.WriteLine(articleobj.ToString());
            Console.ReadLine();
        }
    }

}


    
