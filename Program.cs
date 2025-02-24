using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(4.5); // заносим инт
            list.Add(18); // заносим дабл
            list.AddRange(new string[] { "Студент", "Петров" }); // заносим строковый массив
            // перебор значений
            foreach (object e in list)
            {
                Console.WriteLine(e);
            }
            list.RemoveAt(0); // удаляем первый эл-нт
            list.Reverse(); // переворачиваем список
            Console.WriteLine(list[1]); // получаем первый эл-нт
            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            ArrayList list1 = new ArrayList();
            list1.Add("lol"); // заногсим стринг
            list1.Add(123); // заносим инт
            list1.AddRange(new string[] { "gitHub", "WW" }); // заносим строковый массив
            try
            {
                Console.WriteLine("C какой позиции вставить новую коллекцию?");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && n < list.Count) // проверка н
                {
                    list.InsertRange(n, list1); // вставляем новую коллекцию с заданной ппозиции
                    // перебор списка
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                    Console.WriteLine("Сколько эл-ов хотите удалить?");
                    int k = Convert.ToInt32(Console.ReadLine());
                    if (k > 0 && k < list.Count)
                    {
                        n = n / 2;
                        list.RemoveRange(n, k); // удаляем заданное кол-во эл-ов с заданной позиции
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверное значение");
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод!");
            }
            Console.ReadKey();
        }
    }
}
