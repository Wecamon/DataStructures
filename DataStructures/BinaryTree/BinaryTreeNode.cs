using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    internal class BinaryTreeNode<T> : IComparable<T> where T : IComparable
    {
        public T Data { get; private set; }
        public BinaryTreeNode<T> TreeLeft { get; private set; }
        public BinaryTreeNode<T> TreeRight { get; private set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.Data = data;
            this.TreeRight = right;
            this.TreeRight = left;
        }

        public void Add(T data)
        {

            if (data.CompareTo(Data) == -1)
            {
                if (this.TreeLeft == null)
                {
                    var node = new BinaryTreeNode<T>(data);
                    this.TreeLeft = node;
                }
                else
                {
                    this.TreeLeft.Add(data);
                }
            }
            else
            {
                if (this.TreeRight == null)
                {
                    var node = new BinaryTreeNode<T>(data);
                    this.TreeRight = node;
                }
                else
                {
                    this.TreeRight.Add(data);
                }
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is BinaryTreeNode<T> item)
            {
                return this.Data.CompareTo(obj);
            }
            else
            {
                throw new ArgumentException("The value is not valid");
            }
        }

        public int CompareTo(T other)
        {
            return this.Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
