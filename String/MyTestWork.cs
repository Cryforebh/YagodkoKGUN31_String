using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class MyTestWork
    {
        public static void PracticeFromVideo()
        {
            string[] _categoriesArray = { "Numbers", "Animals" };
            const string VALUE = "Const";

            Dictionary<int, string> categories = new Dictionary<int, string>()
            {
                { 1, _categoriesArray[0] },
                { 2, _categoriesArray[1] },
            };

            var categoryQuestions = new Dictionary<int, Dictionary<string, string>>();
            var questions = new Dictionary<string, string>() { { "PI?", "3.14" } };

            categoryQuestions.Add(1, questions);
            Console.WriteLine("Select category 1 or 2");
            var selected = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your category {categories[selected]}");
            var result = categoryQuestions[selected];
            foreach (var category in result)
            {
                Console.WriteLine(category.Key);
                int attempts = 0;
                while (true)
                {
                    var answer = Console.ReadLine();
                    attempts++;
                    if (attempts >= 3 || answer == category.Value)
                    {
                        break;
                    }
                }
                if (attempts < 3)
                {
                    Console.WriteLine("you won!");
                }

                break;
            }
        }

        public static void MyTest()
        {
            string str = "Hello, Kirill!";
            str = str.Insert(0, "Love! ");
            Console.WriteLine(str);

            Console.Write("\n");
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(i + " = " + strArray[i] + "\t");
            }

            Console.WriteLine("\n");
            string strTwo = str.Substring(6, 5);
            Console.WriteLine(strTwo);

            Console.Write("\n");
            Console.WriteLine("Есть ли запитая? - " + str.Contains(','));

            char chr = 'd';
            Console.WriteLine(char.IsLetter(chr));
            Console.WriteLine(char.ToUpper(chr));

            Console.Write("\n");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{str} Ohh, no... {strArray[2]} {strArray[0]}\n{strTwo}... {chr} - {char.ToUpper(chr)}");
            Console.WriteLine(stringBuilder);

            Console.Write("\n");
            stringBuilder.Append($"\nТут прям все на Английском????");
            stringBuilder.Append(@"\n");

            Console.WriteLine(stringBuilder.Replace(str, "").ToString());
        }
    }
}
