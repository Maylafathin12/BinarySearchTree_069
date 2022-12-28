using System;

namespace BinarySearchTree_069
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;
        //constructor for the Node Class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    //a node class consist of three things, the information, revfernces to the right child, and
    //references to the left child.

    class program
    {
        public Node ROOT;
        public program()
        {
            ROOT = null; /* Intializing ROOT to null*/
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            currentNode = ROOT;
            parent = null;
            while((currentNode != null)&& (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
