using Shared;

namespace SimpleList;

public class SinglyLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;

    public SinglyLinkedList()
    {
        _head = null;
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

    public void InsertAtBeginning(T data)
    {
        var newNode = new Node<T>(data);
        newNode.Next = _head;
        _head = newNode;
    }

    public void InsertAtEnding(T data)
    {
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            return;
        }
        var current = _head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(T data)
    {
        if (_head == null) return;
        if (_head.Data != null && _head.Data.Equals(data))
        {
            _head = _head.Next;
            return;
        }
        var current = _head;
        while (current.Next != null)
        {
            if (current.Next.Data != null && current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }

    public void Reverse()
    {
        Node<T>? previous = null;
        var current = _head;
        while (current != null)
        {
            var next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }
        _head = previous;
    }
    public void OrderList()
    {
        if (_head == null || _head.Next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            var current = _head;

            while (current.Next != null)
            {
                int comparison = Comparer<T>.Default.Compare(current.Data, current.Next.Data);

                if (comparison > 0)
                {
                    T temp = current.Data!;
                    current.Data = current.Next.Data;
                    current.Next.Data = temp;
                    swapped = true;
                }

                current = current.Next;
            }
        } while (swapped);
    }
    public void InsertOrdered(T data)
    {
        var newNode = new Node<T>(data);

        if (_head == null || Comparer<T>.Default.Compare(data, _head.Data) <= 0)
        {
            newNode.Next = _head;
            _head = newNode;
            return;
        }

        var current = _head;
        while (current.Next != null &&
               Comparer<T>.Default.Compare(data, current.Next.Data) > 0)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        current.Next = newNode;
    }
}