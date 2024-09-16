using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vezbe3
{
    delegate void delegatTemperatura(int temp);
    /*
     * Menja se u random intervalima, tebamo da obavestimo metodu koja obavestava da se izvrsila promena
    */
    internal class Termometar
    {
        int t = 25;
        public event delegatTemperatura temperaturaJePromenjenaDogadjaj; // dodaje se event
        public void MeriTemperaturu()
        {
            Random r = new Random();
            while (true)
            {
                Thread.Sleep(r.Next(5000)); // random broj od 0 do 5ms
                t++;
                //  temperaturaJePromenjenaDogadjaj(t); // event se poziva kao funkcija
                temperaturaJePromenjenaDogadjaj?.Invoke(t); //ako je null nemoj nista da poozvias, ako nije -> pozovi sve
            }
        }
    }
}
