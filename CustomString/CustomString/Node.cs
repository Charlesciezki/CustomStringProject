using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class Node <T>
    {
        public T storage { get; set; }
        public Node<T> next { get; set; }
        public Node<T> previous { get; set; }
        public Node(T data)
        {
            storage = data;
        }
        public Node()
        {

        }
    }
}
