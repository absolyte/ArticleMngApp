namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Admin : User, IPersonManager
    {
        private bool m_isSleeping;
        private float m_karma;
        public string Privilegies { get; set; }
        public string TypeOfUser(int userid)
        {
            return "Admin";
        }
        public float CalculatedUserSpecificValue(int userid)
        {
            return m_karma;
        }
    }
}