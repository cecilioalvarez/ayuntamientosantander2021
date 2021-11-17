using System;

namespace _007net
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Futbolista f1= new Futbolista("pepe","madrid",2);
            Futbolista f2= new Futbolista("juan","bacelona",3);
            Console.WriteLine(f1.Nombre);
            Console.WriteLine(f1.Equipo);
            f1.Lanzar();
            Console.WriteLine(Futbolista.Contador);
            */

            Coche coche= new Coche("1234ABC","seat");
            Console.WriteLine(coche.Velocidad);
            coche.Acelerar();
            Console.WriteLine(coche.Velocidad);
            
        }
    }
}
