using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    public class Problems
    {


        public Problems()
        {

        }

        public void FilterStrings()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (var THwords in wordsWithTH)
            {
                Console.WriteLine(THwords);

            }
            Console.ReadLine();
        }

        public List<string> ProblemTwo(List<string> names)
        {

            List<string> newNames = names.Distinct().ToList();
            foreach (var item in newNames)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            return newNames;
        }

        public void ProblemThree(List<string> classGrades)
        {
            List<double> gradeAvgs = new List<double>();
            List<int> gradeHolder = new List<int>();
            for (int i = 0; i < classGrades.Count; i++)
            {
                var Student = classGrades[i];
                string[] StudentScores = Student.Split(',');
                foreach (string score in StudentScores)
                {
                    gradeHolder.Add(int.Parse(score));
                }
                gradeHolder.Remove(gradeHolder.Min());
                gradeAvgs.Add(gradeHolder.Average());
                gradeHolder.RemoveRange(0, gradeHolder.Count);
            }
            Console.WriteLine(gradeAvgs.Average());
            Console.ReadLine();

        }

        public string ProblemFour(string userInput)
        {
            StringBuilder sb = new StringBuilder();
            var input = userInput.OrderBy(c => c);
            char[] stringArray = input.ToArray();
            int charCount = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; j < stringArray.Length; j++)
                {
                    if (stringArray[i] == stringArray[j])
                    {
                        charCount++;
                    }
                    else
                    {
                        continue;
                    }
                }
                try
                {
                    if (stringArray[i] == stringArray[i + 1])
                    {
                        charCount = 0;
                        continue;
                    }
                    else
                    {
                        sb.Append($"{stringArray[i]}{charCount}");
                        charCount = 0;
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    stringArray[i] = stringArray[i];
                    sb.Append($"{stringArray[i]}{charCount}");
                }

            }
            Console.WriteLine(sb);
            Console.ReadLine();
            return sb.ToString();
        }

    }
}
