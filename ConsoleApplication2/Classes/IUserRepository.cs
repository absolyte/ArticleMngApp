using System.Collections.Generic;

namespace ConsoleApplication2
{
    public interface IUserRepositoryGeneric<T>
    {
        List<T> GetAllEntities();
        void InitializeRepository();
        T GetRandomUserEntity();
        void AddNewUserEntity(int currentEntityId, string title, string content, int authorId);
        void DeleteUserEntityWithId(int currentEntityId);
        T GetUserEntityById(int entityIdForSearch);
    }
}