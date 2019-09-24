using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerciOrnek
{
    public class Siparis
    {
        public Siparis()
        {
            Ekstralar = new List<EkstraMalzeme>();
        }
        public Hamburger SeciliHamburger { get; set; }
        public int Adet { get; set; }
        public List<EkstraMalzeme> Ekstralar { get; set; }
        public Boyut Boyut { get; set; }
        public decimal ToplamTutar { get; set; }

        public void TutarHesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliHamburger.Fiyati;
            switch (Boyut)
            {
                case Boyut.Kucuk:
                    break;
                case Boyut.Orta:
                    ToplamTutar += 2;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += 4;
                    break;
            }

            foreach (EkstraMalzeme item in Ekstralar)
            {
                ToplamTutar += item.Fiyati;
            }

            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            string Malzemeler = "";
            foreach (var item in Ekstralar)
            {
                Malzemeler = String.Concat(Malzemeler, "," + item.Adi);
            }
            string result = SeciliHamburger.Adi + " (" + Malzemeler + ")"+"*"+Adet.ToString();

            return result;
        }
    }
}
