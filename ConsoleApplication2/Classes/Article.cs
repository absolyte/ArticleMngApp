using System;
using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Article : IArticle
    {
        private int m_mCurrentArticleId;
        private string m_mTitle;
        private string m_mContent;
        private int m_mAuthor;
        private float m_mAverageRating;

        public Article(int currentArticleId, string title, string content, int authorId)
        {
            this.CurrentArticleId = currentArticleId;
            this.Title = title;
            this.Content = content;
            this.m_mAuthor = authorId;
            this.m_mAverageRating = -1;
        }

        public Article()
        {
         }

        public string Title
        {
            get { return this.m_mTitle; }
            protected set { this.m_mTitle = value; }
        }

        public int CurrentArticleId
        {
            get { return this.m_mCurrentArticleId; }
            protected set { this.m_mCurrentArticleId = value; }
        }

        public void SetAverageRating(float averageRating)
        {
            this.m_mAverageRating = averageRating;
        }

        public void ShowAverageRating()
        {
            System.Console.WriteLine("Article {0} have average rating {1}", this.Title, this.m_mAverageRating);
        }

        public string Content 
        { 
            get{ return this.m_mContent;} 
            protected set{ this.m_mContent = value; }
        }

        }
    }
