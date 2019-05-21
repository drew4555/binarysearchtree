using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionary_Search_Tree
{
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            
        }

        public void CreateNode(int value)
        {
            Node newNode = new Node();
            Node current;
            Node tempParent;
            newNode.number = value;
            
            if (root == null)
            {
                root = newNode;
            }
            else if (root != null)
            {
                current = root;
                while (newNode.parent == null)
                {
                    tempParent = current;
                    if (newNode.number <= current.number)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            tempParent.left = newNode;
                            newNode.parent = tempParent;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            tempParent.right = newNode;
                            newNode.parent = tempParent;
                        }
                    }
                }
            }
        }
        public void Search(int value)
        {
            Node currentNode;
            if(root.number == value)
            {
                Display();
            }
            while (value < root.number)
            {
                currentNode = root.left;
                if (currentNode.number == value)
                {
                    Display();
                }
                else if (currentNode.number < value)
                {
                    currentNode.left = currentNode;
                }
                else if (currentNode.number > value)
                {
                    currentNode.right = currentNode;
                }
                else if(currentNode == null)
                {
                    Console.WriteLine("Could not find Node");
                }
            }
            if (value > root.number)
            {
                currentNode = root.right;
                while (currentNode.number < value)
                {
                    currentNode = currentNode.right;
                }
                while (currentNode.number > value)
                {
                    currentNode = currentNode.left;
                }
                if (currentNode.number == value)
                {
                    Display();
                }
                else if (currentNode == null)
                {
                    Console.WriteLine("Could not find Node");
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Found The Node you were looking for");
        }
    }
}
