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

        public void InitializeData()
        {
            m_commentRepositoryUnit.InitializeRepository();
        }

        public void AddComment(int p1, int p2, int p3, string p4, string p5)
        {
            m_commentRepositoryUnit.AddNewEntity(p1, p2, p3, p4, p5);
        }
    }

    
}
