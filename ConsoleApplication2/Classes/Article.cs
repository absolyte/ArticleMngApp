using System;
using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class Article : IArticle
    {
        private int _mCurrentArticleId;
        private string _mTitle;
        private string _mContent;
        private int _mAuthor;
        private float _mAverageRating;
        
        public Article(int currentArticleId, string title, string content, int authorId)
        {
            this.CurrentArticleId = currentArticleId;
            this.Title = title;
            this._mContent = content;
            this._mAuthor = authorId;
            this._mAverageRating = -1;
        }

        public Article()
        {
         }

        public string Title
        {
            get { return this._mTitle; }
            protected set { this._mTitle = value; }
        }

        public int CurrentArticleId
        {
            get { return this._mCurrentArticleId; }
            protected set { this._mCurrentArticleId = value; }
        }

        public void SetAverageRating(float averageRating)
        {
            this._mAverageRating = averageRating;
        }

        public void ShowAverageRating()
        {
            System.Console.WriteLine("Article {0} have average rating {1}", this.Title, this._mAverageRating);
        }
     }
}