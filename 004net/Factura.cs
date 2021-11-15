namespace _004net
{

    public class Factura {

        public int numero;
        public string concepto;
        public double importe;

        public Factura(int numero,string concepto, double importe) {
                // el operador this es un operador de ambito
                // que lo que hace es decirnos que la 
                // variale numero hace referencia a la de la clase
                this.numero=numero;
                this.concepto= concepto;
                this.importe=importe;
        }


        public double importeConIVA() {
            return this.importe*1.21;
        }
    }
}