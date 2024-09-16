using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DList
{
    class Element<GenericType>
    {
        public GenericType value;
        public Element<GenericType> next;
        public Element<GenericType> previous;
    
        public Element(GenericType value)
        {
            this.value = value;
            next = null;
            previous = null;
        }
    }

    public delegate void Delegat<T>(T value);
    public delegate bool Predikat<T>(T value);

    class DList<GenericType> : IEnumerable where GenericType : class, IUporediv<GenericType>, new()
    {
        Element<GenericType> head;
        Element<GenericType> tail;
        int brojElemenata;

        public int BrojElementata
        {
            get
            {
                return brojElemenata;
            }
        }

        public event Delegat<GenericType> DodatJeNoviElement;
        


        public void dodaj(GenericType value)
        {
            Element<GenericType> newElement = new Element<GenericType>(value);

            if(head == null)
            {
                head = newElement;
                tail = newElement;
                brojElemenata = 1;
            }
            else
            {
                if(value.Uporedi(head.value) == 1)
                {
                    head.previous = newElement;
                    newElement.next = head;
                    head = newElement;
                    brojElemenata++;
                }
                else
                {
                    Element<GenericType> temp = head;
                    Element<GenericType> tempRight = head.next;

                    while(tempRight!=null && value.Uporedi(tempRight.value) != 1)
                    {
                        temp = temp.next;
                        tempRight = tempRight.next;
                    }

                    if(tempRight != null)
                    {
                        newElement.next = tempRight;
                        newElement.previous = temp;
                        temp.next = newElement;
                        tempRight.previous = newElement;

                        brojElemenata++;
                    }
                    else
                    {
                        newElement.previous = tail;
                        tail.next = newElement;
                        tail = newElement;

                        brojElemenata++;
                    }
                    

                    // newElement = 1
                    // newElement = 40
                    //2 6 10 14 14 18 18 22 25 36 null
                            //    15

                }
            }

            if(DodatJeNoviElement != null)
            {
                DodatJeNoviElement(value);
            }
        }

        public void stampajElemente()
        {
            Element<GenericType> temp = head;
            int counter = 0;

            while(temp != null)
            {
                Console.WriteLine(temp.value + " Index = " + counter );
                temp = temp.next;
                counter++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            Element<GenericType> temp = head;

            while (temp != null)
            {
                yield return temp.value;
                temp = temp.next;
            }
        }

        public IEnumerable<GenericType> ObrnutiPoredak()
        {
            Element<GenericType> temp = tail;

            while (temp != null)
            {
                yield return temp.value;
                temp = temp.previous;
            }
        }

        public GenericType this[int index]
        {
            get
            {
                if (index < 0 || index >= brojElemenata)
                    throw new IndexOutOfRangeException("Invalid value");
                else
                {
                    Element<GenericType> temp = head;
                    for (int i = 0; i < index; i++)
                        temp = temp.next;

                    return temp.value;
                }
            }
        }

        public static DList<GenericType> operator +(DList<GenericType> lista1, DList<GenericType> lista2)
        {
            DList<GenericType> lista = new DList<GenericType>();

            foreach(GenericType el in lista1)
            {
                lista.dodaj(el);
            }

            foreach (GenericType el in lista2)
            {
                lista.dodaj(el);
            }

            return lista;
        }

        public static explicit operator List<GenericType>(DList<GenericType> dLista)
        {
            List<GenericType> lista = new List<GenericType>();

            foreach (GenericType el in dLista)
                lista.Add(el);

            return lista;
        } 

        public IEnumerable<GenericType> Where(Predikat<GenericType> predikat)
        {
            foreach(GenericType el in this)
                if(predikat(el) )
                    yield return el;
        }
    }
}
