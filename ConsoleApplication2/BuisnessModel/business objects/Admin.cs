using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Admin : AbstractUser, IUserInterface
    {
        private int m_mKarma;
        
        public string TypeOfUser()
        {
        return "Admin";
        }
        
        public Admin(int adminIdInList, string firstName, string lastName, int age)
            : base(adminIdInList, firstName, lastName, age)
        {
           this.m_mKarma = age*100;
        }

        public Admin(int adminIdInList, string firstName, string lastName, int age,int karma)
            : this(adminIdInList, firstName, lastName, age)
        {
            this.m_mKarma = karma;
        }

        public override int Age
        {
            get { return this.m_mKarma; } 
        }


        public new int GetAge()
        {
            return this.m_mKarma;
        }

        public override float ReturnCalculatedUserSpecificValue()
        {
            return (float) this.m_mKarma;
        }
    }
}