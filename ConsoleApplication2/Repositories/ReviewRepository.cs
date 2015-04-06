using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    // public class ReviewRepository : IReviewRepository
    public class ReviewRepository :    IBaseCommentRepositoryGeneric<Review>
    {
        private List<Review> _mAllReviewList; 
         public ReviewRepository()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());

            _mAllReviewList = new List<Review> ();
            _mAllReviewList.Add(new Review(2, 0, "review for article with position 2 in list and rating value = 5", 5));
            _mAllReviewList.Add(new Review(2, 1, "review for article with position 2 in list and rating value = 5", 5));
            _mAllReviewList.Add(new Review(2, 2, "review for article with position 2 in list and rating value = 3", 3));
            _mAllReviewList.Add(new Review(2, 3, "review for article with position 2 in list and rating value = 2", 2));
            _mAllReviewList.Add(new Review(2, 4, "review for article with position 2 in list and rating value = 3", 3));
            _mAllReviewList.Add(new Review(2, 5, "review for article with position 2 in list and rating value = 1", 1));
            _mAllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            _mAllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
            _mAllReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
        }

     //  public List<Review> GetAllReviews()
      // {
       //    return AllReviewList;
      // }

       public List<Review> GetAllEntitiesList()
       {
           return _mAllReviewList;
       }

    }
}