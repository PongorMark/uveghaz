using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
    internal class NovenyKezelo
    {
        List<NovenyFaj> novenyFajok;
        UveghazRacs racs;

        public NovenyKezelo(UveghazRacs racs)
        {
            this.racs = racs;
            this.novenyFajok = new List<NovenyFaj>();
        }

        public List<NovenyFaj> NovenyFajok { get => novenyFajok; set => novenyFajok = value; }

        public void NovenyFajHozzaad(NovenyFaj faj)
        {
            novenyFajok.Add(faj);
            Console.WriteLine($"{faj.Nev} hozzáadva a rendszerhez.");
        }

        public void Telepit(string fajAzonosito, int x, int y, int mennyiseg)
        {
            NovenyFaj faj = novenyFajok.Find(f => f.Azonosito == fajAzonosito);

            if (faj != null)
            {
                racs.Telepit(x, y, faj, mennyiseg);
            }
            else
            {
                Console.WriteLine("Nincs ilyen növényfaj.");
            }
        }
    }
}
