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
        private ReviewRepository m_reviewRepositoryUnit;

        public ReviewFacade()
        {
            ReviewRepository rr = new ReviewRepository();
            this.m_reviewRepositoryUnit = rr;
        }

        public List<Review> GetAllEntities()
        {
            return m_reviewRepositoryUnit.GetAllEntities();
        }

        internal void InitializeData()
        {
           m_reviewRepositoryUnit.InitializeRepository();
        }
    }
}
