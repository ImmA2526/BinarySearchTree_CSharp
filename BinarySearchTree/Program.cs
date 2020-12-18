using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Welcome To Binary Tree****************");
            BinaryTree<int> binarySearchTree = new BinaryTree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
            binarySearchTree.Size();
        }
    }
}
