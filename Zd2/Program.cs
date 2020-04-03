/*У текстовому файлі записана інформація про людей(прізвище, ім'я, по
батькові, вік, вага через пробіл). Вивести на екран спочатку інформацію про людей
молодше 40 років, а потім інформацію про всіх інших. (З використанням черги)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    Console.WriteLine("Чтение из файла");
                    String input;
                    Queue more = new Queue();
                    Queue less = new Queue();
                    while ((input = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                        string firstName;
                        string lastName;
                        string middleName;
                        uint age;
                        double weight;
                        String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if(words.Length != 5)
                        {
                            Console.WriteLine(input + " неверная строчка");
                            continue;
                        }
                        if(!UInt32.TryParse(words[3],out age) || !Double.TryParse(words[4], out weight)|| weight <= 0)
                        {
                            Console.WriteLine(input + " неверные данных в строке");
                            continue;
                        }
                        firstName = words[0];
                        lastName = words[1];
                        middleName = words[2];
                        if(age < 40)
                        {
                            less.Enqueue(new Person(firstName, lastName, middleName, age, weight));
                        }
                        else
                        {
                            more.Enqueue(new Person(firstName, lastName, middleName, age, weight));
                        }
                    }
                    while (more.Count != 0)
                        less.Enqueue(more.Dequeue());
                    Console.WriteLine("\nСписок людей(вначале младше 40)");
                    foreach (var item in less)
                    {
                        Console.WriteLine(item);
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
