using System.Collections.Generic;
using System.Reflection;
using ConsoleApplication2;
using ConsoleApplication2.Classes;

namespace FLS.ArticleManager.ConsoleApplication2
{
    // public class ReviewRepository : IReviewRepository
    public class ReviewRepository : IBaseCommentRepositoryGeneric<Review>
    {
        private List<Review> m_allReviewList; 
         public ReviewRepository()
        {
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());

            m_allReviewList = new List<Review>();
          
        }

     //  public List<Review> GetAllReviews()
      // {
       //    return AllReviewList;
      // }
         public void InitializeRep()
         {
             m_allReviewList.Add(new Review(2, 0, "review for article with position 2 in list and rating value = 5", 5));
             m_allReviewList.Add(new Review(2, 1, "review for article with position 2 in list and rating value = 5", 5));
             m_allReviewList.Add(new Review(2, 2, "review for article with position 2 in list and rating value = 3", 3));
             m_allReviewList.Add(new Review(2, 3, "review for article with position 2 in list and rating value = 2", 2));
             m_allReviewList.Add(new Review(2, 4, "review for article with position 2 in list and rating value = 3", 3));
             m_allReviewList.Add(new Review(2, 5, "review for article with position 2 in list and rating value = 1", 1));
             m_allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
             m_allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
             m_allReviewList.Add(new Review(4, 1, "review for article with position 4 in list and rating value = 5", 5));
         }

       public List<Review> GetAllEntitiesList()
       {
           return m_allReviewList;
       }

    }
}