using System;

namespace _003net
{
public class Bombilla {
    
    public int numero;
    public int Potencia;
    public bool Encendida;

    public void Encender() {
        Encendida=true;
    }
    public void Apagar() {
        Encendida=false;
    }
}

}