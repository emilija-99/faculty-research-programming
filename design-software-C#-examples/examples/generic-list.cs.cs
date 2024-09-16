using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    // Public generic interface IComparable requiring the implementation of the Compare method
    interface IComparable<T>
    {
        int Compare(T other);
    }

    // Generic class representing an element in a singly linked list
    public class Element<T>
    {
        public T Value;
        public Element<T> Next;
        private int elementCount = 0;

        // Property for the number of elements
        public int ElementCount
        {
            get { return elementCount; }
        }

        // Indexer to access elements in the list
        public T this[int position]
        {
            get
            {
                Element<T> temp = GetElement(position);
                return temp.Value;
            }
            set
            {
                Element<T> temp = GetElement(position);
                temp.Value = value;
            }
        }

        private Element<T> GetElement(int position)
        {
            if (position >= elementCount || position < 0)
                throw new Exception("Invalid position!");
            Element<T> temp = head;
            for (int i = 0; i < position; i++)
                temp = temp.Next;
            return temp;
        }
    }

    // Generic list implementing IEnumerable and ensuring elements implement IComparable
    class GenericList<T> : IEnumerable where T : IComparable<T>
    {
        private Element<T> head = null;
        private Element<T> tail = null;
        private int elementCount = 0;

        // Constructor that accepts a generic type and sets it as the head of the list
        public GenericList(T value)
        {
            Add(value);
        }

        // Method to add a new element to the list
        public void Add(T newValue)
        {
            Element<T> newElement = new Element<T> { Value = newValue };

            if (head == null)
            {
                head = newElement;
                tail = head;
            }
            else
            {
                tail.Next = newElement;
                tail = newElement;
            }
            elementCount++;
        }

        // IEnumerable implementation to iterate through the list
        public IEnumerator GetEnumerator()
        {
            Element<T> temp = head;

            while (temp != null)
            {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        // Method to sort the list using selection sort
        public void Sort()
        {
            for (int i = 0; i < elementCount - 1; i++)
            {
                for (int j = i + 1; j < elementCount; j++)
                {
                    T t1 = this[i];
                    T t2 = this[j];

                    if (t1.Compare(t2) == 1)
                    {
                        // Swap elements
                        this[i] = t2;
                        this[j] = t1;
                    }
                }
            }
