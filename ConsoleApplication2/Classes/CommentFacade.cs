using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
    public class CommentFacade
    {
        private CommentRepository _commentRepositoryUnit;

        public CommentFacade()
        {
            CommentRepository commentRepository = new CommentRepository();
            this._commentRepositoryUnit = commentRepository;
        }

        public List<Comment> GetAllCommentsList()
        {
            return _commentRepositoryUnit.GetAllEntitiesList();
        }
    
    }

    
}
