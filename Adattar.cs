using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class Adattar
    {
        List<Kezelo> kezelok;
        UveghazRacs racs;
        List<Szenzor> szenzorok;
        List<Riasztas> riasztasok;

        public Adattar(UveghazRacs racs)
        {
            this.racs = racs;
            this.kezelok = new List<Kezelo>();
            this.szenzorok = new List<Szenzor>();
            this.riasztasok = new List<Riasztas>();
        }

        public List<Kezelo> Kezelok { get => kezelok; set => kezelok = value; }
        public UveghazRacs Racs { get => racs; set => racs = value; }
        public List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
        public List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }

        public void KezeloHozzaad(Kezelo kezelo)
        {
            kezelok.Add(kezelo);
        }

        public void RiasztasHozzaad(Riasztas riasztas)
        {
            riasztasok.Add(riasztas);
        }

        public void SzenzorHozzaad(Szenzor szenzor)
        {
            szenzorok.Add(szenzor);
        }
    }
}
