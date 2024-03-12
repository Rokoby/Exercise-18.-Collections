using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");
            string s = Console.ReadLine();
            if (stringChecking(s) == true)
                Console.WriteLine("Скобки расставлены корректно");
            else
                Console.WriteLine("Скобки расставлены некорректно");
            Console.ReadKey();
        }
        static bool stringChecking(string s)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                { '(', ')' },
                {'{', '}' },
                {'[',']' }
            };
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c=='{' || c=='[')
                    stack.Push(brackets[c]);
                if (c== ')' || c=='}' || c==']')
                {
                    if (stack.Count == 0 || c != stack.Pop())
                        return false;
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
