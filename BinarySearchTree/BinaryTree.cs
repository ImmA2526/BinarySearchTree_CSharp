using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable
    {

        T NodeData;
        public BinaryTree<T> leftTree { get; set; }
        public BinaryTree<T> rightTree { get; set; }
        bool result = false;
        int leftCount = 0;
        int rightCount = 0;
        public BinaryTree(T NodeData)
        {
            this.NodeData = NodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinaryTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinaryTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightTree.Display();
            }
        }

        public void Size()
        {
            Console.WriteLine("Size of BST is " + (1 + leftCount + rightCount));
        }


    }
}
