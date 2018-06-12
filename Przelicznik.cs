using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kalkulatorKcal
    {
        class Przelicznik
        {
            private string rodzaj;
            private int ilosc;
            public int Ilosc
            {
                get
                {
                    return ilosc;
                }

                set
                {
                    ilosc = value;
                }
            }
            private int kalorycznosc;

            public void UstawRodzaj(string rodzaj)
            {
                this.rodzaj = rodzaj;
            }

            public string ZwrocRodzaj()
            {   
                  return rodzaj;
            }

            public void UstawKalorycznosc(int kalorycznosc)
            {
                this.kalorycznosc = kalorycznosc;
            }

            public int ZwrocKalorycznosc()
            {
                return kalorycznosc;
            }

            public int Oblicz()
            {
                int wynik;
                wynik = (kalorycznosc * ilosc) / 100;
            return wynik;
            }
        }

    }

