/*У набір ArrayList помістити випадкові значення типу Int в діапазоні і кількості
відповідно до варіанта (див. Табл. 1) за допомогою методу add.
 Відсортувати набір в порядку зростання.
 Вивести всі елементи набору за допомогою циклу foreach.
 Значення номера варіанту занести в набір на позицію, що дорівнює номеру

Москаленко А.С.
варіанта.
 Згенерувати нове значення в межах від 0 до номера варіанту +1000 і
перевірити чи існує таке значення в наборі, якщо існує визначити його індекс.
 Видалити елемент набору рівний випадковому значенню, згенерованого в
межах від 0 до максимального індексу набору.
 Видалити всі елементи набору.
11 1990 200..400
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Zd5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            if(n < 12)
            {
                n = 12;
            }
            Random random = new Random();
            ArrayList array = new ArrayList();
            Console.WriteLine("Входной массив");
            for (int i = 0; i < n; i++)
            {
                array.Add(random.Next(200, 401));
                Console.Write(array[i] + " ");
            }
            array.Sort();
            Console.WriteLine("\n\nМассив после сортировки");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            array.Insert(11, 11);
            Console.WriteLine("\n\nВставка елемента на номер врианта. 11 елемент:" + array[11]);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            int temp = random.Next(0, 1011);
            Console.WriteLine("\n\nСгенерированное число = " + temp);
            if (array.Contains(temp))
            {
                Console.WriteLine("Его индекс в массиве:" + array.IndexOf(temp));
            }
            else
            {
                Console.WriteLine("Даного числа нет в массиве");
            }
            temp = random.Next(0, array.Count);
            Console.WriteLine("\nИндекс для удаления = " + temp);
            Console.WriteLine("Удаленное число:" + array[temp]);
            array.RemoveAt(temp);
            array.Clear();
            Console.WriteLine("\nМассив очищен. Его размер:" + array.Count);
            Console.ReadKey();
        }
    }
}
