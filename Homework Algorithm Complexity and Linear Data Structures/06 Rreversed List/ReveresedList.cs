using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06_Rreversed_List
{
    public class ReveresedList<T> : IEnumerable<T>
    {
        private const int DefaultCapactity = 2;
        private T[] items;
        private T[] reverseItems;
        private int index;
        private int currentCapacity;

        public ReveresedList(int capacity = DefaultCapactity)
        {
            this.items = new T[capacity];
            this.index = 0;
            this.currentCapacity = capacity;
        }

        public int Count => this.index;

        public int Capacity => this.items.Length;

        public void Add(T element)
        {
            this.items[this.index] = element;                 
            this.index++;
            this.reverseItems = new T[index];
            FullReverseArr(this.index, this.items, this.reverseItems);

            if (this.index == currentCapacity)
            {
                this.Resize(this.index * 2);
            }
        }

        private void FullReverseArr(int index, T[] elements, T[] reverseElements)
        {
            int position = 0;
            for (int i = index - 1; i >= 0; i--)
            {
                reverseElements[position] = elements[i];
                position++;
            }            
        }

        public T this[int position]
        {
            get { return this.reverseItems[position]; }
            set
            {
                if (position > this.index)
                {
                    this.index++;
                }

                this.reverseItems[position] = value;
            }
        }


        public void RemoveAt(int ind)
        { 
            List<T> removedReverseArr = new List<T>(this.reverseItems.Take(ind));
            for (int i = ind + 1; i < this.reverseItems.Length; i++)
            {
                removedReverseArr.Add(this.reverseItems[i]);
            }

            this.reverseItems = removedReverseArr.ToArray();
            this.index--;
            FullReverseArr(this.reverseItems.Length, this.reverseItems, this.items);
            var newItems = this.items.Take(this.index);
            this.items = newItems.ToArray();
        }

        private void Resize(int size)
        {
            T[] newArr = new T[size];
            for (int i = 0; i < this.items.Length; i++)
            {
                newArr[i] = items[i];
            }

            this.items = newArr;
            this.currentCapacity = size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var ind = 0;
            while (ind != this.index)
            {
                yield return this.reverseItems[ind];
                ind++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
