using System;

namespace _001net
{
    class Program
    {
        static void Main(string[] args)
        {

            hola();
            Console.WriteLine("adios");
            hola();
             Console.WriteLine(duplicar(3));

        }

        static void hola()
        {
            Console.WriteLine("hola");
            Console.WriteLine("hola");
           

        }

        static double duplicar(double numero) {

            return numero*2;
        }
    }
}
