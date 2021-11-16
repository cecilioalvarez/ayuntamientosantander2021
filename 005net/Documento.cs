using System;
namespace _005net
{

        public class Documento {

            public string Texto;
            public int Version;

            public Documento(string Texto,int Version) {

                this.Texto=Texto;
                this.Version=Version;
            }
            public  void Imprimir() {
                Console.WriteLine(this.Texto);
            }
            //sobrecarga estatica o overload
            public void Imprimir(int Pagina) {

                Console.WriteLine(this.Texto + " estamos en la pagina "+ Pagina);
            }

            public void Imprimir(int PaginaInicio,int PaginaFin) {

                Console.WriteLine(this.Texto + " desde la pagina "+ PaginaInicio +" hasta" + PaginaFin);
            }
        }
}