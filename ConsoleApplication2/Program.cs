using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using ConsoleApplication2;

namespace FLS.ArticleManager.ConsoleApplication2
{
    //Names of Namespaces   <Company>.(<Product>|<Technology>)[.<Feature>][.<Subnamespace>]

    /*
     * Case Rules
     
     * Pascal Case = UpperCamelCase = the first letter must be upper case
     * Do name classes, interfaces, and value types with nouns, noun phrases, or occasionally adjective phrases, using Pascal casing.
     * Do not give class names a prefix (such as the letter C).
     * Consider ending the name of derived classes with the name of the base class.
     * Do prefix interface names with the letter I to indicate that the type is an interface.
     * Do ensure that when defining a class/interface pair where the class is a standard implementation of the interface, the names differ only by the letter I prefix on the interface name.

     * Names of Generic Type Parameters
Do name generic type parameters with descriptive names, unless a single-letter name is completely self explanatory and a descriptive name would not add value. 
Consider using the letter T as the type parameter name for types with one single-letter type parameter. 
Do prefix descriptive type parameter names with the letter T. 
Consider indicating constraints placed on a type parameter in the name of parameter. For example, a parameter constrained to ISession may be called TSession. 

     * 
     
     
     */


    //public interface IRepository<T>
    //{
     //   IEnumerable<T> GetAll();
      //  T GetByID(int id);
       // void Add(T entity);
       // void Update(T entity);
       // void Delete(T entity);
    //}

    public interface IRepository<Article>
    {
        IEnumerable<Article> GetAll();
        Article GetByID(int id);
        //void Add(T entity);
        //void Update(T entity);
        //void Delete(T entity);
    }


    class Program
    {
        static void Main(string[] args)
        {
           

            //ArticleManager testAm = new ArticleManager();
            //testAM.printArticleTitles(AllArticlesList);

            //testAm.Run();
            //persons[0].FirstName = "Новое имя";
            // foreach (Article articleobj in AllArticlesList)
            //   Console.WriteLine(articleobj.ToString());
                   
            ArticleFacade articleFacade = new ArticleFacade();
            ReviewFacade reviewFacade = new ReviewFacade();
            CommentFacade commentFacade = new CommentFacade();
            
            ArticleRepository articleRepository1 = articleFacade.CreateArticles();
            ReviewRepository reviewRepository1 = reviewFacade.CreateReviews();
            CommentRepository commentRepository1 = commentFacade.CreateComments();

            PrintReports printer1 = new PrintReports();
           // articleFacade.PrintArticleTitles();

            printer1.PrintArticleTitles(articleFacade, articleRepository1);
          articleFacade.RefreshAverageRatingForAllArticles(reviewRepository1, articleRepository1, articleFacade);
            printer1.PrintAverageRatingForEveryArticle(articleFacade, articleRepository1);

            /*
            foreach (Article currentArticle in af.CreateArticles().GetAllArticles())
            {
                currentArticle.ShowAverageRating();
            }
             */
            Console.ReadLine();
        }
    }

}


    
