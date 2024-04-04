using System;
using System.Numerics;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class TreeNode
    {
        private int data;
        public int Data
        {
            get { return data; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        private bool isDeleted;
        public bool IsDeleted
        {
            get { return isDeleted; }
        }

        public TreeNode(int value)
        {
            data = value;
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }

            return null;
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public void Current()
        {
            TreeNode currentNode = this;

            while (currentNode.rightNode != null)
            {
                currentNode = currentNode.rightNode;
            }

            Console.WriteLine(currentNode.data.ToString());
        }

        public TreeNode Next(int value)
        {
            TreeNode currentNode = this;
            TreeNode nextNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && isDeleted == false)
                {
                    currentNode = currentNode.rightNode;

                    Console.WriteLine(currentNode.data.ToString());
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
                if (currentNode != null)
                {
                    nextNode = currentNode;
                }
            }

            if (nextNode.rightNode != null) 
            {
                nextNode = nextNode.rightNode;

                Console.WriteLine(nextNode.data.ToString());
            } 
            else if (nextNode.rightNode == null && nextNode.leftNode != null)
            {
                nextNode = nextNode.leftNode;

                Console.WriteLine(nextNode.data.ToString());
            } 
            else
            {
                Console.WriteLine("There is no next node :(");
            }

            return null;

        }

        public void Previous(int value)
        {
            TreeNode currentNode = this;
            TreeNode previousNode = this;

            while (currentNode.data != value) 
            {
                if (value == currentNode.data)
                {
                    Console.WriteLine(previousNode.data.ToString());
                }

                if (value > currentNode.data)
                { 
                    if (currentNode.rightNode != null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.rightNode;
                    } 
                    else if (currentNode.leftNode != null && currentNode.rightNode == null)
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.leftNode;
                    }
                }
            }

            Console.WriteLine(previousNode.data.ToString());
        }

        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }

            Console.Write(data + " ");

            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }

        public void PostorderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.PostorderTraversal();
            }

            if (rightNode != null)
            {
                rightNode.PostorderTraversal();
            }

            Console.Write(data + " ");
        }
    }
}