using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvostrukoPovezanaGenerickaLista
{
    class Element<Tip>
    {
        public Tip vrednost;
        public Element<Tip> sledeci;
        public Element<Tip> prethodni;

        public Element(Tip vrednost) 
        {
            this.vrednost = vrednost;
            sledeci = null;
            prethodni = null;
        }
    }

    public delegate void Delegati<Tip>(Tip vrednost);

    public delegate bool Predikat<Tip>(Tip vrednost);

    class DvostrukaLista<Tip> : IEnumerable where Tip : class, IUporediv<Tip>,new()
    {
        int brojElemenata;
        Element<Tip> glava;
        Element<Tip> rep;

        public int BrojElemenata 
        {
            get 
            {
                return brojElemenata;
            }
        }

        public event Delegati<Tip> DodatJeNoviElement;

        public void dodaj(Tip vrednost) 
        {
            Element<Tip> noviElement = new Element<Tip>(vrednost);
            if (glava == null)
            {
                glava = noviElement;
                rep = noviElement;
                brojElemenata = 1;
            }
            else 
            {
                if (vrednost.Uporedi(glava.vrednost) == 1)
                {
                    glava.prethodni = noviElement;
                    noviElement.sledeci = glava;
                    glava = noviElement;
                    brojElemenata++;
                }
                else
                {
                    Element<Tip> tmp = glava;
                    Element<Tip> tmp_desno = glava.sledeci;

                    while (tmp_desno != null && vrednost.Uporedi(tmp.vrednost) != 1)
                    {
                        tmp = tmp.sledeci;
                        tmp_desno = tmp_desno.sledeci;
                    }
                    if (tmp_desno != null)
                    {
                        noviElement.sledeci = tmp_desno;
                        noviElement.sledeci = tmp;
                        tmp.sledeci = noviElement;
                        tmp_desno.prethodni = noviElement;

                        brojElemenata++;
                    }
                    else
                    {
                        noviElement.prethodni = rep;
                        rep.sledeci = noviElement;
                        rep = noviElement;

                        brojElemenata++;
                    }
                }
                if (DodatJeNoviElement != null)
                {
                    DodatJeNoviElement(vrednost);
                }
            }
        }

        public void Stampaj()
        {
            Element<Tip> tmp = glava;

            while (tmp != null)
            {
                Console.WriteLine(tmp.vrednost);
                tmp = tmp.sledeci;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Element<Tip> tmp = glava;

            while (tmp != null)
            {
                yield return tmp.vrednost;
                tmp = tmp.sledeci;
            }
        }

        public IEnumerable<Tip> ObrnutiPoredak()
        {
            Element<Tip> tmp = rep;

            while (tmp != null)
            {
                yield return tmp.vrednost;
                tmp = tmp.prethodni;
            }
        }

        public Tip this[int pozicija]
        {
            get
            {
                if (pozicija < 0 || pozicija >= brojElemenata)
                    throw new Exception("Uzak sator ladna sarma!");
                else
                {
                    Element<Tip> tmp = glava;
                    for (int i = 0; i < pozicija; i++)
                        tmp = tmp.sledeci;
                    return tmp.vrednost;
                }
            }
            set
            {
                if (pozicija < 0 || pozicija >= brojElemenata)
                    throw new Exception("Uzak sator ladna sarma!");
                else
                {
                    Element<Tip> tmp = glava;
                    for (int i = 0; i < pozicija; i++)
                        tmp = tmp.sledeci;
                    this[pozicija] = tmp.vrednost;
                }
            }
        }


        public static explicit operator List<Tip>(DvostrukaLista<Tip> dLista)
        {
            List<Tip> lista = new List<Tip>();

            foreach (Tip el in dLista)
                lista.Add(el);

            return lista;
        }

        public static DvostrukaLista<Tip> operator +(DvostrukaLista<Tip> lista1, DvostrukaLista<Tip> lista2)
        {
            DvostrukaLista<Tip> lista = new DvostrukaLista<Tip>();

            foreach (Tip item in lista1)
            {
                lista.dodaj(item);
            }

            foreach (Tip item in lista2)
            {
                lista.dodaj(item);
            }
            return lista;
        }

        //public static explicit operator List<Tip>(DvostrukaLista<Tip> dLista)
        //{
        //    List<Tip> lista = new List<Tip>();

        //    foreach (Tip item in dLista)
        //    {
        //        lista.Add(item);
        //    }
        //    return lista;
        //}

        public IEnumerable<Tip> where(Predikat<Tip> predkiat)
        {
            foreach (Tip item in this)
            {
                if (predkiat(item))
                    yield return item;
            }
        }
    }
}
