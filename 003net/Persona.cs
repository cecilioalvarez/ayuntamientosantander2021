using System;

namespace _003net
{
    public class Persona
    {


        public string nombre;
        public int edad;

        public Persona (string nombre,int edad) {
            this.nombre=nombre;
            this.edad=edad;
        }

        public void andar()
        {

            Console.WriteLine("la persona anda");
        }
    }
}