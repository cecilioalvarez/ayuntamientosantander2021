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
            */

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

            Bombilla[] lista= new Bombilla[3];
            Bombilla b1=new Bombilla();
            b1.Potencia=20;
            lista[0]=b1;


            Bombilla b2=new Bombilla();
            b2.Potencia=30;
            lista[1]=b2;

             Bombilla b3=new Bombilla();
            b3.Potencia=60;
            lista[2]=b3;
            

            for (int i=0;i<lista.Length;i++) {

              Console.WriteLine(lista[i].Potencia);
            }

        }
    }
}
