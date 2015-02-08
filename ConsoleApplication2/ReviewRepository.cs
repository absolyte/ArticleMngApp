using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public class ReviewRepository : IReviewRepository
    {

         public ReviewRepository()
        {
            List<Review> allReviewList = new List<Review>();
            allReviewList.Add(new Review(2, 0, "review for article with position 2 in list and rating value = 5", 5));
            allReviewList.Add(new Review(2, 1, "review for article with position 2 in list and rating value = 5", 5));
            allReviewList.Add(new Review(2, 2, "review for article with position 2 in list and rating value = 3", 3));
            allReviewList.Add(new Review(2, 3, "review for article with position 2 in list and rating value = 2", 2));
            allReviewList.Add(new Review(2, 4, "review for article with position 2 in list and rating value = 3", 3));
            allReviewList.Add(new Review(2, 5, "review for article with position 2 in list and rating value = 1", 1));
            allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
        }

       public List<Review> GetAllReviews()
       {
           return allReviewList;
       }
    }
}