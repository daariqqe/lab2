using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Завдання 1");
            Console.WriteLine("Введіть номер значення х, до прикладу 1 та натисніть Enter");
            double a = 1.8;
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            double pi = Math.PI;
            if (x <= 0)
            {
                Console.Write($"Відповідь: ");
                Console.WriteLine(0);
                Console.WriteLine();
            }
            else if (x >= 0 && x <= 1)
            {
                y = (Math.Pow(x, 2) - (x / a));
                Console.WriteLine($"Відповідь: {Math.Round(y,2)}");
                Console.WriteLine();
            }
            else
            {
                y = Math.Pow(x, 3) - (Math.Sin(pi * (Math.Pow(x, 2)) - 1));
                Console.WriteLine($"Відповідь: {Math.Round(y,2)}");
                Console.WriteLine();
            }
            Console.ReadLine();

            //task 2 
            Console.WriteLine("Завдання 2");
            Console.WriteLine("Введіть час вашого перебування на ковзанці," +
            " до прикладу 90 ( хвилин ) та натисніть Enter ");
            double time = Convert.ToDouble(Console.ReadLine());
            double time1 = time / 60;
            Random random = new Random();
            int price = random.Next(200, 400);
            double fin_price;
            Console.WriteLine();
            Console.WriteLine($"Вартість за годину: {price}");
            Console.WriteLine("Введіть тип картки, до прикладу 1");
            Console.WriteLine("1) VIP-картка -> -20% знижки від базової вартості");
            Console.WriteLine("2) Premium-картка -> -10% знижки від базової вартості");
            Console.WriteLine("3) Base-картка -> базова вартість ");
            int card = Convert.ToInt32(Console.ReadLine());
            if (card == 1)

            {
                //обрахування знижки та виведення кінцевої вартості 
                fin_price = ((time1 * price) / 100) * 80;
                Console.WriteLine();
                Console.WriteLine($"Кінцева вартість: {Math.Round(fin_price,0)} грн");
            }
            else if (card == 2)
            {
                //обрахування знижки та виведення кінцевої вартості 
                fin_price = ((time1 * price) / 100) * 90;
                Console.WriteLine();
                Console.WriteLine($"Кінцева вартість: {Math.Round(fin_price, 0)} грн");
            }
            else if (card == 3) 
            {
                //обрахування знижки та виведення кінцевої вартості 
                fin_price = time1 * price;
                Console.WriteLine();
                Console.WriteLine($"Кінцева вартість: {Math.Round(fin_price, 0)} грн");

            }

            Console.ReadLine();

            //task 3
            Console.WriteLine("Завдання 3");
            Console.WriteLine("Введіть одиницю виміру довжини відрізка та натисніть Enter:");
            Console.WriteLine("1) - дециметр");
            Console.WriteLine("2) - кілометр");
            Console.WriteLine("3) - метр");
            Console.WriteLine("4) - міліметр");
            Console.WriteLine("5) - сантиметр");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть довжину відрізка та натисніть Enter");
            double length = Convert.ToDouble(Console.ReadLine());
            double answear;
            switch (var)
            {
                case 1:
                    {
                        answear = length * 0.1;
                        Console.WriteLine();
                        Console.WriteLine($"Довжина відрізка в метрах: {answear}");
                        break;
                    }
                case 2:
                    {
                        answear = length * 1000;
                        Console.WriteLine();
                        Console.WriteLine($"Довжина відрізка в метрах: {answear}");
                        break;
                    }
                case 3:
                    {
                        answear = length;
                        Console.WriteLine();
                        Console.WriteLine($"Довжина відрізка в метрах: {answear}");
                        break;
                    }
                case 4:
                    {
                        answear = length / 1000;
                        Console.WriteLine();
                        Console.WriteLine($"Довжина відрізка в метрах: {answear}");
                        break;
                    }
                case 5:
                    {
                        answear = length * 0.01;
                        Console.WriteLine();
                        Console.WriteLine($"Довжина відрізка в метрах: {answear}");
                        break;
                    }
            }

                        Console.ReadLine();
        }
    }
}
