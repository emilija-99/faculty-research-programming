using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DizajnSoftvera
{
    public class VremenskiPeriod
    {
        private double sekunde;
        public double Sati{
            get{return sekunde/3600;}
            set{sekunde = value*3600;}
        }
        public double Sekunde{
            get{return sekunde;}
            set{sekunde = value;}
        }
    }
    public partial class Datum{
        public int Dan{get;private set;}
        public int Mesec{get;private set;}
        public int Godina{get;private set;}
    }
    public partial class Datum{
        public string ToString(){
            return this.Dan+"/"+this.Mesec+"/"+this.Godina;
        }
    }
    class Program{
        public static void Funkcija(ref int x, out int y){
            x = (x+1)/2;
            y = x*2;
        }
        static void Main(){
            VremenskiPeriod t = new VremenskiPeriod();
            t.Sati = 24;

            System.Console.WriteLine("Vreme u satima"+t.Sati);
            System.console.WriteLine("Vreme u sekundama"+t.Sekunde);

            t.Sekunde = 3600;
            System.console.WriteLine("Vreme u satima"+t.Sati);
            System.Console.WriteLine("Vreme u sekundama"+t.Sati);

            int x = 10;
            int y;
            Funkcija(ref x, out y);
            
        }
    }
}