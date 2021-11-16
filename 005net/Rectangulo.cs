namespace _005net
{

    public class Rectangulo
    {

        public int Lado1;
        public int Lado2;

        public Rectangulo(int Lado1, int Lado2)
        {

            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }

        public int Area() {
            return this.Lado1*this.Lado2;
        }
        public int Perimetro() {

            return this.Lado1*2+ this.Lado2*2;
        }
    }

}