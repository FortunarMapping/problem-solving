using BinaryTreeLib;
using BT6740201352;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F101_6740201352
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            TraversalMethod t = new TraversalMethod();
            //tree.Root = new Node(15);
            //tree.Root.Left = new Node(9);
            //tree.Root.Left.Right = new Node(11);
            //tree.Root.Left.Left = new Node(6);
            //tree.Root.Right = new Node(17);
            //tree.Root.Right.Right = new Node(20);
            //tree.Root.Right.Right.Left = new Node(18);
            tree.Add(15);
            tree.Add(9);
            tree.Add(6);
            tree.Add(11);
            tree.Add(17);
            tree.Add(20);
            tree.Add(18);
            Console.Write("Preorder Traversal : ");
            t.PreorderTraversal(tree.Root);



        }

    }
}
