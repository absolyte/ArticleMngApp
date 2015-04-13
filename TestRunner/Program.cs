using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.ConsoleRunner;
using NUnit.Core;

namespace TestRunner
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            InternalTrace.Initialize("nunit-console_%p, log",(InternalTraceLevel)1);
            return Runner.Main(args);
        }
    }
}
