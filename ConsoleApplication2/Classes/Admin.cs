using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Admin : AbstractUser, IUserInterface
    {
        //private bool m_isSleeping;
        private int m_karma;
        //public Privilegies Privilegies { get; set; }

        public string TypeOfUser()
        {
        return "Admin";
        }
        


        public Admin(int adminIdInList, string firstName, string lastName, int age)
            : base(adminIdInList, firstName, lastName, age)
        {
           this.m_karma = age*100;
        }

        public Admin(int adminIdInList, string firstName, string lastName, int age,int karma)
            : this(adminIdInList, firstName, lastName, age)
        {
            this.m_karma = karma;
        }

        public override int Age
        {
            get { return m_karma; } 
        }


        public new int GetAge()
        {
            return this.m_karma;
        }

        public override float ReturnCalculatedUserSpecificValue()
        {
            return (float) m_karma;
        }
    }
}