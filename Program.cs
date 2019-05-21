using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionary_Search_Tree 
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.CreateNode(10);
            myTree.CreateNode(12);
            myTree.CreateNode(14);
            myTree.CreateNode(8);
            myTree.CreateNode(6);
            myTree.CreateNode(6);
            myTree.Search(14);
        }
    }
}
