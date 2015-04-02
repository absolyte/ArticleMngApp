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
        private ReviewFacade m_reviewFacade;
        private CommentFacade m_commentFacade;
        private ArticleFacade m_articleFacade;
        private ReviewRepository m_reviewRepository;
        private CommentRepository m_commentRepository;
        private ArticleRepository m_articleRepository;

        public ManageUtility()
        {
            ReviewFacade reviewFacade = new ReviewFacade();
            this.m_reviewFacade = reviewFacade;

            CommentFacade commentFacade = new CommentFacade();
            this.m_commentFacade = commentFacade;

            ArticleFacade articleFacade = new ArticleFacade();
            this.m_articleFacade = articleFacade;

            ReviewRepository reviewRepository = new ReviewRepository();
            this.m_reviewRepository = reviewRepository;

            CommentRepository commentRepository = new CommentRepository();
            this.m_commentRepository = commentRepository;

            ArticleRepository articleRepository = new ArticleRepository();
            this.m_articleRepository = articleRepository;
        }

        public ReviewFacade GetReviewFacadeUnit
        {
            get { return m_reviewFacade; }
        }

        public CommentFacade GetCommentFacadeUnit
        {
            get { return m_commentFacade; }
        }

        public ArticleFacade GetArticleFacadeUnit
        {
            get { return m_articleFacade; }
        }

        public ReviewRepository GetReviewRepositoryUnit
        {
            get { return m_reviewRepository; }
        }

        public CommentRepository GetCommentRepositoryUnit
        {
            get { return m_commentRepository; }
        }

        public ArticleRepository GetArticleRepositoryUnit
        {
            get { return m_articleRepository; }
        }
    }
        
}
