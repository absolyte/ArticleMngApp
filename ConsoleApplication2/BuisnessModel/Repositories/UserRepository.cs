using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Classes;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
    class UserRepository : IUserRepositoryGeneric<User>
    {
        public List<User> AllUsersList;

        public UserRepository()
        {
          //  DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
            this.AllUsersList = new List<User>();
        
        }

        public List<User> GetAllEntities()
        {
            return this.AllUsersList;
        }

        public void InitializeRepository()
        {
            this.AllUsersList.Add(new User(5, "Broneslav", "Vryn", 48));
            this.AllUsersList.Add(new User(6, "User", "Userln", 30));
        }

        public User GetRandomUserEntity()
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

        public User GetUserEntityById(int entityIdForSearch)
        {
            return this.AllUsersList.Find(user => user.CurrentUserId.Equals(entityIdForSearch));
        }
    }
}

 
