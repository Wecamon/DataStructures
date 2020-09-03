using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>
    {
        private List<T> queue;
        public Queue()
        {
            queue = new List<T>();
        }
        public T Peek => queue[0];
        public int Count => queue.Count;
        public void EnQueue(T item) => queue.Add(item);
        public void DeQueue() => queue.RemoveAt(0);
        public void ClearQueue() => queue.Clear();
    }
}
