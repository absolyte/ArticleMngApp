namespace FLS.ArticleManager.ConsoleApplication2
{
    public class User
    {
        //поля
        protected int m_currentUserId;
        protected string m_firstN;
        protected string m_lastN;
        protected int m_age;

        public User()
        {
        
        }

      public User(int userIdInList, string firstN, string lastN, int age)
        {
            this.m_currentUserId = userIdInList;
            this.m_firstN = firstN;
            this.m_lastN = lastN;
            this.m_age = age;

        }
    }
}