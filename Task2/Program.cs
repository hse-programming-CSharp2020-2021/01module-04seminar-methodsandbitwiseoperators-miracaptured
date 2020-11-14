using System;
using System.Text;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ReadData();
        }
        
        
        static void ReadData()
        {
            var sum = 0;
            string value = Console.ReadLine();
            int num = 0;
            while (sum >= -1000 && value != "q")
            {
                if (!int.TryParse(value, out var x) && value != "q")
                {
                    Console.WriteLine("Ошибка");
                    return;
                }

                if (x < 0)
                {
                    sum += x;
                    num++;
                }

                value = Console.ReadLine();
            }

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var average = (double) sum / num;
            Console.WriteLine(FindingResult($"{average:f2}"));
        }
        
        static string FindingResult(string result)
        {
            int i = result.Length - 1;
            while (result[i] == '0')
            {
                result = result.Substring(0, i);
                i = result.Length - 1;
            }

            if (result[i] == '.')
            {
                result = result.Substring(0, i);
            }

            return result;
        }
    }
}
