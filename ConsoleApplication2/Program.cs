using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using ConsoleApplication2;
using ConsoleApplication2.Classes;

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
     */

    class Program
    {
        static void Main(string[] args)
        {
            PrintReports printer1 = new PrintReports();
            printer1.PrintArticleTitles();
            printer1.PrintAverageRatingForEveryArticle();
            printer1.RefreshAverageRating();
            printer1.PrintAverageRatingForEveryArticle();
            //articleFacade.RefreshAverageRatingForAllArticles(reviewRepository1, articleRepository1, articleFacade);
            //printer1.PrintAverageRatingForEveryArticle(articleFacade, articleRepository1);
            System.Console.ReadLine();

        }
    }

}


    
