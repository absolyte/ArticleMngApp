using System;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Comment : BaseComment
    {
        private string m_commentText;
        
        public Comment(int articleIdInList, int rewiewOrCommentIdInList, string content)
        {
            this.ArticleIdInList = articleIdInList;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public Comment(int articleIdInList, int rewiewOrCommentIdInList, int idCommentAuthor, string userTag, string content)
        {
            this.ArticleIdInList = articleIdInList;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
            this.userFlag = userTag;
            this.userId = idCommentAuthor;
        }

        public Comment(string commentText)
        {
            this.m_commentText = commentText;
        }

        public Comment(int articleIdInList, string commentText)
        {
           this.ArticleIdInList = articleIdInList;
            this.Content = commentText;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }
}