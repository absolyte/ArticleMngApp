using ConsoleApplication2.Classes;
using ConsoleApplication2.Inerfaces;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class User : AbstractUser, IUserInterface
    {
       public User()
        {
        }

        public User(int userIdInList, string firstN, string lastN, int age)
        {
            this.SetCurrentUserId = userIdInList;
            this.SetFirstName = firstN;
            this.SetLastName = lastN;
            this.SetAge = age;
        }

        public override float ReturnCalculatedUserSpecificValue()
        {
            System.Console.WriteLine("returning -1 because of CalculatedUserSpecificValue not yet specified for User");
            return (float) -1;
        }

        public string TypeOfUser()
        {
            return "User";
        }
    }
}