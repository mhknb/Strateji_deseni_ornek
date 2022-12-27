using System;
using System.Collections.Generic;
using System.Text;

namespace Strateji2
{
    abstract class Duzen
    {
        
        protected string tasarimSekli = "standart tasarim"; 
        public abstract double fiyatHesaplama(double fiyat);
        public abstract void tasarimSec();

        public void goruntule()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\n Tasarim = " + tasarimSekli);
        }
    }
}
