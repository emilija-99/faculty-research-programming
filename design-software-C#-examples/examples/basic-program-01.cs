namespace app
{
    using System;
    using System.Collections;

    // Base class
    public class Zivotinja
    {
        protected string ime;
        public Zivotinja(string ime)
        {
            this.ime = ime;
        }
    }

    // Derived class
    public class Pas : Zivotinja
    {
        private string rasa;

        // Constructor using base (super) class
        public Pas(string ime, string rasa) : base(ime)
        {
            this.rasa = rasa;
        }
    }

    // Sum method using params
    class Calculator
    {
        public int Sum(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
    }

    public sealed class Primer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((new DateTime(2022, 10, 19)).ToString());

            // foreach example
            double[] brojevi = { 1, 5, 3, 7 };
            double zbir = 0;
            foreach (double broj in brojevi)
            {
                zbir += broj;
            }

            Console.WriteLine($"Zbir: {zbir}");

            // Boxing
            int num = 2022;
            object o = num;
            num = 10;
            Console.WriteLine($"Boxing example - o: {o}, num: {num}");

            // Unboxing
            int i = (int)o;
            Console.WriteLine($"Unboxing example - i: {i}");
        }
    }
}
