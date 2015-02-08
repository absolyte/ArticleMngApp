using System;
using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Article : IArticle
    {
        private int m_currentArticleId;
        private string m_title;
        private string m_content;
        private int m_author;
        public float AverageRating { get; set; }

        public Article(int currentArticleId, string title, string content, int authorId)
        {
            this.m_currentArticleId = currentArticleId;
            this.m_title = title;
            this.m_content = content;
            this.m_author = authorId;
            this.AverageRating = -1;

        }

    public int Get_currentArticleId()
        {
            return this.m_currentArticleId;
        }
        
        public void ShowAverageRating()
        {
        System.Console.WriteLine(this.AverageRating);
        }
    }
}