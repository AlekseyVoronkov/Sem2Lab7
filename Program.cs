using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");

            BinaryTree binaryTree = new BinaryTree();
            bool isEnough = false;
            string userTreeNode;

            Console.WriteLine("Type in q to stop adding nodes\n");
            Console.WriteLine("Insert tree nodes: ");

            while (true)
            {
                while (isEnough == false)
                {
                    userTreeNode = Console.ReadLine();

                    if (userTreeNode != "q")
                    {
                        binaryTree.Insert(Convert.ToInt32(userTreeNode));
                    } else
                    {
                        isEnough = true;
                    }
                }

                Console.WriteLine("\nWhat do you want to do? " +
                                  "\n1.In order traversal" +
                                  "\n2.Post order traversal" +
                                  "\n3.Current" +
                                  "\n4.Next" +
                                  "\n5.Previous" +
                                  "\n6.Foreach test" +
                                  "\n7.Exit");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine("\nIn Order Traversal (Left->Root->Right)");
                    binaryTree.InOrderTraversal();

                } 
                else if (userChoice == 2)
                {
                    Console.WriteLine("\nPost Order Traversal (Left->Right->Root)");
                    binaryTree.PostorderTraversal();

                } 
                else if (userChoice == 3)
                {
                    binaryTree.Current();
                } 
                else if (userChoice == 4)
                {
                    Console.WriteLine("\nChoose your node: ");

                    int userNode = Convert.ToInt32(Console.ReadLine());

                    binaryTree.Next(userNode);
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\nChoose your node: ");

                    int userNode = Convert.ToInt32(Console.ReadLine());

                    binaryTree.Previous(userNode);
                }
                else if (userChoice == 6)
                {
                    Console.WriteLine();

                    foreach (var element in binaryTree)
                    {
                        Console.WriteLine(element.Data);
                    }
                }
                else if (userChoice == 7)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
        }
    }
}