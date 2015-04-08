using System;
using FLS.ArticleManager.ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
   [TestClass]
    public class ArticleRepositoryConditionTests
    {
       [TestMethod]
       public void AddArticleToDbWithId80_RepositoryContainsArticleWithId80()
       {
           // arrange
           ArticleFacade articleFacadeTest = new ArticleFacade();
           // act
           articleFacadeTest.AddArticleToDb(80, "titleTest", "content of test article", 4);
           // assert
           Assert.AreEqual(true,articleFacadeTest.GetAllArticlesList().Exists(x => x.CurrentArticleId.Equals(80)));
       }
       
       [TestMethod]
        public void GetArticleById_80_Returns_ArticleWithId80()
        {
            // arrange
            ArticleFacade articleFacadeTest = new ArticleFacade();
            articleFacadeTest.AddArticleToDb(80,"titleTest","content of test article", 4);
            // act
            Article extractArticleWithId80 = articleFacadeTest.GetArticleById(80);
            // assert
            Assert.AreEqual(80, extractArticleWithId80.CurrentArticleId);
        }
       
       [TestMethod]
       public void DeleteArticleWithId80FromDb_RepositoryDoesntContainsArticleWithId80()
       {
           // arrange
           ArticleFacade articleFacadeTest = new ArticleFacade();
           articleFacadeTest.AddArticleToDb(80, "titleTest", "content of test article", 4);
           // act
          articleFacadeTest.DeleteArticleFromDb(80);
           // assert
           Assert.AreEqual(false, articleFacadeTest.GetAllArticlesList().Exists(x => x.CurrentArticleId.Equals(80)));
       }

       
    }

}
