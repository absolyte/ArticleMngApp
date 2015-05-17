using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2.Classes
{
    class UserFacade
    {
        private IUserRepositoryGeneric<User> m_userRepositoryUnit;

        public UserFacade()
        {
            m_userRepositoryUnit = new UserRepository();
        }
        
        public void InitializeData()
        {
            this.m_userRepositoryUnit.InitializeRepository();
        }

        public List<User> GetAllUsersEntity()
        {
            return this.m_userRepositoryUnit.GetAllEntities();
        }

        public User GetUserById(int userIdForSearch)
        {
            return this.m_userRepositoryUnit.GetUserEntityById(userIdForSearch);
        }
    }
}
