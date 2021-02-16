using System;
using System.Globalization;
namespace Uri1118
{
    class Program
    {
            static void Main(string[] args)
            {
                int x;

                x = 0;

                double a, b, media;





                while (x != 2)
                {
                    x = 0;
                    a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    while (a < 0 || a > 10)
                    {
                        Console.WriteLine("Nota inválida");

                        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    }

                    b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    while (b < 0 || b > 10)
                    {
                        Console.WriteLine("Nota inválida");

                        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    }

                    media = (a + b) / 2.0;

                    Console.WriteLine("Média = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                    while (x < 1 || x > 2)
                    {
                        Console.Write("Novo cálculo (1-sim 2-não)");
                        x = int.Parse(Console.ReadLine());
                    }
                    a = 0;
                    b = 0;
                }
            }
        }
    }


