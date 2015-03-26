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
            DiagnosticUtility.DiagnosticOutput(MethodBase.GetCurrentMethod().Name, this.ToString());
        AllUsersList = new List<User>();
        AllUsersList.Add(new User(5, "Broneslav", "Vryn", 48));
        AllUsersList.Add(new User(6, "User", "Userln", 30));
        }

        public List<User> GetAllUserList()
        {
            return AllUsersList;
        }
    }
}

 
