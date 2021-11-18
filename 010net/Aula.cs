using System.Collections.Generic;
namespace _010net
{
    public class Aula
    {
        public int Numero {get;set;}
        public List<Alumno> Alumnos {get;set;} 

        public Aula(int Numero)
        {
            this.Numero=Numero;
            this.Alumnos= new List<Alumno>();
        }

        


    }
}