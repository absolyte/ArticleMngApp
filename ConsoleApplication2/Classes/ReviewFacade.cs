using FLS.ArticleManager.ConsoleApplication2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ReviewFacade
    {
        public ReviewRepository CreateReviews()
        {
            ReviewRepository reviewsR = new ReviewRepository();
            return reviewsR;
        }
    }
}
