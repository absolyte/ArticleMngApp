using System;
using FLS.ArticleManager.ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    using System.Collections.Generic;

    using ConsoleApplication2;

    [TestClass]
    public class ArticleRepositoryConditionTests
    {

        [TestMethod]
        public void CouldCallInitializeData()
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
        public void AfterInitializeDataEndedRepositoryContainsItems()
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
        public void CouldCallAddNewEntity()
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
       public void AddArticleToDbWithId80RepositoryContainsArticleWithId80()
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
       public void CouldCallGetEntityById()
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
        public void GetArticleById80ReturnsArticleWithId80()
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
        public void CouldCallDeleteEntityById()
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
       public void DeleteArticleWithId80FromDbRepositoryDoesntContainsArticleWithId80()
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
        public void RandomReturnsRandomValue()
        {
            // arrange
            FakeRepository repositoryItemForTest = new FakeRepository();
            ArticleFacade articleFacadeTest = new ArticleFacade(repositoryItemForTest);
            repositoryItemForTest.AddNewEntity(1, "titleTest", "content of test article", 4);
            repositoryItemForTest.AddNewEntity(2, "titleTest", "content of test article", 4);
            repositoryItemForTest.AddNewEntity(3, "titleTest", "content of test article", 4);
            repositoryItemForTest.AddNewEntity(4, "titleTest", "content of test article", 4);

            // act
            Article randomArticle = articleFacadeTest.GetRandomArticle();

            // assert
            Assert.AreEqual(randomArticle.CurrentArticleId,  articleFacadeTest.GetArticleById(repositoryItemForTest.returnRandomValueForTestPurposes()).CurrentArticleId);
            }

    }

    public class FakeRepository : IEntityRepository<Article>
    {
        public List<Article> Articles = new List<Article>();

        private Random rand = null;
        public bool InitializeRepositoryIsCalled = false;
        public bool AddNewEntityIsCalled = false;
        public bool GetEntityByIdIsCalled = false;
        public bool DeleteEntityWithIdIsCalled = false;

        public int returnRandomValueForTestPurposes()
        {
            return this.rand.Next(this.GetAllEntities().Count);
        }

    
        public List<Article> GetAllArticles()
        {
            return Articles;
        }

        public void InitializeRepository()
        {
            InitializeRepositoryIsCalled = true;
           Articles.Add(new Article(0, "title0", "content of article 0", 1));
        }

        public List<Article> GetAllEntities()
        {
            return Articles;
        }

        public Article GetRandomEntity()
        {
            rand = new Random();
            return this.GetEntityById(rand.Next(this.GetAllEntities().Count));
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
