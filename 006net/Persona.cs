namespace _006net
{

public class Persona {

    public string Nombre;
    private int edad;

    public int Edad {

        get {
            return this.edad;
        }
        set {
            // cuando voy a asignar el valor 
            // limito las posibilidades
            if (value>0 && value<120 )
                this.edad=value;
        }
    }

    public Persona (string Nombre, int Edad) {

        this.Nombre=Nombre;
        this.Edad=Edad;
    }
}

}