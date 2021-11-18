using System;

namespace _010net
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula a = new Aula(1);
            a.AddAlumno(new Alumno("pedro", 20));
            a.AddAlumno(new Alumno("juan", 80));
            a.AddAlumno(new Alumno("antonio", 10));
            a.AddAlumno(new Alumno("maria", 15));
           
           

            Console.WriteLine(a.AlumnoMayor().Nombre);
            Console.WriteLine(a.AlumnoMayor().Edad);
            
           
           


        }
    }
}
