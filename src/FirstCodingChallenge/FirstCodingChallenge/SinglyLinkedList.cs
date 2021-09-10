using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstCodingChallenge
{
    /// <summary>
    /// SinglyLinkedList<T> is implementation of singly-linked list with generic type
    /// </summary>
    /// <typeparam name="T">Generic type</typeparam>
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        Node<T> _head; // head/first element
        Node<T> _tail; // tail/last element
        int _count;  // the number of items in the list
        public int Count { get { return _count; } }
        public bool IsEmpty { get { return _count == 0; } }


        /// <summary>
        /// Insert data in SinglyLinkedList by index
        /// </summary>
        /// <param name="data">Our data</param>
        /// <param name="index">The index mustn't be  less 1 or larger in size than the SinglyLinkedList</param>
        public void Insert(T data, int index)
        {
            if ((uint)index >= (uint)_count && (uint)index > 0) throw new ArgumentOutOfRangeException();
            if (_head == null) throw new ArgumentNullException();

            var position = 0;
            Node<T> node = new Node<T>(data);
            Node<T> current = _head;
            while (position == index - 1)
            {
                if (current != null)
                {
                    current = current.Next;
                    position++;
                }
            }

            //Insert our node after current
            node.Next = current.Next;
            current.Next = node;
        }


        /// <summary>
        /// Add data to tail of the SinglyLinkedList 
        /// </summary>
        /// <param name="data">Our data</param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null)
            {
                _head = node;
                _tail = node;
                _tail.Next = _head;
            }
            else
            {
                node.Next = _head;
                _tail.Next = node;
                _tail = node;
            }

            _count++;
        }

        /// <summary>
        /// Remove data from the SinglyLinkedList 
        /// </summary>
        /// <param name="data">Our data</param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;

            if (IsEmpty) return false;

            do
            {
                if (current.Data.Equals(data))
                {
                    // If the knot is in the middle or at the end
                    if (previous != null)
                    {
                        // remove the current node, now previous refers not to current, but to current.Next
                        previous.Next = current.Next;

                        // If the node is the last one, change the tail variable
                        if (current == _tail)
                            _tail = previous;
                    }
                    else // if the first element is removed
                    {
                        // if there is only one element in the list
                        if (_count == 1)
                        {
                            _head = _tail = null;
                        }
                        else
                        {
                            _head = current.Next;
                            _tail.Next = current.Next;
                        }
                    }
                    _count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != _head);

            return false;
        }


        /// <summary>
        /// Clear SinglyLinkedList 
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }


        /// <summary>
        /// Check the existence of our data
        /// </summary>
        /// <param name="data">Our data</param>
        /// <returns></returns>
        public bool Contains(T data)
        {
            Node<T> current = _head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            while (current != _head);
            return false;
        }


        /// <summary>
        /// Get enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        /// <summary>
        /// Get enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != _head);
        }
    }
}
