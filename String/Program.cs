using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace String
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ConcatenateStrings
            Console.WriteLine("Обьединение слов в одну строку! Введите вначале одно слово, а после другое: ");
            Console.WriteLine("Слова обьединились: " + ConcatenateStrings(Console.ReadLine(), Console.ReadLine()));

            //2 GreetUser
            Console.WriteLine("\nВведите ваше ИМЯ, а после введите ваш ВОЗРАСТ: ");
            Console.WriteLine(GreetUser(Console.ReadLine(), int.Parse(Console.ReadLine())));

            //3 InfoString
            Console.WriteLine("\nВведите слово, для отображения кол-ва его символов и визуализации в разных регистрах: ");
            Console.WriteLine("Информация по введенному слову:\n" + InfoString(Console.ReadLine()));

            //4 ReturnFiveСharacters
            Console.WriteLine("\nВведите слово или предложение, в котором более 5 символов: ");
            Console.WriteLine("Возвращенны первые пять символов: " + ReturnFiveСharacters(Console.ReadLine()));

            //5 ConcatenatesElementsArray
            Console.WriteLine("\nВведите вначале одно предложение, а после другое: ");
            string[] strArray = { Console.ReadLine(), Console.ReadLine() };
            Console.WriteLine("Теперь предложение из массива выглядит так: " + ConcatenatesElementsArray(strArray));

            //6 ReplaceWords
            Console.WriteLine("\nВведите текст для изменения, после слово которое хотите изменить, а далее то слово на которое хотели бы изменить: ");
            Console.WriteLine("Текст был изменен следующим образом: " + ReplaceWords(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));

            //MyTestWork.MyTest();
            //MyTestWork.PracticeFromVideo();
        }

        static string ConcatenateStrings(string oneString, string twoString)
        {
            return $"{oneString} {twoString}";
        }

        static string GreetUser(string username, int age)
        {
            return $"Hello, {username}! You are {age} years old.";
        }

        static string InfoString(string infoString)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Number of characters per line: {infoString.Count()}\n");
            sb.Append($"Uppercase string: {infoString.ToUpper()}\n");
            sb.Append($"Lowercase string: {infoString.ToLower()}\n");
            return sb.ToString();
        }

        static string ReturnFiveСharacters(string infoString)
        {
            return infoString.Substring(0, 5);
        }

        static StringBuilder ConcatenatesElementsArray(string[] infoString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < infoString.Length; i++)
            {
                stringBuilder.Append(infoString[i]);
                if (i + 1 != infoString.Length)
                {
                    stringBuilder.Append(' ');
                }
                else
                {
                    stringBuilder.Append('.');
                }
            }
            return stringBuilder;
        }

        static string ReplaceWords(string text, string word, string replaceWord)
        {
            return text.Replace(word, replaceWord);
        }

    }
}
