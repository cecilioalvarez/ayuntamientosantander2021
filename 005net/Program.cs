﻿using System;

namespace _005net
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo= new Rectangulo(2,3);
            Console.WriteLine(rectangulo.Area());
            Console.WriteLine(rectangulo.Perimetro());
            Documento documento= new Documento("hola soy un doc",1);
            documento.Imprimir();
            documento.Imprimir(2);
            documento.Imprimir(2,4);
            Mesa mesa= new Mesa("pino","blanco");
            Mesa mesa2= new Mesa(10,"abedul","marron");
        }
    }
}
