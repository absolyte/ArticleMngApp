using System.Collections.Generic;
using ConsoleApplication2;

namespace FLS.ArticleManager.ConsoleApplication2
{
    // public class ReviewRepository : IReviewRepository
    public class ReviewRepository :    IBaseCommentRepositoryGeneric<Review>
    {
        private List<Review> AllReviewList; 
         public ReviewRepository()
        {
            AllReviewList = new List<Review> ();
            AllReviewList.Add(new Review(2, 0, "review for article with position 2 in list and rating value = 5", 5));
            AllReviewList.Add(new Review(2, 1, "review for article with position 2 in list and rating value = 5", 5));
            AllReviewList.Add(new Review(2, 2, "review for article with position 2 in list and rating value = 3", 3));
            AllReviewList.Add(new Review(2, 3, "review for article with position 2 in list and rating value = 2", 2));
            AllReviewList.Add(new Review(2, 4, "review for article with position 2 in list and rating value = 3", 3));
            AllReviewList.Add(new Review(2, 5, "review for article with position 2 in list and rating value = 1", 1));
            AllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            AllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            AllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
        }

     //  public List<Review> GetAllReviews()
      // {
       //    return AllReviewList;
      // }

       public List<Review> GetAllEntitiesList()
       {
           return AllReviewList;
       }
    }
}