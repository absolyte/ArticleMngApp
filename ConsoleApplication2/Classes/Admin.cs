using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Admin : AbstractUser, IUserInterface
    {
        private int _mKarma;
        
        public string TypeOfUser()
        {
        return "Admin";
        }
        
        public Admin(int adminIdInList, string firstName, string lastName, int age)
            : base(adminIdInList, firstName, lastName, age)
        {
           this._mKarma = age*100;
        }

        public Admin(int adminIdInList, string firstName, string lastName, int age,int karma)
            : this(adminIdInList, firstName, lastName, age)
        {
            this._mKarma = karma;
        }

        public override int Age
        {
            get { return _mKarma; } 
        }


        public new int GetAge()
        {
            return this._mKarma;
        }

        public override float ReturnCalculatedUserSpecificValue()
        {
            return (float) _mKarma;
        }
    }
}