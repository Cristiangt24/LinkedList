using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleList;

public class DoubleLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    public DoubleLinkedList()
    {
      _head = null;
      _tail = null;
    }
    public bool Contains(T data)
    {
        throw new NotImplementedException();
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
    }

    public void InsertAtEnding(T data)
    {
        throw new NotImplementedException();
    }

    public void InsertOrdered(T data)
    {
        throw new NotImplementedException();
    }

    public void OrderList()
    {
        throw new NotImplementedException();
    }

    public void Remove(T data)
    {
        throw new NotImplementedException();
    }

    public void Reverse()
    {
        throw new NotImplementedException();
    }
    override public string ToString()
    {
        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        result += "null";
        return result;
    }
}
