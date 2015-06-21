using System;
using FLS.ArticleManager.ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.Collections.Generic;
    using ConsoleApplication2;
    using ConsoleApplication2.BuisnessModel.business_interface;
    
    using NMock;
    using NUnit.Framework;
    

    [TestFixture]
    public class ArticleFacadeTest
    {
        private Mockery m_mocks;
        private IArticleRepository m_mockArticleRepositoryEntity;
        private IEntityFacade articleEntityFacade;

        [SetUp]
        public void SetUp()
        {
            m_mocks = new Mockery();
            m_mockArticleRepositoryEntity = m_mocks.NewMock<IArticleRepository>();
            articleEntityFacade = new ArticleFacade(m_mockArticleRepositoryEntity);
        }
        
        [Test]
        public void NmockGetArticleById80()
        {
            Expect.Once.On(m_mockArticleRepositoryEntity).
                Method("GetEntityById").
                With(80).
                Will(Return.Value(2.20));

            Article NMockReturnedArticle = articleEntityFacade.GetArticleById(80);

            Assert.AreEqual(80, NMockReturnedArticle.CurrentArticleId);
            m_mocks.VerifyAllExpectationsHaveBeenMet();
        }
    }

   


    [TestClass]
    public class ArticleRepositoryConditionTests
    {

        [TestMethod]
        public void CouldCallInitializeDataTest()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade target = new ArticleFacade(repositoryItemForTest);
            // act
            target.InitializeData();

            // assert
            Assert.IsTrue(repositoryItemForTest.InitializeRepositoryIsCalled);
        }

        [TestMethod]
        public void AfterInitializeDataEndedRepositoryContainsItemsTest()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade articleFacadeTest = new ArticleFacade();
            // act
            articleFacadeTest.InitializeData();
            //assert
            Assert.IsNotNull(repositoryItemForTest.GetAllEntities());
        }

        [TestMethod]
        public void CouldCallAddNewEntityTest()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade target = new ArticleFacade(repositoryItemForTest);
            
            // act
            target.AddArticleToDb(80, "titleTest", "content of test article", 4);

            // assert
            Assert.IsTrue(repositoryItemForTest.AddNewEntityIsCalled);
        }

       [TestMethod]
        public void AddArticleToDbWithId80RepositoryContainsArticleWithId80Test()
       {
           // arrange
           FakeRepository repositoryItemForTest = new FakeRepository();
           ArticleFacade articleFacadeTest = new ArticleFacade(repositoryItemForTest);
           // act
           articleFacadeTest.AddArticleToDb(80, "titleTest", "content of test article", 4);
           // assert
           Assert.AreEqual(true,articleFacadeTest.GetAllArticlesList().Exists(x => x.CurrentArticleId.Equals(80)));
       }

        [TestMethod]
       public void CouldCallGetEntityByIdTest()
       {
           // arrange
           FakeRepository repositoryItemForTest = new FakeRepository();
           ArticleFacade target = new ArticleFacade(repositoryItemForTest);

           // act
           target.GetArticleById(80);

           // assert
           Assert.IsTrue(repositoryItemForTest.GetEntityByIdIsCalled);
       }

        [TestMethod]
        public void GetArticleById80ReturnsArticleWithId80Test()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade articleFacadeTest = new ArticleFacade(repositoryItemForTest);
            repositoryItemForTest.AddNewEntity(80, "titleTest", "content of test article", 4);
            // act
            Article extractArticleWithId80 = articleFacadeTest.GetArticleById(80);
            // assert
            Assert.AreEqual(80, extractArticleWithId80.CurrentArticleId);
        }

        [TestMethod]
        public void CouldCallDeleteEntityByIdTest()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade target = new ArticleFacade(repositoryItemForTest);

            // act
            target.DeleteArticleFromDb(80);

            // assert
            Assert.IsTrue(repositoryItemForTest.DeleteEntityWithIdIsCalled);
        }

        [TestMethod]
        public void DeleteArticleWithId80FromDbRepositoryDoesntContainsArticleWithId80Test()
       {
           // arrange
           FakeRepository repositoryItemForTest = new FakeRepository();
           ArticleFacade articleFacadeTest = new ArticleFacade(repositoryItemForTest);
           repositoryItemForTest.AddNewEntity(80, "titleTest", "content of test article", 4);
           
           // act
          articleFacadeTest.DeleteArticleFromDb(80);
           
            // assert
           Assert.AreEqual(false, articleFacadeTest.GetAllArticlesList().Exists(x => x.CurrentArticleId.Equals(80)));
       }

        [TestMethod]
        public void RandomReturnsRandomValueTest()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade articleFacadeTest = new ArticleFacade(repositoryItemForTest);
           repositoryItemForTest.InitializeRepository();
            // act
            Article randomArticle = articleFacadeTest.GetRandomArticle();
            System.Console.WriteLine(repositoryItemForTest.GetEntityById(0).CurrentArticleId);
            System.Console.WriteLine(repositoryItemForTest.GetEntityById(1).CurrentArticleId);
            System.Console.WriteLine(repositoryItemForTest.GetEntityById(2).CurrentArticleId);
            System.Console.WriteLine(repositoryItemForTest.GetEntityById(3).CurrentArticleId);
            // assert
            Assert.AreEqual(randomArticle.CurrentArticleId,  articleFacadeTest.GetArticleById(repositoryItemForTest.ReturnRandomValueForTestPurposes()).CurrentArticleId);
            }

    }

    public class FakeRepository : IEntityRepository<Article>
    {
        public List<Article> Articles = new List<Article>();
        
        public bool InitializeRepositoryIsCalled = false;
        public bool AddNewEntityIsCalled = false;
        public bool GetEntityByIdIsCalled = false;
        public bool DeleteEntityWithIdIsCalled = false;

        private Random m_rand = new Random();
        private Random m_rand1 = new Random();

        public int ReturnRandomValueForTestPurposes()
        {
            return this.m_rand1.Next(this.GetAllEntities().Count);
        }

    
        public List<Article> GetAllArticles()
        {
            return Articles;
        }

        public void InitializeRepository()
        {
            InitializeRepositoryIsCalled = true;
            Articles.Add(new Article(0, "titleTest", "content of test article", 4));
            Articles.Add(new Article(1, "titleTest", "content of test article", 4));
            Articles.Add(new Article(2, "titleTest", "content of test article", 4));
            Articles.Add(new Article(3, "titleTest", "content of test article", 4));

          }

        public List<Article> GetAllEntities()
        {
            return Articles;
        }

        public Article GetRandomEntity()
        {
            return this.GetEntityById(this.m_rand.Next(this.GetAllEntities().Count));
        }

        public void AddNewEntity(int currentEntityId, string title, string content, int authorId)
        {
            AddNewEntityIsCalled = true;
            Articles.Add(new Article(currentEntityId, title, content, authorId));
        }

        public void DeleteEntityWithId(int currentEntityId)
        {
            DeleteEntityWithIdIsCalled = true;

            if (Articles.Exists(x => x.CurrentArticleId.Equals(currentEntityId)))
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentEntityId + "founded. Delete procedure started.");
                Articles.Remove(Articles.Find(article => article.CurrentArticleId.Equals(currentEntityId)));
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentEntityId + " deleted.");
            }
            else
            {
                PrintReports.PrintMessage("Article with 'currentArticleId' =" + currentEntityId + "not founded. Delete procedure not started."); ;
            }
        }

        public Article GetEntityById(int entityIdForSearch)
        {
            GetEntityByIdIsCalled = true;
            return Articles.Find(article => article.CurrentArticleId.Equals(entityIdForSearch));
        }

      
        public Article GetArticleEntityById(int articleIdForSearch)
        {
            throw new NotImplementedException();
        }

    }

 }
