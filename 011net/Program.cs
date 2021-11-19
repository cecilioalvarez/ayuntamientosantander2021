using System;

namespace _011net
{
    class Program
    {
        static void Main(string[] args)
        {
            Azulejo a1= new Azulejo(2,2);
            Azulejo a2= new Azulejo(2,2);
            Suelo suelo= new Suelo();
            suelo.AddAzulejo(a1);
            suelo.AddAzulejo(a2);

            Console.WriteLine(suelo.AreaTotal());

            
        }
    }
}
