namespace Shared;

public interface ILinkedList<T>
{
        bool Contains(T data);
    void InsertAtBeginning(T data);
    void InsertAtEnding(T data);
    void InsertOrdered(T data);
    void OrderList();
    void Remove(T data);
    void Reverse();
    string ToString();
}
