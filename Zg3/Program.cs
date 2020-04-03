/*3. У текстовому файлі записана інформація про людей (прізвище, ім'я, по
батькові, вік, вага через пробіл). Вивести на екран інформацію про людей, відсортовану
за віком. (ArrayList перевантаження методу Compare).*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zg3
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
                    ArrayList arrayList = new ArrayList();
                    while ((input = sr.ReadLine()) != null)
                    {
                        string firstName;
                        string lastName;
                        string middleName;
                        uint age;
                        double weight;
                        String[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length != 5)
                        {
                            Console.WriteLine(input + " неверная строчка");
                            continue;
                        }
                        if (!UInt32.TryParse(words[3], out age) || !Double.TryParse(words[4], out weight) || weight <= 0)
                        {
                            Console.WriteLine(input + " неверные данных в строке");
                            continue;
                        }
                        firstName = words[0];
                        lastName = words[1];
                        middleName = words[2];
                        arrayList.Add(new Person(firstName, lastName, middleName, age, weight));
                    }
                    Console.WriteLine("Входные данные:");
                    foreach (var item in arrayList)
                    {
                        Console.WriteLine(item);
                    }
                    arrayList.Sort(new PersonComparer());
                    Console.WriteLine("\nПосле сортировки по возрасту:");
                    foreach (var item in arrayList)
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
