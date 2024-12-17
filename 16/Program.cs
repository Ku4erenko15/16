using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        // Дополнительный метод для вывода ArrayList с использованием foreach
        static void Print(ArrayList arrayList)
        {
            Console.WriteLine("Содержимое списка:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            // 1. Добавить в коллекцию элементы разных типов
            ArrayList List = new ArrayList
        {
            10,              // положительное целое
            "Hello",         // строковое
            true,            // логическое
            3.14,            // положительное вещественное
            -5,              // отрицательное целое
            -2.71            // отрицательное вещественное
        };

            // 2. Вывести список
            Print(List);

            // 3. Определить количество элементов списка
            Console.WriteLine($"\nКоличество элементов в списке: {List.Count}");

            // 4. Вставить второй элемент со значением строковой величины
            List.Insert(1, "Second Element");

            // 5. Просмотреть список
            Console.WriteLine("\nСписок после вставки второго элемента:");
            Print(List);

            // 6. Удалить любое положительное число (первое встреченное)
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] is int && (int)List[i] > 0)
                {
                    List.RemoveAt(i);
                    break;
                }
            }

            // 7. Просмотреть список
            Console.WriteLine("\nСписок после удаления положительного числа:");
            Print(List);

            // 8. Сделать реверс списка и просмотреть его
            List.Reverse();
            Console.WriteLine("\nСписок после реверса:");
            Print(List);

            // 9. Занести в список строковый массив из трех элементов
            string[] stringArray = { "One", "Two", "Three" };
            List.AddRange(stringArray);

            // 10. Просмотреть список с помощью дополнительного метода foreach
            Console.WriteLine("\nСписок после добавления строкового массива:");
            Print(List);
            Console.ReadKey();
        }
    }

}

