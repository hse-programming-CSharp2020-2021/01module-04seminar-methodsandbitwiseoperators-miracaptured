using System;
using System.Globalization;
using System.Text;
using System.Threading;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static bool ReadBoundaries(out uint p, out uint q)
        {
            bool isInputCorrect = uint.TryParse(Console.ReadLine(), out q);
            isInputCorrect &= uint.TryParse(Console.ReadLine(), out p);
            if (isInputCorrect && q <= p)
            {
                return true;
            }
            return false;        }

        static void PrintPythagorasNumbers(uint min, uint max)
        {
            for (uint a = min; a <= max; ++a)
            {
                for (uint b = a + 1; b <= max; ++b)
                {
                    for (uint c = b + 1; c <= max; ++c)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            if (!ReadBoundaries(out uint q, out uint p) || q == 0 || p == 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            PrintPythagorasNumbers(q, p);
        }
    }
}
