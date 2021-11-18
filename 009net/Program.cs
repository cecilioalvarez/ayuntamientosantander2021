using System;
using System.Collections.Generic;
namespace _009net
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("hola");
            lista.Add("que");
            lista.Add("tal");
            lista.Add("estas");

            for (int i = 0; i < lista.Count; i++)
            {

                Console.WriteLine(lista[i]);
            }
            lista.Remove("hola");
            Console.WriteLine("***************");
            for (int i = 0; i < lista.Count; i++)
            {

                Console.WriteLine(lista[i]);
            }
        }
    }
}
