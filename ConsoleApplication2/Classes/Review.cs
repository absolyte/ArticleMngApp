using System;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Review : BaseComment
    {
        private int m_ratingValue;
        public int MRating
        {
            get { return m_ratingValue; }
            set
            {
                if ( value > -1 && value < 5)
                    m_ratingValue = value;
            }
        }

        public Review (int articleIdInList, int rewiewOrCommentIdInList, string content, int ratingValue)
        {
            this.ArticleIdInList = articleIdInList;
            this.m_ratingValue = ratingValue;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }
}