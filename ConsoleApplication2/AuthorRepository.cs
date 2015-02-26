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
            AllAuthorsList = new List<Author>();
            AllAuthorsList.Add(new Author(0, "Ivan", "Suslikov", 30));
            AllAuthorsList.Add(new Author(1, "Oleg", "Moroz", 43));
            AllAuthorsList.Add(new Author(2, "Mikhail", "Rybokon", 25));
        }


        public List<Author> GetAllUserList()
        {
            return AllAuthorsList;
        }
    }
}
