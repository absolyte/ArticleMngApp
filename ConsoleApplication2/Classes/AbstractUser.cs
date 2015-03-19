using ConsoleApplication2.Inerfaces;
namespace ConsoleApplication2.Classes
{
    public abstract class AbstractUser
    {
        public int CurrentUserId { get; protected set; }
        public virtual int Age { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public AbstractUser()
        {
        }

        public AbstractUser(int userIdInList, string firstN, string lastN, int age)
        {
            CurrentUserId = userIdInList;
            FirstName = firstN;
            LastName = lastN;
            Age = age;
        }

        public abstract float ReturnCalculatedUserSpecificValue();

    }
}