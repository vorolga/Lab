using System;
using static System.Math;
using System.Collections.Generic;
using System.Diagnostics;
 
namespace lab1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Воронова Ольга Александровна ИУ5-33Б");
            double[] coef = new double [3];
            if (args.Length == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    coef[i] = ReadCoef(i); 
                    while (coef[0] == 0) 
                    { 
                        Console.WriteLine("Введите число неравное нулю"); 
                        coef[i] = ReadCoef(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (!double.TryParse(args[i], out coef[i])) 
                    {
                        Console.WriteLine("Неправильные параметры командной строки");
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
 
            List<double> roots = Solve(coef);
            Console.Write("Ответ: ");
            WriteAnswer(roots);
        }
 
        static double ReadCoef(int pos)
        {
            string valueString;
            double valueDouble;
            bool flag;
 
            do
            {
                Console.Write("Введите коэффицент при x^" + (4 - 2 * pos) + ": ");
                valueString = Console.ReadLine();
                flag = double.TryParse(valueString, out valueDouble);
 
                if (!flag)
                {
                    Console.WriteLine("Введите вещественное число");
                }
            } while (!flag);
 
            return valueDouble;
        }
 
        static List<double> Solve(double[] coef)
        {
            List<double> roots = new List<double>();
            double D = coef[1] * coef[1] - 4 * coef[0] * coef[2];
            if (D < 0)
            {
                return roots;
            }
 
            if (D == 0)
            {
                double replacedVariable = - coef[1] / (2 * coef[0]);
                if (replacedVariable < 0)
                {
                    return roots;
                }
 
                if (replacedVariable == 0)
                {
                    roots.Add(0);
                    return roots;
                }
 
                roots.Add(Sqrt(replacedVariable));
                roots.Add(-Sqrt(replacedVariable));
                return roots;
            }
 
            double root1 = (- coef[1] + Sqrt(D)) / (2 * coef[0]);
            double root2 = (- coef[1] - Sqrt(D)) / (2 * coef[0]);
 
            if (root1 == 0)
            {
                roots.Add(0);
            }
            else if (root1 > 0)
            {
                roots.Add(Sqrt(root1));
                roots.Add(- Sqrt(root1));
            }
 
            if (root2 == 0)
            {
                roots.Add(0);
            }
            else if (root2 > 0)
            {
                roots.Add(Sqrt(root2));
                roots.Add(- Sqrt(root2));
            }
 
            return roots;
        }
 
        static void WriteAnswer(List<double> roots)
        {
            if (roots.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет корней");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var i in roots)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}