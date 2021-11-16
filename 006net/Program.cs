using System;

namespace _006net
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Persona persona= new Persona("pepe",-100);
            Persona persona2= new Persona("pepe",-100);
            Persona persona3= new Persona("pepe",-100);
            Console.WriteLine(Persona.Contador);
            //Console.WriteLine(persona.Edad);
        
            Nota nota= new Nota(5);
            nota.Subir();
            nota.Subir();
            nota.Subir();
            Console.WriteLine(nota.Valor);
            nota.Subir();
            nota.Subir();
            nota.Subir();
              Console.WriteLine(nota.Valor);
            */

            Nota n1= new Nota(5);
            Nota n2= new Nota(7);
            // usar un metodo que pertenece al objeto
            Console.WriteLine(n1.esMayor(n2));
            Console.WriteLine(Nota.esMayor(n1,n2));
        }
    }
}
