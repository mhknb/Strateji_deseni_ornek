using System;
using System.Collections.Generic;
using System.Text;

namespace Strateji2
{
    class Standart:Duzen
    {
        public override double fiyatHesaplama(double fiyat)
        {
            return fiyat ; // Standart duzen indirim yok
        }

        public override void tasarimSec()
        {
            tasarimSekli = "Standart tasarım";
        }
    }
}
