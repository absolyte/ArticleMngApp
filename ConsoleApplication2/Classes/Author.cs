using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Author : AbstractUser, IUserInterface
    {
        private float m_mPopularity;
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
            get { return this.m_mPopularity;}
            protected set { this.m_mPopularity = value; }
        }

        public Author(int authorIdInList, string firstN, string lastN, int age)
           :this()
        {
        
        }

     
        public override float ReturnCalculatedUserSpecificValue()
        {
            return this.m_mPopularity;
        }
    }
}