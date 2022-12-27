using System;

namespace Strateji2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context icerik = new Context();

            Duzen dzn = new Standart();
            icerik.setDuzen(dzn);
            icerik.tasarimiGoster();
            icerik.fiyatGoster(100);

            dzn = new HaftaSonu();
            icerik.setDuzen(dzn);
            icerik.tasarimiGoster();
            icerik.fiyatGoster(100);


            dzn = new YilbasiDuzeni();
            icerik.setDuzen(dzn);
            icerik.tasarimiGoster();
            icerik.fiyatGoster(100);

        }
    }
}
