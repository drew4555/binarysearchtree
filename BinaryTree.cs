using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionary_Search_Tree
{
    class BinaryTree
    {
        public Node root;
        int count;
        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return root == null;
        }
        public void Insert(int number)
        {
            if (IsEmpty())
            {
                root = new Node();
            }
        }
    }
}
