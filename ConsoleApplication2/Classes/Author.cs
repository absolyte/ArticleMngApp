using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Author : AbstractUser, IUserInterface
    {
        private float _mPopularity;
        private string Nickname { get; set; }
        
       public string TypeOfUser()
       {
          return "Author";
       }

       public Author()
       {

       }

        public float Popularity
        {
            get { return _mPopularity;}
            protected set { this._mPopularity = value; }
        }

        public Author(int authorIdInList, string firstN, string lastN, int age)
           :this()
        {
        
        }

     
        public override float ReturnCalculatedUserSpecificValue()
        {
            return _mPopularity;
        }
    }
}