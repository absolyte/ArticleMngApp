using FLS.ArticleManager.ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class ReviewFacade
    {
        private ReviewRepository reviewRepositoryUnit;

        public ReviewFacade()
        {
            ReviewRepository rr = new ReviewRepository();
            this.reviewRepositoryUnit = rr;
        }

        public List<Review> GetAllReviewsList()
        {
            return reviewRepositoryUnit.GetAllEntitiesList();
        }
    }
}
