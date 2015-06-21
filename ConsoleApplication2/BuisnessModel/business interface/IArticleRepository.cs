using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.BuisnessModel.business_interface
{
    using FLS.ArticleManager.ConsoleApplication2;

    public interface IArticleRepository
    {
        List<Article> GetAllEntities();
        void InitializeRepository();
        Article GetRandomEntity();
        void AddNewEntity(int currentEntityId, string title, string content, int authorId);
        void DeleteEntityWithId(int currentEntityId);

        Article GetEntityById(int entityIdForSearch);
    }
}
