using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Article
    {
        private int _currentArticleID;
        private string Title;
        private string Content;
        private string Author;
        private string Comments;
        private float avrgRating = 0;

        //public Article()
        //{
        //}

        public void setTitle(string ttl)
        {
            this.Title = ttl;
        }

        public void setContent(string cnt)
        {
            this.Content = cnt;
        }

        public void setAuth(string auth)
        {
            this.Author = auth;
        }

        public void AddCmnt()
        {

        }

        public void setAvrgRating()
        {
            this.avrgRating = CalcAvrgRating(this._currentArticleID);
        }

        public float CalcAvrgRating(int _currentArticleID)
        {

            return avrgRating;

        }

    }
    public class Comments
    {
        private string cmntContent;
    }
    public class Rating
    {
        private int _currentArticleID;
        private int _ratingValue;
    }
    public abstract class User
    {
        //поля
        private int _currentUserID;
        private string FirstN;
        private string LastN;
        private string Age;
        //абстрактные поля (свойства, поведение котрых будет определено в классах-потомках)
        
            public abstract string TypeOfUser {get; }
            public abstract float CalculateUserSpecificValue();
    }

    public class Admin : User
    {
        //unique properties of "Admin" user
        private bool isSleeping;
        private float Karma;
        //private int _currentAdmID;

        public string Privilegies { get; set; }
        //methods
        //method "TypeOfUser" of base class
        public override string TypeOfUser
        {
            get
            {
                return "Admin";
            }
        }
        public override float CalculateUserSpecificValue()
        {
            
            
            return Karma;
        }
    }

    public class Author : User
    {
        //fields of "Athor"  user
        //private int _currentAthrID; // ??? наверно не нужен.
            private float Popularity;
            private string Nickname { get; set; }
        //unique properties of "Author"
            private bool isWriting;
        
        //propertie "TypeOfUser" of base class
        public override string TypeOfUser
        {
            get 
            { 
                return "Author"; 
            }
        }
        //реализация метода "CalculateUserSpecificValue" базового класса
      
        public override float CalculateUserSpecificValue()
        {
            
            return Popularity;
        }

        public void setPopularity()
        {
            this.Popularity = CalculateUserSpecificValue();
        }

        

        
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
