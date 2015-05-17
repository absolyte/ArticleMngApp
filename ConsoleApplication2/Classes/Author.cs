using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Author : AbstractUser, IUserInterface
    {
        private float m_mPopularity;
        private string Nickname { get; set; }

        public Author(int authorIdInList, string firstN, string lastN, int age)
        {
            this.CurrentUserId = authorIdInList;
            this.FirstName = firstN;
            this.LastName = lastN;
            this.Age = age;
        }

       public string TypeOfUser()
       {
          return "Author";
       }

        public float Popularity
        {
            get { return this.m_mPopularity;}
            protected set { this.m_mPopularity = value; }
        }

        public override float ReturnCalculatedUserSpecificValue()
        {
            return this.m_mPopularity;
        }
    }
}