using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.BuisnessModel.business_interface
{
    using FLS.ArticleManager.ConsoleApplication2;

    public interface IEntityFacade
    {
        void InitializeData();
        Article GetArticleById(int articleIdForSearch);
    }
}
