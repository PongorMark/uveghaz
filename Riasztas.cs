using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class Riasztas
    {
        static int szamlalo = 1;

        int azonosito;
        string tipus;
        string leiras;
        int sulyossag;
        Cella cella;

        public Riasztas(string tipus, string leiras, int sulyossag, Cella cella)
        {
            this.azonosito = szamlalo++;
            this.tipus = tipus;
            this.leiras = leiras;
            this.sulyossag = sulyossag;
            this.cella = cella;
        }

        public int Azonosito { get => azonosito; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Sulyossag { get => sulyossag; set => sulyossag = value; }
        internal Cella Cella { get => cella; set => cella = value; }

        public override string ToString()
        {
            return $"Riasztás #{azonosito} - {tipus} ({sulyossag})";
        }
    }
}
