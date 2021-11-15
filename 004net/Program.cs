using System;

namespace _004net
{
    class Program
    {
        static void Main(string[] args)
        {
           Factura f1= new Factura(1,"ordenador",500);
          
           Console.WriteLine(f1.importeConIVA());
        }
    }
}
