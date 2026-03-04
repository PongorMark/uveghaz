using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class ElemzoMotor
    {
        public void CellaErtekeles(Cella cella)
        {
            if (cella.UresCella)
                return;

            if (cella.EgyedSzam > cella.Noveny.OptimalisSuruseg)
            {
                Riasztas r = new Riasztas(
                    "Túlzsúfoltság",
                    "A növények túl sűrűn vannak ültetve.",
                    2,
                    cella
                );

                cella.Riasztasok.Add(r);
                Console.WriteLine("Riasztás generálva: túlzsúfoltság");
            }
        }

        public void SzomszedKockazat(UveghazRacs racs, int x, int y)
        {
            Cella cella = racs.CellaLekerdezes(x, y);

            if (cella.UresCella)
                return;

            if (cella.Noveny.EgeszsegiAllapot < 5)
            {
                Console.WriteLine("Szomszédos kockázat: fertőzésveszély!");
            }
        }
    }
}