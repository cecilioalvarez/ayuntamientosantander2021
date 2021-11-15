using System;

namespace _002net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double  numero1= Convert.ToDouble(Console.ReadLine());
            double  numero2= Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(sumar(numero1, numero2));
            Console.WriteLine(restar(numero1, numero2));
            Console.WriteLine(multiplicacion(numero1, numero2));
            Console.WriteLine(division(numero1, numero2))
            ;
        }

        static double sumar(double n1, double n2)
        {
            return n1 + n2;
        }
        static double restar(double n1, double n2)
        {
            return n1 - n2;
        }
        static double multiplicacion(double n1, double n2)
        {
            return n1 * n2;
        }
        static double division(double n1, double n2)
        {
            return n1 / n2;
        }

    }
}
