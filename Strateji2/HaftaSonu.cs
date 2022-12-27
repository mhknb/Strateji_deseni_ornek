using System;
using System.Collections.Generic;
using System.Text;

namespace Strateji2
{
    class HaftaSonu : Duzen
    {
        public override double fiyatHesaplama(double fiyat)
        {
            return fiyat * 0.95; // Hafta sonu %5 indirim
        }

        public override void tasarimSec()
        {
            tasarimSekli = "Hafta sonu tasarımı";
        }
    }
}
