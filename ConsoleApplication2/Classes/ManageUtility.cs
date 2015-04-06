using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2.Classes
{
    public class ManageUtility
    {
        private ReviewFacade _mReviewFacade;
        private CommentFacade _mCommentFacade;
        private ArticleFacade _mArticleFacade;

        public ManageUtility()
        {
            ReviewFacade reviewFacade = new ReviewFacade();
            this._mReviewFacade = reviewFacade;

            CommentFacade commentFacade = new CommentFacade();
            this._mCommentFacade = commentFacade;

            ArticleFacade articleFacade = new ArticleFacade();
            this._mArticleFacade = articleFacade;
        }

        public ReviewFacade GetReviewFacadeUnit
        {
            get { return _mReviewFacade; }
        }

        public CommentFacade GetCommentFacadeUnit
        {
            get { return _mCommentFacade; }
        }

        public ArticleFacade GetArticleFacadeUnit
        {
            get { return _mArticleFacade; }
        }
  }
        
}
