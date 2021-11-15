using System;

namespace _003net
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Telefono t1= new Telefono();
            t1.marca="samsung";
            t1.numero=666898765;
            Console.WriteLine(t1.marca);
            Console.WriteLine(t1.numero);
            t1.llamar();
            

            // crea un objeto persona
            Persona p1 = new Persona();
            //inicializa las propiedades
            p1.nombre = "pedro";
            p1.edad = 20;
            //imprime as propiedades
            Console.WriteLine(p1.nombre);
            Console.WriteLine(p1.edad);
            //invoca a la funcionalidad
            p1.andar();

            Bombilla bombilla = new Bombilla();
            bombilla.Potencia = 50;
            bombilla.Encendida = true;
            Console.WriteLine(bombilla.Potencia);
            Console.WriteLine(bombilla.Encendida);

           
            Bombilla b1=new Bombilla();
            b1.Potencia=20;
          


            Bombilla b2=new Bombilla();
            b2.Potencia=30;
           

             Bombilla b3=new Bombilla();
            b3.Potencia=60;
           
            

             Bombilla[] lista= new Bombilla[]{b1,b2,b3};

            for (int i=0;i<lista.Length;i++) {

              Console.WriteLine(lista[i].Potencia);
            }

            */

            Persona p1= new Persona("pedro",20);
            Persona p1= new Persona("juan",30);

            Console.WriteLine(p1.nombre);
            Console.WriteLine(p1.edad);
            
            

        }
    }
}
