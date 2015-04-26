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
        private CommentRepository m_commentRepositoryUnit;

        public CommentFacade()
        {
            CommentRepository commentRepository = new CommentRepository();
            this.m_commentRepositoryUnit = commentRepository;
        }

        public List<Comment> GetAllCommentsList()
        {
            return m_commentRepositoryUnit.GetAllEntities();
        }


        internal void AddComment(int articleIdInList, string commentText)
        {
            m_commentRepositoryUnit.AddComment(articleIdInList, commentText);
        }

        internal void InitializeData()
        {
            m_commentRepositoryUnit.InitializeRepository();
        }
    }

    
}
