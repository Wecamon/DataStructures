using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        internal BinaryTreeNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if (this.Root == null)
            {
                Root = new BinaryTreeNode<T>(data);
                Count = 1;
                return;
            }
            Root.Add(data);
            Count++;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Preorder(Root);
        }

        public List<T> Postrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Postorder(Root);
        }

        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        private List<T> Preorder(BinaryTreeNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.TreeLeft != null)
                {
                    list.AddRange(Preorder(node.TreeLeft));
                }

                if (node.TreeRight != null)
                {
                    list.AddRange(Preorder(node.TreeRight));
                }
            }

            return list;
        }

        private List<T> Postorder(BinaryTreeNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.TreeLeft != null)
                {
                    list.AddRange(Postorder(node.TreeLeft));
                }

                if (node.TreeRight != null)
                {
                    list.AddRange(Postorder(node.TreeRight));
                }

                list.Add(node.Data);
            }

            return list;
        }

        private List<T> Inorder(BinaryTreeNode<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.TreeLeft != null)
                {
                    list.AddRange(Inorder(node.TreeLeft));
                }

                list.Add(node.Data);

                if (node.TreeRight != null)
                {
                    list.AddRange(Inorder(node.TreeRight));
                }
            }

            return list;
        }
    }
}
