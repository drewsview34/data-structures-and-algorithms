using System;
using System.Collections.Generic;
using System.Text;

namespace Trees15.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public List<object> ArrayList = new List<object>();

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public BinaryTree()
        {

        }

        /// <summary>
        /// Recursively stores the node values of the tree. Then traverses to the next and returns them as an array.
        /// </summary>
        /// <param name="root">Binary Trees Node Root</param>
        /// <returns>Array of node values</returns>
        public object[] PreOrder(Node root)
        {
            try
            {
                ArrayList.Add(root.Value);

                if (root.Left != null)
                {
                    PreOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PreOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ArrayList.ToArray();
        }

        /// <summary>
        /// Stores the node values of the tree starting at the left most leaf. Then recursively adds back upward  and adding as it goes down the right side. Finally, returns them as an array.
        /// </summary>
        /// <param name="root">Binary Tree's Root Node</param>
        /// <returns>Array of node values</returns>
        public object[] InOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    InOrder(root.Left);
                }

                ArrayList.Add(root.Value);

                if (root.Right != null)
                {
                    InOrder(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return ArrayList.ToArray();
        }

        /// <summary>
        /// Stores the node values of the tree. Retunrs to the left side of the tree from the bottom up. Then the right side from the bottom up. Finally to the top root. Returns them as an array.
        /// </summary>
        /// <param name="root">Binary Tree's Root Node</param>
        /// <returns>Array of node values</returns>
        public object[] PostOrder(Node root)
        {
            try
            {
                if (root.Left != null)
                {
                    PostOrder(root.Left);
                }
                if (root.Right != null)
                {
                    PostOrder(root.Right);
                }

                ArrayList.Add(root.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ArrayList.ToArray();
        }
    }
}