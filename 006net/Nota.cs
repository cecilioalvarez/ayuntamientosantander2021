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
    public Nota(double valor) {

        this.Valor=valor;
    }

    public void Incrementar1() {

        this.Valor++;
    }

    public void Incrementar1() {

        this.Valor--;
    }
}

}