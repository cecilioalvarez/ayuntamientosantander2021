namespace _006net
{
public class Nota {

    private double valor;

    public double Valor {

        get {
            return valor;
        }
        set {
            if (value>=0 && value<=10) {
                this.valor= value;
            }
        }
    }
    public Nota(double valorinicial) {

        this.Valor=valorinicial;
    }

    public void Subir() {

        this.Valor++;
    }

    public void Bajar() {

        this.Valor--;
    }

    public bool esMayor(Nota otra) {

        if (this.Valor>otra.Valor) {
            return true;
        }else {
            return false;
        }
    }

     public static bool esMayor(Nota nota1,Nota nota2) {

        if (nota1.Valor>nota2.Valor) {
            return true;
        }else {
            return false;
        }
    }
}

}