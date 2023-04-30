using Exam03Project.Factories;
using Exam03Project.Models;
using Exam03Project.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IModelFactory mf = new ModelFactory();
            ClassToTestFactory obj = new ClassToTestFactory(mf);
            obj.RunTest();
            
            Console.ReadLine();

        }
    }
}
