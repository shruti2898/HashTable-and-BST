using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class UC3_SearchNode
    {
        public void search(int value)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);  // 56 root node
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);

            bst.Display();

            bool result = bst.IfExists(value, bst);

            if (result)
            {
                Console.WriteLine("Node found in Binary tree");
            }
            else
            {
                Console.WriteLine("Node not found in Binary tree");
            }
        }
    }
}
