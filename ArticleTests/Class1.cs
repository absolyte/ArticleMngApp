using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  FLS.ArticleManager.ConsoleApplication2;

namespace ArticleTests
{
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.That(ArticleFacade.Add(3,4), Is.EqualTo(6));
            Console.Read();
        }
    }
}
