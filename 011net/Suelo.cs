using System.Collections.Generic;
namespace _011net
{

    public class Suelo
    {

        public List<Azulejo> azulejos { get; set; }

        public Suelo()
        {
            azulejos = new List<Azulejo>();
        }
        public Suelo(List<Azulejo> lista)
        {
            azulejos = lista;
        }

        public void AddAzulejo(Azulejo a)
        {
            azulejos.Add(a);
        }

        public int AreaTotal() {
            int total=0;
            for (int i=0;i<azulejos.Count;i++) {

                total=total+ azulejos[i].Area();


            }
            return total;
        }
    }
}