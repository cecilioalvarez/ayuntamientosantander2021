namespace _006net
{

public class Persona {

    private string nombre;
    public static int Contador {get;set;}
    public Persona (string Nombre, int Edad) {

        this.Nombre=Nombre;
        this.Edad=Edad;
        Contador++;
    }



    public string Nombre {

        get { return  this.nombre;}
        set {nombre=value;}

    }
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

}

}