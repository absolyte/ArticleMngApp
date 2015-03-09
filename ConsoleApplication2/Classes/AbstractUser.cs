using ConsoleApplication2.Inerfaces;
namespace ConsoleApplication2.Classes
{
    public abstract class AbstractUser
    {
        private int m_currentUserId;
        private int m_age;
        private string m_firstName;
        private string m_lastName;

        public int GetCurrentUserId
        {
            get { return m_currentUserId; }
        }

        protected int SetCurrentUserId
        {
            set { this.m_currentUserId = value; }
        }

        public int GetAge
        {
            get { return m_age; }
        }

        protected int SetAge
        {
            set { this.m_age = value; }
        }

        public string GetFirstName
        {
            get { return m_firstName; }
        }

        protected string SetFirstName
        {
            set { this.m_firstName = value; }
        }

        public string GetLastName
        {
            get { return m_lastName; }
        }

        protected string SetLastName
        {
            set { this.m_lastName = value; }
        }


       public abstract float ReturnCalculatedUserSpecificValue();
   }
}