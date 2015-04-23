using System;
using FLS.ArticleManager.ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.Collections.Generic;

    [TestClass]
    public class ArticleRepositoryConditionTests
    {
       [TestMethod]
       public void AddArticleToDbWithId80RepositoryContainsArticleWithId80()
       {
           // arrange
           ArticleFacade articleFacadeTest = new ArticleFacade();
           // act
           articleFacadeTest.AddArticleToDb(80, "titleTest", "content of test article", 4);
           // assert
           Assert.AreEqual(true,articleFacadeTest.GetAllArticlesList().Exists(x => x.CurrentArticleId.Equals(80)));
       }
       
       [TestMethod]
        public void GetArticleById80ReturnsArticleWithId80()
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
       public void DeleteArticleWithId80FromDbRepositoryDoesntContainsArticleWithId80()
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


   [TestClass]
   public class ArticleFacadeBehaviourTests
   {
       [TestMethod]
       public void CouldCallInitializeData()
       {
           // arrange
           FakeRepository repositoryItemForTest = new FakeRepository();
           FakeRepository.ArticleFacadeTesting target = new FakeRepository.ArticleFacadeTesting(repositoryItemForTest);
           bool resultShouldBeTrue;

           // act
           target.InitializeData();

           // assert
           Assert.IsTrue(repositoryItemForTest.InitializeRepositoryIsCalled);
       }


   }

    public class FakeRepository : IArticleRepository
    {
        public List<Article> Articles = new List<Article>();
        public bool InitializeRepositoryIsCalled = false;

        public List<Article> GetAllArticles()
        {
            throw new NotImplementedException();
        }

        public void InitializeRepository()
        {
            InitializeRepositoryIsCalled = true;
        }

        public class ArticleFacadeTesting : ArticleFacade
        {
            private ArticleRepository m_articleRepositoryUnit;
            private IArticleRepository m_articleRepositoryUnitForTest; //DI member

           //trying use DI
            public ArticleFacadeTesting(IArticleRepository repository)
            {
                m_articleRepositoryUnitForTest = repository;
            }

            public new void InitializeData()
            {
                this.m_articleRepositoryUnitForTest.InitializeRepository();
            }
        }
    }

 }
