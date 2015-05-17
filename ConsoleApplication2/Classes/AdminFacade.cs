using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Classes
{
    using FLS.ArticleManager.ConsoleApplication2;

    public class AdminFacade
    {
        private IUserRepositoryGeneric<Admin> m_adminRepositoryUnit;

        public AdminFacade()
        {
            m_adminRepositoryUnit = new AdminRepository();
        }
        
        public void InitializeData()
        {
            this.m_adminRepositoryUnit.InitializeRepository();
        }

        public List<Admin> GetAllAdminsEntity()
        {
            return this.m_adminRepositoryUnit.GetAllEntities();
        }

        public Admin GetAdminById(int adminIdForSearch)
        {
            return this.m_adminRepositoryUnit.GetUserEntityById(adminIdForSearch);
        }

    }
}

