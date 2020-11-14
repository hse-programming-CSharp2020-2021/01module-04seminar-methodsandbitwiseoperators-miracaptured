using System;
using System.Text;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        // TODO: самостоятельно выделите и напишите методы, использующиеся для решения задачи

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            int m;
            if (!int.TryParse(Console.ReadLine(), out n) && n >= 0 || !int.TryParse(Console.ReadLine(), out m) && m >= 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            
            int res = Multiplying(m) + Multiplying(n);
            Console.WriteLine(m < 31 && n < 31 && res == ((long)Multiplying(m) + (long)Multiplying(n)) ? res.ToString() : "Переполнение");
        }
        
        static int Multiplying(int x)
        {
            return 2 << (x - 1);
        }

    }
}