using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T> : ILinkable
    {
        protected class ListNode<T>
        {

            public T Value { get; set; }
            public ListNode<T> Next { get; set; }
            public ListNode(T value)
            {
                this.Value = value;
                Next = null;

            }
        }

        protected ListNode<T> head;
        public LinkedList()
        {

        }
        public LinkedList(T initialValue)
        {
            head = new ListNode<T>(initialValue);
        }
        public virtual void Add(T value)
        {
            if (head == null)
            {
                head = new ListNode<T>(value);
                return;
            }
            var temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = new ListNode<T>(value);
        }
        public T getValue(int position)
        {
            if (position < 0)
                throw new IndexOutOfRangeException();
            else if (position == 0)
            {
                return head.Value;
            }
            ListNode<T> temp = head;
            while (temp.Next != null && position > 0) 
            {
                temp = temp.Next;
                position--;
            }
            if (position > 0)
                throw new IndexOutOfRangeException();
            return temp.Value;
        }
        public void removeAt(int position)
        {
            if (position < 0)
                throw new IndexOutOfRangeException();
            else if (position == 0)
            {
                head = head.Next;
                return;
            }
            var temp = head;
            while (temp.Next != null && position > 1)
            {
                temp = temp.Next;
                position--;
            }
            if (position > 1)
                throw new IndexOutOfRangeException();
            temp.Next = temp.Next.Next;
        }
        //internal ListNode<T> getNode(object list, T value)
        //{
        //    if (list.GetType() == typeof(DoublyLinkedList<T>))
        //    {
        //        return DoublyLinkedList<T>.createNode(value);
        //    }
        //    else
        //        return new ListNode<T>(value);
        //}
    }
    
}
