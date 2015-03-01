namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Author : User, IPersonManager
    {
        private float m_popularity;
        private string Nickname { get; set; }
        private bool m_isWriting;
        public string TypeOfUser(int userid)
        {
            return "Author";
        }
        //реализация метода "CalculateUserSpecificValue" базового класса

        public Author(int authorIdInList, string firstN, string lastN, int age)
        {
            this.m_currentUserId = authorIdInList;
            this.m_firstN = firstN;
            this.m_lastN = lastN;
            this.m_age = age;

        }

        public float CalculatedUserSpecificValue(int userid)
        {

            return m_popularity;
        }

        public void SetPopularity()
        {
            this.m_popularity = 1;
        }
    }
}