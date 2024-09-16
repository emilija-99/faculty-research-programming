using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe4
{
    public class Test<T, V>
        where T: class
        where V : class,IComparable<V>, IPrebivaliste, new()
    {
        /*
         * Test<int,Student> t1 = new Test<int, Student>(10,15, new Student()); -> samo ako postoji where GenerickiTip : struct
         sa where dajes smisao koji je Genericki tip, referentni tipovi class
            where V:class, new() -> mora da ima podrazumevani konstuktor
         */ 
        T vrednost;
        V vrednost2;
        int vrednost1;
        
        public Test(T vrednost,V vrednost2, int vrednost1)
        {
            this.vrednost = vrednost;
            this.vrednost2 = vrednost2;
            this.vrednost1 = vrednost1;
        }

        V v = new V(); // klasa
        //Console.WriteLine(v.toSting());

       // string s = v.dajIme();
       
        T t = default(T);
        
        // int => null
        // sturcktura -> podrazumevana vrednosti
        // referentni tip -> null
/*
        public T Vrednost
        {
            get => vrednost;
            set => vrednost = value;
        }
        public V Vrednost2
        {
            get => vrednost2;
            set => vrednost2 = value;
        }
        public int Vrednost1
        {
            get => vrednost1;
            set => vrednost1 = value;
        }
        */
        public void Write()
        {
            Console.WriteLine(vrednost.ToString()+" "+vrednost1.ToString()+" "+vrednost2.ToString()); 
        }
    }
}
