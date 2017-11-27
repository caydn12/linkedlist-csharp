using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        private Node<T> _tail;

        public LinkedList()
        {
            _head = _tail = null;
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_Empty())
            {
                _FirstInsert(newNode);
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
        }

        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_Empty())
            {
                _FirstInsert(newNode);
            }
            else
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
        }

        public void Clear()
        {
            Node<T> travel = _head;
            Node<T> trail = null;

            while (travel != null)
            {
                trail = travel;
                travel = travel.Next;
                trail.Next = null;
                trail.Previous = null;
            }

            _head = _tail = null;
        }

        public void Display()
        {
            Node<T> travel = _head;

            while (travel != null)
            {
                Console.WriteLine(travel.Data.ToString());
                travel = travel.Next;
            }
        }

        public void DisplayBackwards()
        {
            Node<T> travel = _tail;
            while (travel != null)
            {
                Console.WriteLine(travel.Data.ToString());
                travel = travel.Previous;
            }
        }

        private bool _Empty()
        {
            return (_head == null && _tail == null);
        }

        private void _FirstInsert(Node<T> newNode)
        {
            _head = _tail = newNode;
        }

    }
}
