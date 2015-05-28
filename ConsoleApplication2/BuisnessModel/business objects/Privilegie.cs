using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FLS.ArticleManager.ConsoleApplication2;

namespace ConsoleApplication2
{
    public class Privilegie
    {
        private int m_mAuthorId;
        private int m_mPrivilegieIdInList;
        public string Content;

        public Privilegie(int privilegieIdInList, int authorId, string content)
        {
            this.m_mPrivilegieIdInList = privilegieIdInList;
            this.m_mAuthorId = authorId;
            this.Content = content;
        }
    }
}
