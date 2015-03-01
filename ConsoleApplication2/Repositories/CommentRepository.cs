using System.Collections.Generic;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
   // public class CommentRepository : ICommentRepository
    public class CommentRepository : IBaseCommentRepositoryGeneric<Comment>
    {
        public List<Comment> AllCommentsList;

        public CommentRepository()
        {
        AllCommentsList = new List<Comment>();
        AllCommentsList.Add(new Comment(2, 0,"content comment 0 article 2"));
        AllCommentsList.Add(new Comment(2, 1, "content comment 1 article 2"));
        AllCommentsList.Add(new Comment(2, 2, "content comment 2 article 2"));
        AllCommentsList.Add(new Comment(1, 3, "content comment 3 article 1"));
        AllCommentsList.Add(new Comment(1, 4, "content comment 4 article 1"));
        AllCommentsList.Add(new Comment(1, 5, "content comment 5 article 1"));
        AllCommentsList.Add(new Comment(0, 6, "content comment 6 article 0"));
        AllCommentsList.Add(new Comment(0, 7, "content comment 7 article 0"));
        AllCommentsList.Add(new Comment(3, 8, "content comment 8 article 3"));
        AllCommentsList.Add(new Comment(4, 9, "content comment 9 article 4"));
        AllCommentsList.Add(new Comment(4, 10, "content comment 10 article 4"));
        }


      //  public List<Comment> GetAllComments()
      //  {
       //     return AllCommentsList;
       // }

        public List<Comment> GetAllEntitiesList()
        {
            return AllCommentsList;
        }
    }
}