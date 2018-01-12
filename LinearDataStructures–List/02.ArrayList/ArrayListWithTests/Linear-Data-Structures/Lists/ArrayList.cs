using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayList<T> :IEnumerable<T>
{
    private const int Initial_Capacity = 2;

    private T[] items;

    public ArrayList()
    {
        this.items = new T[Initial_Capacity];
        this.Count = 0;
    }

    public int Count { get; private set; }

    public T this[int index]
    {
        get
        {
            if (!this.ValidateInex(index))
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            return this.items[index];
        }
        set
        {
            if (!this.ValidateInex(index))
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            this.items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.items.Length == this.Count + 1)
        {
            this.Resize();
        }

        this.items[this.Count] = item;
        this.Count++;
    }

    public T RemoveAt(int index)
    {
        if (!ValidateInex(index))
        {
            throw new ArgumentOutOfRangeException("Invalid index");
        }

        T item = this.items[index];

        this.items[index] = default(T);
        this.Shift(index);
        this.Count--;

        if (this.Count <= this.items.Length / 4)
        {
            this.Shrink();
        }

        return item;
    }

    private void Shrink()
    {
        T[] copy = new T[this.items.Length / 2];
        for (int i = 0; i < this.Count; i++)
        {
            copy[i] = this.items[i];
        }

        this.items = copy;
    }

    private void Shift(int index)
    {
        for (int i = index; i < this.Count; i++)
        {
            this.items[i] = this.items[i + 1];
        }
    }

    private void Resize()
    {
        T[] newArray = new T[this.items.Length * 2];
        for (int i = 0; i < this.Count; i++)
        {
            newArray[i] = this.items[i];
        }

        this.items = newArray;
    }

    private bool ValidateInex(int index)
    {
        if (index < 0 || index > this.Count - 1)
        {
            return false;
        }

        return true;
    }

    public IEnumerator<T> GetEnumerator()
    {
        int index = this.Count;
        while(index > 0)
        {
            yield return this.items[this.Count - index];
            index--;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}