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
        {
            this.SetCurrentUserId = adminIdInList;
            this.SetFirstName = firstName;
            this.SetLastName = lastName;
            this.SetAge = age;
            this.m_karma = age*100;
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