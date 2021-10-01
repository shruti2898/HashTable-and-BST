using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class UC1_AddDataIntoBST
    {
        public void add()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);  // 56 root node

            bst.Insert(30);   
            bst.Insert(70);

            bst.Display();
        }
    }
}
