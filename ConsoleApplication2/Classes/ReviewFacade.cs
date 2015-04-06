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
        private ReviewRepository _reviewRepositoryUnit;

        public ReviewFacade()
        {
            ReviewRepository rr = new ReviewRepository();
            this._reviewRepositoryUnit = rr;
        }

        public List<Review> GetAllReviewsList()
        {
            return _reviewRepositoryUnit.GetAllEntitiesList();
        }
    }
}
