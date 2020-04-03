/*У текстовому файлі міститься математичний вираз. Перевірити баланс
круглих дужок в даному виразі, використовуючи колекції (список/стек/чергу)
Вміст файлу: (1+2)-4*(a-3)/(2-7+6)
Перевірити роботу програми при різному вмісті файлу.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    Console.WriteLine("Чтение тз файла");
                    String input = sr.ReadLine();
                    Console.WriteLine(input);
                    Stack stack = new Stack();
                    bool balance = true;
                    foreach (char item in input)
                    {
                        if(item == '(')
                        {
                            Console.Write("(");
                            stack.Push(item);
                        }
                        if(item == ')')
                        {
                            Console.Write(")");
                            if (stack.Count != 0)
                            {
                                stack.Pop();
                            }
                            else
                            {
                                balance = false;
                            }
                        }
                    }
                    if (stack.Count == 0 && balance)
                    {
                        Console.WriteLine("\nБаланс достигнут");
                    }
                    else
                    {
                        Console.WriteLine("\nБаланса нет");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    
}
