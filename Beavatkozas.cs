using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class Beavatkozas
    {
        string tipus;
        DateTime datum;
        Cella celCella;
        string megjegyzes;

        public Beavatkozas(string tipus, Cella celCella, string megjegyzes)
        {
            this.tipus = tipus;
            this.datum = DateTime.Now;
            this.celCella = celCella;
            this.megjegyzes = megjegyzes;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        internal Cella CelCella { get => celCella; set => celCella = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }

        public void Vegrehajt()
        {
            Console.WriteLine($"Beavatkozás: {tipus} a {celCella.Poz} cellán.");
        }
    }
}
