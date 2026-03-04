using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class Szenzor
    {
        string azonosito;
        string tipus;
        Cella cella;
        List<int> meresek;

        public Szenzor(string azonosito, string tipus, Cella cella)
        {
            this.azonosito = azonosito;
            this.tipus = tipus;
            this.cella = cella;
            this.meresek = new List<int>();
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        internal Cella Cella { get => cella; set => cella = value; }
        public List<int> Meresek { get => meresek; set => meresek = value; }

        public void MeresHozzaad(int ertek)
        {
            meresek.Add(ertek);
            Console.WriteLine($"Szenzor ({tipus}) új mérés: {ertek}");
        }

        public int UtolsoMeres()
        {
            if (meresek.Count == 0)
                return 0;

            return meresek[meresek.Count - 1];
        }
    }
}
