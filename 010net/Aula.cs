using System.Collections.Generic;
namespace _010net
{
    public class Aula
    {
        public int Numero { get; set; }
        public List<Alumno> Alumnos { get; set; }

        public Aula(int Numero)
        {
            this.Numero = Numero;
            this.Alumnos = new List<Alumno>();
        }

        public void AddAlumno(Alumno alumno)
        {
            this.Alumnos.Add(alumno);
        }

        public Alumno AlumnoMayor()
        {


            Alumno elegido = Alumnos[0];

            for (int i = 0; i < Alumnos.Count; i++)
            {

                if (elegido.Edad <Alumnos[i].Edad)
                {

                    elegido = Alumnos[i];
                }
            }
            return elegido;


        }

        public double EdadMedia() {

            double total=0;

             for (int i = 0; i < Alumnos.Count; i++)
            {

                total=total+Alumnos[i].Edad;
            }
            return total/Alumnos.Count;
        }


    }
}