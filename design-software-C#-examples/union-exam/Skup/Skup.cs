using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skup
{
    public interface IJEdnakost<Tip>
    {
        bool DaLiSuJednak(Tip tip);
    }
   
    public class Skup<Tip> : IEnumerable<Tip>
        where Tip : struct, IJEdnakost<Tip>, new()
    {
        List<Tip> Objekti;

        public delegate void ElementJeDuplikatDelegate(Tip tip);
        public event ElementJeDuplikatDelegate ElementJeDuplikat;
        public Skup()
        {
            Objekti = new List<Tip>();
        }

        public int BrojElemenata
        {
            get
            {
                return Objekti.Count;
            }
        }

        public void Dodaj(Tip tip)
        {
            Objekti.Add(tip);
        }

        public void Duplikati(Tip tip)
        {
            foreach(var o in Objekti)
            {
                if (o.DaLiSuJednak(tip))
                {
                    Objekti.Remove(o);
                    if(ElementJeDuplikat != null)
                    {
                        ElementJeDuplikat(o);
                    }
                }
                else
                {
                    Objekti.Add(tip);
                }
            }
        }

        public void Izbaci(Tip tip)
        {
            foreach(var o in Objekti)
            {
                if (o.DaLiSuJednak(tip))
                {
                    Objekti.Remove(o);
                }
                else
                {
                    throw new Exception("Objekat ne postoji!");
                }
            }
        }

        public IEnumerator<Tip> GetEnumerator()
        {
            for(int i = 0; i < BrojElemenata; i++)
            {
                yield return Objekti[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static Skup<Tip> operator +(Skup<Tip> s1, Skup<Tip> s2)
        {
            Skup<Tip> skup = new Skup<Tip>();
            foreach(var o in s1)
            {
                skup.Dodaj(o);
            }

            foreach(var oo in s2)
            {
                skup.Dodaj(oo);
            }

            return skup;
        }

        public static Skup<Tip> operator -(Skup<Tip> s1, Skup<Tip> s2)
        {
            Skup<Tip> skup = new Skup<Tip>();
            foreach (var o in s1)
            {
                skup.Dodaj(o);
            }

            foreach (var oo in s2)
            {
                skup.Izbaci(oo);
            }

            return skup;
        }

        public static bool operator ==(Skup<Tip> s1, Skup<Tip> s2)
        {
            Skup<Tip> skup = new Skup<Tip>();
            foreach (var o in s1)
            {
                foreach (var oo in s2)
                {
                    if (!(o.Equals(oo)))
                    {
                        return true;
                        
                    }
                   
                }
               
            }

            return false;
        }
        public static bool operator !=(Skup<Tip> s1, Skup<Tip> s2)
        {
            Skup<Tip> skup = new Skup<Tip>();
            foreach (var o in s1)
            {
                foreach (var oo in s2)
                {
                    if ((o.Equals(oo)))
                    {
                        return true;

                    }

                }

            }

            return false;
        }

        public bool Podskup(Skup<Tip> s1, Skup<Tip> s2)
        {
            var tacno = false;
            if(s1.BrojElemenata > s2.BrojElemenata)
            {
                foreach (var o in s1)
                {
                    foreach (var oo in s2)
                    {
                        if ((o.Equals(oo)))
                        {
                            tacno = true;

                        }

                    }

                }
                if(tacno == true)
                {
                    Console.WriteLine("PODSKUP");
                }
                else
                {
                    Console.WriteLine("NIje podskup");
                }
            }
            if (s1.BrojElemenata < s2.BrojElemenata)
            {
                foreach (var o in s2)
                {
                    foreach (var oo in s1)
                    {
                        if ((o.Equals(oo)))
                        {
                            tacno = true;

                        }

                    }

                }
                if (tacno == true)
                {
                    Console.WriteLine("PODSKUP");
                }
                else
                {
                    Console.WriteLine("NIje podskup");
                }
            }
            return tacno;
        }


    }
}

