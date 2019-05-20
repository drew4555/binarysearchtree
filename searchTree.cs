using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        //member variables
        public int number;
        public Node right;
        public Node left;

        //ctor
        public Node(int value)
        {
            number = value;
            right = null;
            left = null;
        }

        //member methods
        public bool IsLeaf(ref Node node)
        {
            return (node.right == null && node.left == null);
        }
        public void InsertData(ref Node node, int data)
        {
            if(node == null)
            {
                node = new Node(data);
            }
            else if (node.number < data)
            {
                InsertData(ref node.right, data);
            }
            else if (node.number > data)
            {
                InsertData(ref node.left, data);
            }
        }
    }
}
