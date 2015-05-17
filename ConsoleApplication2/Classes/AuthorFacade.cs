using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2.Classes
{
    

    class AuthorFacade
    {
        private IUserRepositoryGeneric<Author> m_authorRepositoryUnit;

        public AuthorFacade()
        {
            m_authorRepositoryUnit = new AuthorRepository();
        }
        
        public void InitializeData()
        {
            this.m_authorRepositoryUnit.InitializeRepository();
        }

        public List<Author> GetAllAuthorsEntity()
        {
            return this.m_authorRepositoryUnit.GetAllEntities();
        }

        public Author GetAuthorById(int authorIdForSearch)
        {
            return this.m_authorRepositoryUnit.GetUserEntityById(authorIdForSearch);
        }
    }
}
