using DataStructureProblems.ArrayProblems;
using DataStructureProblems.StringProblems;
using DataStructureProblems.TreeProblems.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandParser cp = new CommandParser();
            Console.WriteLine("--name  --name");
            Console.WriteLine(cp.ValidateCommands("--name  --name"));
           
        }





    }
}
