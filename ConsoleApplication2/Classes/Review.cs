using System;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Review : BaseComment
    {
        private int m_RatingValue;
        
        public int MRating
        {
            get { return m_RatingValue; }
            set
            {
                if ( value > -1 && value < 5)
                    m_RatingValue = value;
            }
        }

        public Review (int articleIdInList, int rewiewOrCommentIdInList, string content, int ratingValue)
        {
            this.ArticleIdInList = articleIdInList;
            this.m_RatingValue = ratingValue;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public Review(string content)
        {
            this.Content = content;
            this.MRating = 0;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }
}