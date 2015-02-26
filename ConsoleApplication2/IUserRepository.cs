using System.Collections.Generic;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}