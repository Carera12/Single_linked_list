using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Single_linked_list
{
    // each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;

    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
