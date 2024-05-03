using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1n3
{
    internal class Node
    {
        public int Value { get; }
        public List<Node> Children { get; }
        public Node(int value)
        {
            Value = value;
            Children = new List<Node>();
        }
        public void AddChild(Node newChild)
        {
            Children.Add(newChild);
        }
        public void PrintTree()
        {
            Console.Write($"Потомки узла {Value}: ");
            foreach (var child in Children)
            {
                Console.Write($"{child.Value} ");
            }
            Console.WriteLine();

            foreach (var child in Children)
            {
                child.PrintTree();
            }
        }
    }
}
