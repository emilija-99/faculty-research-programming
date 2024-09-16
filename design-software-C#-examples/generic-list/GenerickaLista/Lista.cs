using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerickaLista
{
    public class Element<T>
    {
        public T vrednost;
        public Element<T> sledeci;
    }
    class Lista<Tip> : IEnumerable where Tip : IUporediv<Tip>
    {
        Element<Tip> glava = null;
        Element<Tip> rep = null;

        int brojElemenata = 0;

        public int BrojElemenata{
            get{
                return brojElemenata;
            }
        }

        public Lista(Tip vrednost) {
            Add(vrednost);
        }

        public void Add(Tip novaVrednost) {
            Element<Tip> noviElement = new Element<Tip>();
            noviElement.vrednost = novaVrednost;
            if (glava == null)
            {
                glava = noviElement;
                rep = glava;
                brojElemenata = 1;
            }
            else {
                rep.sledeci = noviElement;
                rep = noviElement;
                brojElemenata++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            Element<Tip> tmp = glava;

            while (tmp != null)
            {
                yield return tmp.vrednost;
                tmp = tmp.sledeci;
            }
        }
        
        public Tip this[int pozicija] {
            get
            {
                Element<Tip> tmp = VratiElement(pozicija);
                return tmp.vrednost;
            }
            set {
                Element<Tip> tmp = VratiElement(pozicija);
                tmp.vrednost = value;
            }
        }

        private Element<Tip> VratiElement(int pozicija)
        {
            Element<Tip> tmp = glava;
            if (pozicija < 0 || pozicija >= brojElemenata)
                throw new Exception("Ovim putem neces proci!\n");
            for (int i = 0; i < pozicija; i++)
                tmp = tmp.sledeci;
            return tmp;
        }

        public void Sortiraj() {
            for (int i = 0; i < brojElemenata; i++)
            {
                for (int j = i + 1; j < brojElemenata; j++)
                {
                    Tip t1 = this[i];
                    Tip t2 = this[j];
                    if (t1.Uporedi(t2) == 1) {

                        this[i] = t2;
                        this[j] = t1;
                    }
                }
            }
        }
    }

    class Student : IUporediv<Student>
    {
        public string ime;
        public double prosek;

        public Student(string ime,double prosek) {
            this.ime = ime;
            this.prosek = prosek;
        }
        public int Uporedi(Student tip)
        {
            if (this.prosek > tip.prosek)
                return 1;
            return 0;
        }

        public override string ToString()
        {
            return ime + " " + prosek;
        }
    }
}
