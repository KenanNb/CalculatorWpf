using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorC
{
    class Program
    {
        static double AddNumber(double num1,double num2,ref double sum)
        {
           return  sum = num1 + num2;
        }
        static double SubtractionNumber(double num1, double num2, ref double sum)
        {
            return sum = num1 - num2;
        }
        static double MultNumber(double num1, double num2, ref double sum)
        {
            return sum = num1 * num2;
        }
        static double DivideNumber(double num1, double num2, ref double sum)
        {
            return sum = num1 / num2;
        }
        static void Main(string[] args)
        {
            do
            {
             Random ranndom = new Random();
             double num1 = (ranndom.Next(1, 1000));
             double num2 = (ranndom.Next(1, 1000));
             double sum = 0;
             int op = (ranndom.Next(1, 4));

                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine($"{num1} + {num2} = ");
                            double answer = double.Parse(Console.ReadLine());
                            Console.WriteLine(AddNumber(num1, num2, ref sum));
                            if (sum == answer)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(answer);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answer);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"{num1} - {num2}");
                            double answer = double.Parse(Console.ReadLine());
                            Console.WriteLine(SubtractionNumber(num1, num2, ref sum));
                            if (sum == answer)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(answer);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answer);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"{num1} * {num2}");
                            double answer = double.Parse(Console.ReadLine());
                            Console.WriteLine(MultNumber(num1, num2, ref sum));
                            if (sum == answer)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(answer);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answer);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"{num1} / {num2}");
                            double answer = double.Parse(Console.ReadLine());
                            Console.WriteLine(DivideNumber(num1, num2, ref sum));
                            if (sum == answer)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(answer);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answer);
                            }
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
