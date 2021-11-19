using System;

namespace _012net
{
    public class Persona
    {

        public string Nombre {get;set;}
        public Persona(string Nombre)
        {
            this.Nombre=Nombre;

        }

        public virtual void Andar(){
            
            Console.WriteLine("la persona anda despacio");
        }

    }
}
