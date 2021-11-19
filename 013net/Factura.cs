namespace _013net
{
    public class Factura {

        public int Numero {get;set;}
        public string Concepto {get;set;}

        public int importe {get;set;}

        public Factura(int Numero ,string Concepto, int Importe) {


            this.Numero=Numero;
            this.Concepto=Concepto;
            this.importe=Importe;
        }
    }
    

}