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
        private int m_authorId;
        private int m_privilegieIdInList;
        public string Content;

        public Privilegie(int privilegieIdInList, int authorId, string content)
        {
            this.m_privilegieIdInList = privilegieIdInList;
            this.m_authorId = authorId;
            this.Content = content;
        }
    }
}
