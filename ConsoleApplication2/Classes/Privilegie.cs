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
        private int _mAuthorId;
        private int _mPrivilegieIdInList;
        public string Content;

        public Privilegie(int privilegieIdInList, int authorId, string content)
        {
            this._mPrivilegieIdInList = privilegieIdInList;
            this._mAuthorId = authorId;
            this.Content = content;
        }
    }
}
