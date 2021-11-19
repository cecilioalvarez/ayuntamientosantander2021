using System;
using System.IO;
namespace _013net
{
    class Program
    {
        static void Main(string[] args)
        {
        string fichero = @"facturas.txt";
 
        string[] lineas = File.ReadAllLines(fichero);

        for (int i=0;i<lineas.Length;i++) {

            string[] propiedad=lineas[i].Split(",");
            /*
            for (int j=0;j<propiedad.Length;j++) {

                Console.WriteLine(propiedad[j]);
            }*/
            int numero= Convert.ToInt32(propiedad[0]);
            string concepto=propiedad[1];
            Factura factura= new Factura();
        }
        }
    }
}
