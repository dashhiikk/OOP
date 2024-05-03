
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1n3
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = new Node(1);
            Node child1 = new Node(2);
            Node child2 = new Node(3);
            Node grandchild1 = new Node(4);
            Node grandchild2 = new Node(5);

            Head.AddChild(child1);
            Head.AddChild(child2);  
            child1.AddChild(grandchild1);
            child2.AddChild(grandchild2);
            Head.PrintTree();

            Console.ReadLine();
        }
    }
}