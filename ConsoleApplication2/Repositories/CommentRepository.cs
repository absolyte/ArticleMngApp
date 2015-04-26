using System.Collections.Generic;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
   // public class CommentRepository : ICommentRepository
    public class CommentRepository : IEntityRepository<Comment>
    {
        private List<Comment> m_allCommentsList;

        public CommentRepository()
        {
        this.m_allCommentsList = new List<Comment>();
        }

        public List<Comment> GetAllEntities()
        {
            return this.m_allCommentsList;
        }

        public void AddComment(int articleIdInList, string commentText)
        {
            this.m_allCommentsList.Add(new Comment(articleIdInList, commentText));
        }

        public void InitializeRepository()
        {
            this.m_allCommentsList.Add(new Comment(2, 0, "content comment 0 article 2"));
            this.m_allCommentsList.Add(new Comment(2, 1, "content comment 1 article 2"));
            this.m_allCommentsList.Add(new Comment(2, 2, "content comment 2 article 2"));
            this.m_allCommentsList.Add(new Comment(1, 3, "content comment 3 article 1"));
            this.m_allCommentsList.Add(new Comment(1, 4, "content comment 4 article 1"));
            this.m_allCommentsList.Add(new Comment(1, 5, "content comment 5 article 1"));
            this.m_allCommentsList.Add(new Comment(0, 6, "content comment 6 article 0"));
            this.m_allCommentsList.Add(new Comment(0, 7, "content comment 7 article 0"));
            this.m_allCommentsList.Add(new Comment(3, 8, "content comment 8 article 3"));
            this.m_allCommentsList.Add(new Comment(4, 9, "content comment 9 article 4"));
            this.m_allCommentsList.Add(new Comment(4, 10, "content comment 10 article 4"));
        }

        public Comment GetRandomEntity()
        {
            throw new System.NotImplementedException();
        }

        public void AddNewEntity(int currentEntityId, string title, string content, int authorId)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEntityWithId(int currentEntityId)
        {
            throw new System.NotImplementedException();
        }

        public Comment GetEntityById(int entityIdForSearch)
        {
            throw new System.NotImplementedException();
        }
    }
}