using System;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Comment : BaseComment
    {
        public Comment(int articleIdInList, int rewiewOrCommentIdInList, string content)
        {
            this.ArticleIdInList = articleIdInList;
            this.Content = content;
            this.RewiewOrCommentIdInList = rewiewOrCommentIdInList;
        }

        public override void GetEntityCode()
        {
            throw new NotImplementedException();
        }
    }
}