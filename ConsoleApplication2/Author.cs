namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Author : User, IPersonManager
    {
        //fields of "Athor"  user
        //private int _currentAthrID; // ??? ������� �� �����.
        private float m_popularity;
        private string Nickname { get; set; }
        //unique properties of "Author"
        private bool m_isWriting;

        //propertie "TypeOfUser" of base class
        public string TypeOfUser(int userid)
        {
            return "Author";

        }
        //���������� ������ "CalculateUserSpecificValue" �������� ������

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