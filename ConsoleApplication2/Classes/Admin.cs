namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Admin : User, IPersonManager
    {
        //private bool m_isSleeping;
        private float m_karma;
        //public Privilegies Privilegies { get; set; }

        public string TypeOfUser(int userid)
        {
        return "Admin";
        }
        
          public Admin(int adminIdInList, string firstN, string lastN, int age)
        {
            this.m_currentUserId = adminIdInList;
            this.m_firstN = firstN;
            this.m_lastN = lastN;
            this.m_age = age;
        }
        
        public float CalculatedUserSpecificValue(int userid)
        {
            return m_karma;
        }
    }
}