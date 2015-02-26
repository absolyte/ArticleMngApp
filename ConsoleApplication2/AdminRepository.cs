using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
    class AdminRepository : IUserRepositoryGeneric<Admin>
    {
        public List<Admin> AllAdminsList;
        
        public AdminRepository()
        {
            AllAdminsList = new List<Admin>();
            AllAdminsList.Add(new Admin(3, "Fedor", "Rybchikov", 20));
            AllAdminsList.Add(new Admin(4, "Ivan", "Carevich", 50));          
        }

        public List<Admin> GetAllUserList()
        {
            return AllAdminsList;
        }
    }
}