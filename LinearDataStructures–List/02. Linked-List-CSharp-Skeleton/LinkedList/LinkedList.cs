using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T>
{
    private class ListNode
    {
        public ListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public ListNode NextNode { get; set; }
    }

    public int Count { get; private set; }

    private ListNode head { get; set; }

    private ListNode tail { get; set; }

    public void AddFirst(T item)
    {
        var newHead = new ListNode(item);
        if (this.Count == 0)
        {
            this.head = this.tail = new ListNode(item);
        }
        else
        {
            newHead.NextNode = this.head;
            this.head = newHead;
        }

        this.Count++;
    }

    public void AddLast(T item)
    {
        var newHead = new ListNode(item);
        if (this.Count == 0)
        {
            this.head = this.tail = new ListNode(item);
        }
        else
        {          
            this.tail.NextNode = newHead;
            this.tail = newHead;
        }

        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List is empty!");
        }

        T oldHeadValue = this.head.Value;
        this.head = this.head.NextNode;

        this.Count--;

        return oldHeadValue;
    }

    public T RemoveLast()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List is empty!");
        }

        T oldHeadValue = this.tail.Value;
        if (this.Count == 1)
        {
            this.tail = this.head = null;

        }
        else
        {
            var element = this.head;
            while(element.NextNode != this.tail)
            {
                element = element.NextNode;
            }

            element.NextNode = null;
            this.tail = element;
        }

        this.Count--;

        return oldHeadValue;
    }

    public IEnumerator<T> GetEnumerator()
    {
        ListNode currentNode = this.head;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.NextNode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
