using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            UC1_AddDataIntoBST BST = new UC1_AddDataIntoBST();
            BST.add();

            UC2_BinaryTree BST2 = new UC2_BinaryTree();
            BST2.binaryTree();

            UC3_SearchNode BST3 = new UC3_SearchNode();
            BST3.search(63);
        }
    }
}
