namespace FLS.ArticleManager.ConsoleApplication2
{
    public abstract class BaseComment
    {
        public int ArticleIdInList { get; set; }
        public int RewiewOrCommentIdInList { get; set; }
        public string Content { get; set; }
        public string userFlag { get; set; }
        public int userId { get; set; }

        public abstract void GetEntityCode();
    }
}