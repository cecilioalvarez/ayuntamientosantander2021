namespace _005net
{
    public class Mesa
    {
        public int Peso;
        public string Madera;
        public string Color;
        public Mesa(int Peso,string Madera,string Color){
            this.Peso=Peso;
            this.Madera=Madera;
            this.Color=Color;
        }
         public Mesa(string Madera){
            this.Peso=10;
            this.Madera=Madera;
            this.Color="blanco";
            
        }

         public Mesa(string Madera,string Color){
            this.Peso=10;
            this.Madera=Madera;
            this.Color=Color;
            
        }

    }

}