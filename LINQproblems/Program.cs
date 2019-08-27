using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems problem = new Problems();

            //problem.FilterStrings();

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

            //problem.ProblemTwo(names);

            //List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            //problem.ProblemThree(classGrades);

            Console.WriteLine("Enter a word");
            string userInput = Console.ReadLine();

            problem.ProblemFour(userInput);
        }
    }
}
