using System;

namespace _007net
{

public class Coche {

    public string Matricula  {get;set;}
    public string Marca {get;set;}
    public int Velocidad { get; set; }
    
    public Coche(string Matricula, string Marca) 
    {
        this.Marca=Marca;
        this.Matricula=Matricula;
        this.Velocidad=10;
    }

    public void Acelerar() {
        Velocidad=Velocidad+10;
    }
    public void Reducir() {
        //this.Velocidad=this.Velocidad-10;
        Velocidad-=10;
    }
}

}