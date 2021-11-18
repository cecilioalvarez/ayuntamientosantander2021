using System;

namespace _008net
{
    class Program
    {
        static void Main(string[] args)
        {
           Monitor m1= new Monitor("samsung",30);
           Ordenador o= new Ordenador("dell",1000,m1);
           Console.WriteLine(o.Marca);
           Console.WriteLine(o.MonitorA.Marca);
           Monitor m2= new Monitor("lg",24);
           o.MonitorA=m2;
           Console.WriteLine(o.Marca);
           Console.WriteLine(o.MonitorA.Marca);
           
        }
    }
}
