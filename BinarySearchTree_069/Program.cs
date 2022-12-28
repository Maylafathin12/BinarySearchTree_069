using System;

namespace BinarySearchTree_069
{
        class Node
        {
            public string info;
            public string leftchild;
            public string rightchild;

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
