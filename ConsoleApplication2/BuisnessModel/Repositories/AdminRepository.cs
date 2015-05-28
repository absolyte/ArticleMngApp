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
    class AdminRepository : IUserRepositoryGeneric<Admin>
    {
        public List<Admin> AllAdminsList;
        
        public AdminRepository()
        {
            this.AllAdminsList = new List<Admin>();
                
        }

        public List<Admin> GetAllEntities()
        {
            return this.AllAdminsList;
        }

        public void InitializeRepository()
        {
            this.AllAdminsList.Add(new Admin(3, "Fedor", "Rybchikov", 20));
            this.AllAdminsList.Add(new Admin(4, "Ivan", "Carevich", 50));      
        }

        public Admin GetRandomUserEntity()
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

        public Admin GetUserEntityById(int entityIdForSearch)
        {
            return this.AllAdminsList.Find(admin => admin.CurrentUserId.Equals(entityIdForSearch));
        }
    }
}