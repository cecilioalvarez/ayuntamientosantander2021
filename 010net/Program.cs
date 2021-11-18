using System;

namespace _010net
{
    class Program
    {
        static void Main(string[] args)
        {
           Aula a = new Aula(1);
           a.Alumnos.Add(new Alumno("pedro"));
           a.Alumnos.Add(new Alumno("juan"));
           a.Alumnos.Add(new Alumno("antonio"));
           a.Alumnos.Add(new Alumno("maria"));
           
           for (int i=0;i<a.Alumnos.Count;i++) {

               Console.WriteLine(a.Alumnos[i].Nombre);
           }
        }
    }
}
