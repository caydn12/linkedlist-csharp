using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    // Node data and properties
    public partial class Node<T>
    {
        private T _data;
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        private Node<T> _next;
        public Node<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }

        private Node<T> _previous;
        public Node<T> Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }

        public Node(T data)
        {
            Data = data;
            Next = Previous = null;
        }
    }
}
