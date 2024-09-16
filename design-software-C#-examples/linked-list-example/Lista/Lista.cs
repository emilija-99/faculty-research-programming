using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public interface IUporediv<Tip>
    {
        int Uporedi(Tip tip);
    }
    public class Element<T>
    {

        public T vrednost;
        public Element<T> sledeci;
    }
        public class Lista<Tip> : IEnumerable
            where Tip : class, IUporediv<Tip>

        {
            Element<Tip> glava = new Element<Tip>();
            Element<Tip> kraj = null;
            int brojElemanata = 0;

            public int BrojElemenata
            {
                get
                {
                    return brojElemanata;
                }
            }
            public Lista()
            {

            }
            public Lista(Tip tip)
            {
                AddEnd(tip);
            }
            public void AddEnd(Tip tip)
            {

                Element<Tip> pom = new Element<Tip>();
                pom.vrednost = tip;
                pom.sledeci = null;



                Element<Tip> tmp = glava;

                while (tmp.sledeci != null)
                {
                    tmp = tmp.sledeci;
                }
                tmp.sledeci = pom;

                brojElemanata++;
            }

            public void AddStart(Tip tip)
            {
                Element<Tip> tmp = glava;
                Element<Tip> novi = new Element<Tip>();
                novi.vrednost = tip;
                novi.sledeci = null;

                if (glava == null)
                {
                    glava = novi;
                }
                else
                {
                    novi.sledeci = glava;
                    glava = novi;
                }
                brojElemanata++;

            }

            public void StampajListu()
            {
                while (glava != null)
                {
                    Console.WriteLine(glava.vrednost);
                    glava = glava.sledeci;
                }
            }

            public int Uporedi(Tip tip)
            {
                throw new NotImplementedException();
            }

            public Tip this[int pozicija]
            {
                get
                {
                    if (pozicija < 0 || pozicija > BrojElemenata)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        Element<Tip> tmp = glava;
                        while (pozicija > 0)
                        {
                            tmp = tmp.sledeci;
                            pozicija--;
                        }
                        return tmp.vrednost;
                    }
                }
                set
                {
                    if (pozicija < 0 || pozicija > BrojElemenata)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        Element<Tip> tmp = glava;
                        while (pozicija > 0)
                        {
                            tmp = tmp.sledeci;
                            pozicija--;
                        }
                        tmp.vrednost = value;
                    }
                }
            }


            public delegate void ElementPostojiUListiDelegate(Tip tip);
            public event ElementPostojiUListiDelegate ElementPostojiUListi;

            public void Provera(Tip tip)
            {
                Element<Tip> tmp = glava;
                int provera = 0;
                while (tmp.sledeci != null)
                {
                    if (tmp.vrednost == tip)

                    {
                        if (ElementPostojiUListi != null)
                        {
                            ElementPostojiUListi(tip);
                        }

                        provera++;
                    }
                }
                if (provera == 0)
                {
                    AddEnd(tip);
                }
            }

        public IEnumerator GetEnumerator()
        {
            while(glava != null)
            {
                yield return glava.vrednost;
                glava = glava.sledeci;

            }
        }

        public Tip TipGetEnumerator()
        {
            return glava.vrednost;
            glava = glava.sledeci;
        }

        public static List<Tip> operator +(Lista<Tip> a, Lista<Tip> b)
            {
                List<Tip> tips = new List<Tip>();
                foreach (Tip i in a)
                {
                    tips.Add(i);
                }

                foreach (Tip j in b)
                {
                    tips.Add((Tip)j);
                }

                return tips;
            }

            public static implicit operator Lista<Tip>(List<Tip> v)
            {
                Lista<Tip> lista = new Lista<Tip>();
                foreach (Tip el in v)
                {
                    lista.AddStart(el);
                }

                return lista;
            }
            public static explicit operator List<Tip>(Lista<Tip> l)
            {
                List<Tip> lista = new List<Tip>();
                foreach (Tip el in l)
                {
                    lista.Add(el);
                }

                return lista;
            }

        }
    }
