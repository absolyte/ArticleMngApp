using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2.Classes
{
    static class ManageUtility
    {
        public static ReviewFacade CreateReviewFacade()
        {
           ReviewFacade reviewFacade = new ReviewFacade();
            return reviewFacade;
        }

        public static CommentFacade CreateCommentFacade()
        {
            CommentFacade commentFacade = new CommentFacade();
            return commentFacade;
        }

        public static ArticleFacade CreateArticleFacade()
        {
            ArticleFacade articleFacade = new ArticleFacade();
            return articleFacade;
        }

        public static ReviewRepository CreateReviewRepository()
        {
            ReviewRepository reviewRepository = new ReviewRepository();
            return reviewRepository;
        }

        public static CommentRepository CreateCommentRepository()
        {
            CommentRepository commentRepository = new CommentRepository();
            return commentRepository;
        }

        public static ArticleRepository CreateArticleRepository()
        {
            ArticleRepository articleRepository = new ArticleRepository();
            return articleRepository;
        }
    }
}
