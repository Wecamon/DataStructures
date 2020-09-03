using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoublyLinkedList<T> : LinkedList<T>, ILinkable
    {
        protected class DoublyNode<T> : ListNode<T>
        {
            public DoublyNode<T> Previous { get; set; }
            public DoublyNode(T value) : base(value)
            {
            
            }
        }

        public DoublyLinkedList(T initialValue)
        {
            head = new DoublyNode<T>(initialValue);
        }
        public DoublyLinkedList()
        {

        }
        public virtual void Add(T value)
        {
            if (head == null)
            {
                head = new DoublyNode<T>(value);
                return;
            }
            DoublyNode<T> temp = (DoublyNode<T>)head;
            while (temp.Next != null)
            {
                temp = (DoublyNode<T>)temp.Next;
            }
            temp.Next = new DoublyNode<T>(value);
            DoublyNode<T> temp2 = temp;
            temp = (DoublyNode<T>)temp.Next;
            temp.Previous = temp2;
        }
    }
}
