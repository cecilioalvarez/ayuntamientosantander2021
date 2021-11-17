using System;

namespace _007net
{
    public class Futbolista
    {

        public static int Contador { get; set; }
        
        
        public string Nombre { get; set; }
        public string Equipo { get; set; }

        public int Nivel { get; set; }

        public Futbolista(string Nombre, string Equipo, int Nivel)
        {
            // this es un operador de ambito
            // pepe=pepe;
            this.Nombre = Nombre;
            this.Equipo = Equipo;
            this.Nivel = Nivel;
            Contador=Contador+1;

        }
        

         public Futbolista(string Nombre, string Equipo)
        {
            // this es un operador de ambito
            this.Nombre = Nombre;
            this.Equipo = Equipo;
            this.Nivel = 1;
            Contador=Contador+1;


        }

        public void Lanzar() {
            Console.WriteLine("el futbolista lanza a 10 km/hora");
        }
        public void Lanzar(int velocidad) {
            Console.WriteLine("el futbolista lanza a " +velocidad +" km/hora");
        }

    }

}