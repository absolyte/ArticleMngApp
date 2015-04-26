using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication2
{
    using FLS.ArticleManager.ConsoleApplication2;

    public interface IEntityRepository<T>
    {
        List<T> GetAllEntities();
        void InitializeRepository();
        T GetRandomEntity();
        void AddNewEntity(int currentEntityId, string title, string content, int authorId);
        void DeleteEntityWithId(int currentEntityId);

        T GetEntityById(int entityIdForSearch);

    }
}