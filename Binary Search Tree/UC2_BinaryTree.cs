using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class UC2_BinaryTree
    {
        public void binaryTree()
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
        }
    }
}
