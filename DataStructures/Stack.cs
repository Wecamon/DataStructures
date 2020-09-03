using System;
using System.Collections.Generic;


namespace DataStructures
{
    public class Stack<T>
    {
        private static int STACK_MAX_SIZE = 255;
        private int tos = -1;
        private List<T> stack;
        public Stack()
        {
            stack = new List<T>(STACK_MAX_SIZE);
        }
        public int Count => stack.Count;
        public void Push(T item)
        {
            stack.Add(item);
            tos++;
        }
        public T Pop()
        {
            tos--;
            return stack[tos + 1]; 
        }
    }
}
