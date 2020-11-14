using System;
using System.Text;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 *
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */

namespace Task3
{
    class Program
    {
        // TODO: самостоятельно выделите и напишите методы, использующиеся для решения задачи

        static void Main(string[] args)
        {
            const double x = 1;
            Console.OutputEncoding = Encoding.UTF8;

            // Parsing a,b,c.
            if (!double.TryParse(Console.ReadLine(), out var a) || !double.TryParse(Console.ReadLine(), out var b) ||
                !double.TryParse(Console.ReadLine(), out var c))
            {
                Console.WriteLine("Ошибка");
                return;
            }

            FindingResult(a, b, c, x);
        }

        private static void FindingResult(double a, double b, double c, double x)
        {
            double res;
            while (x < 1.2)
            {
                res = a * Math.Pow(x, 2) + b * x + c;
                Console.WriteLine(PrintingResult($"{res:f3}"));
                x += 0.05;
            }

            res = a / x + Math.Sqrt(Math.Pow(x, 2) + 1);
            Console.WriteLine(PrintingResult($"{res:f3}"));
            x += 0.05;
            while (x < 2.05)
            {
                res = (a + b * x) / Math.Sqrt(Math.Pow(x, 2) + 1);
                Console.WriteLine(PrintingResult($"{res:f3}"));
                x += 0.05;
            }
        }

        private static string PrintingResult(string res)
        {
            int i = res.Length - 1;

            if (res[i] == '.' && i > 0)
            {
                res = res.Substring(0, i);
            }

           // nice crutch, I think.
            while (res[i] == '0' && i > 0)
            {
                res = res.Substring(0, i--);
            }

            return res;
        }
    }
}