using System;
using System.Collections;

namespace ConsoleApp3
{

    public class BinaryTree : IEnumerable<TreeNode>
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return InorderTraversal(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<TreeNode> InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                foreach (var item in InorderTraversal(node.LeftNode))
                {
                    yield return item;
                }

                yield return node;

                foreach (var item in InorderTraversal(node.RightNode))
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<TreeNode> PreorderTraversal()
        {
            List<TreeNode> nodes = new List<TreeNode>();

            Action<TreeNode> preorder = null;
            preorder = (node) =>
            {
                if (node != null)
                {
                    nodes.Add(node);
                    preorder(node.LeftNode);
                    preorder(node.RightNode);
                }
            };

            preorder(root);

            return nodes;
        }

        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public TreeNode Next(int data)
        {
            if (root != null)
            {

                return root.Next(data);
            }
            else
            {
                return null;
            }
        }

        public void Current()
        {
            if (root != null)
                root.Current();
        }

        public void Previous(int value)
        {
            if (root != null)
                root.Previous(value);
        }

        public void InOrderTraversal()
        {
            if (root != null)
                root.InOrderTraversal();
        }

        public void PostorderTraversal()
        {
            if (root != null)
                root.PostorderTraversal();
        }

    }
}