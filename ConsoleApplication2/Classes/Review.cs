using System;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Review : BaseComment
    {
        private int _mRatingValue;
        public int MRating
        {
            get { return _mRatingValue; }
            set
            {
                if ( value > -1 && value < 5)
                    _mRatingValue = value;
            }
        }

        public Review (int articleIdInList, int rewiewOrCommentIdInList, string content, int ratingValue)
        {
            this.ArticleIdInList = articleIdInList;
            this._mRatingValue = ratingValue;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }
}