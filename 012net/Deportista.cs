using System;

namespace _012net
{

    public class Deportista : Persona
    {
        public Deportista(string nombre):base(nombre) {

        }

        public override void Andar()
        {
            Console.WriteLine("el deportista anda rapido");
        }
        public void Correr() {

         Console.WriteLine("el deportista corre");   
        }
    }
}