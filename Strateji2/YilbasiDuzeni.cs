using System;
using System.Collections.Generic;
using System.Text;

namespace Strateji2
{
    class YilbasiDuzeni : Duzen
    {
        public override double fiyatHesaplama(double fiyat)
        {
            return fiyat * 0.80; // Hafta sonu %20 indirim
        }

        public override void tasarimSec()
        {
            tasarimSekli = "Yılbaşı tasarımı";
        }
    }
}
