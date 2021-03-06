﻿/*Вирішити з використанням колекції Stack:
Дано файл, в якому записаний набір чисел. Переписати в інший файл всі числа в
зворотному порядку.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    Console.WriteLine("Чтение из файла");
                    String input = sr.ReadLine();
                    Console.WriteLine(input);

                    String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (String item in words)
                    {
                        int temp;
                        if (Int32.TryParse(item,out temp))
                        {
                            stack.Push(temp);
                        }
                        else
                        {
                            Console.WriteLine("Пропущен неверный символ");
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
                {
                    Console.WriteLine("Ответ в файле output.txt в папке с программой");
                    sw.WriteLine("\nЧисла в обратном порядке(с использованием Stack)");
                    while (stack.Count != 0)
                        sw.Write(stack.Pop() + " ");
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
