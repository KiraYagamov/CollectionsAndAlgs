using System.Collections;
using System.Collections.Generic;
namespace Project
{
    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> _head;
        Node<T> _tail;
        int _count;
        
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
     
            if (_head == null)
                _head = node;
            else
                _tail.Next = node;
            _tail = node;
     
            _count++;
        }
        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;
     
            while (current != null && current.Data != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        
                        if (current.Next == null)
                            _tail = previous;
                    }
                    else
                    {
                        _head = _head?.Next;
                        
                        if (_head == null)
                            _tail = null;
                    }
                    _count--;
                    return true;
                }
     
                previous = current;
                current = current.Next;
            }
            return false;
        }
     
        public int Count { get { return _count; } }
        public bool IsEmpty { get { return _count == 0; } }
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        public bool Contains(T data)
        {
            Node<T> current = _head;
            while (current != null && current.Data !=null)
            {
                if (current.Data.Equals(data)) return true;
                current = current.Next;
            }
            return false;
        }
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = _head;
            _head = node;
            if (_count == 0)
                _tail = _head;
            _count++;
        }

        public object Get(int index)
        {
            if (_count >= index + 1)
            {
                Node<T> node = _head;
                for (int i = 0; i < index; i++)
                {
                    node = node?.Next;
                }
                return node.Data;
            }
            else
            {
                return null;
            }
        }
     
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}