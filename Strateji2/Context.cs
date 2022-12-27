using System;
using System.Collections.Generic;
using System.Text;

namespace Strateji2
{
    class Context
    {
        Duzen duzen;

        public void setDuzen(Duzen d)
        {
            duzen = d;
        }

        public void tasarimiGoster()
        {
            duzen.tasarimSec();
            duzen.goruntule();
        }

        public void fiyatGoster(double f)
        {
            double guncelFiyat = duzen.fiyatHesaplama(f);
            Console.WriteLine("\n Normal fiyati = " + f + " olan urun, su anda " +guncelFiyat+ " TL'dir ");
        }


    }
}
