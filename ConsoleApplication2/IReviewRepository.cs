using System.Collections.Generic;

namespace FLS.ArticleManager.ConsoleApplication2
{
    public interface IReviewRepository
    {
        List<Review> GetAllReviews();
    }
}