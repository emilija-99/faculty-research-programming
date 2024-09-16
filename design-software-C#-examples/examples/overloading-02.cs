using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DizajnSoftvera
{
    public struct Cifra{
        byte vrednost;

        public Cifra(byte vrednost){
            if(vrednost > 9){
                throw new ArgumentException("Vrednost "+vrednost+" prevazilazi cifru");
            }
            this.vrednost = vrednost;
        }
        
        public static explicit operator Cifra(byte b){
            Cifra d = new Cigra(b);
            Console.WriteLine("Conversation occured");
            return d;
        }
    }

    public class overloading2
    {
        public overloading2{
            Console.WriteLine("Radi!");    
        }
    }

    class Program{
        static void Main(String[] args){
            try{
                byte b = 3;
                Cifra d = (Cifra)b;
            }catch(Exception e){
                Console.WriteLine("{0} Expetion caught!",e);
            }
        }
    }

}