using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2 
{
    class AuthorRepository : IUserRepositoryGeneric<Author>
    {
        public List<Author> AllAuthorsList;

        public AuthorRepository()
        {
            this.AllAuthorsList = new List<Author>();
        }

        public List<Author> GetAllEntities()
        {
            return this.AllAuthorsList;
        }

        public void InitializeRepository()
        {
            AllAuthorsList.Add(new Author(0, "Ivan", "Suslikov", 30));
            AllAuthorsList.Add(new Author(1, "Oleg", "Moroz", 43));
            AllAuthorsList.Add(new Author(2, "Mikhail", "Rybokon", 25));
        }

        public Author GetRandomUserEntity()
        {
            throw new NotImplementedException();
        }

        public void AddNewUserEntity(int currentEntityId, string title, string content, int authorId)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserEntityWithId(int currentEntityId)
        {
            throw new NotImplementedException();
        }

        public Author GetUserEntityById(int entityIdForSearch)
        {
            return this.AllAuthorsList.Find(author => author.CurrentUserId.Equals(entityIdForSearch));
        }
    }
}
