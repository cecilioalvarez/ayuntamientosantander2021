using System;

namespace _012net
{
    class Program
    {
        static void Main(string[] args)
        {
          Deportista d1= new Deportista("juan");
          Console.WriteLine(d1.Nombre);
          d1.Andar();
          d1.Correr();
        }
    }
}
