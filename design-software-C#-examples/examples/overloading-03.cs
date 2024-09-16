using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DizajnSoftvera
{
    class Cifra{
        public double val;
    
        public Cifra(double d){
            val = d;
        }

        public static implicit operator double(Cifra d){
            return d.val;
        }
        public static implicit operator Cifra(double d){
            return new Cifra(d);
        }
    }
    public struct Complex{
        public int real;
        public int imaginary;

        public Complex(int real, int imaginary){
            this.real = real;
            this.imaginary = imaginary;
        }
// Declare which operator to overload (+) the types that can be added
// (two Complex object), and the return type (Complex)
        public static Complex operator +(Complex c1, Complex c2){
            return new Complex(c1.real+c2.real,c1.imaginary+c2.imaginary);
        }

        public override string ToString(){
            return(String.Format("{0} + {1}i",real, imaginary));
        }
    }
    public class overloading3
    {
        static void Main(String[] args){
            Cifra dig = new Cifra(7);
            double name = dig; // implicit "double"
            Cifra dig2 = 12; // implicit "digit"
            Console.WriteLine("nume = {0} dig2 = {1}",num,dig2.val);
            Console.ReadLine();

// _____________________________________________________________________
            Complex num1 = new Complex(2,3);
            Complex num2 = new Complex(3,4);

// Add two Complex object (num1, num2) through the overloaded plus operator:
            Complex sum = num1+num2;
            Console.WriteLine("First complex number: {0}",num1);
            Console.WriteLine("Second complex number: {0}",num2);
            Console.WriteLine("The sum of two complex numbers: {0}",sum);

        }
    }
}