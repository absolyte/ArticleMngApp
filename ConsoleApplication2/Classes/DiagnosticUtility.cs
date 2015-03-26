using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Classes
{
    class DiagnosticUtility
    {
        public static void DiagnosticOutput(string nameOfStartedMethod, string nameOfClassWhichWeAreCurrentlyIn)
        {
            Console.WriteLine("Method {0} started in class {1}." + "\n", nameOfStartedMethod, nameOfClassWhichWeAreCurrentlyIn);
        }
    }
}
