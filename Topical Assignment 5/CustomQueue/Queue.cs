using System;
using System.Collections.Generic;

/*
 * Zahra Bodaghi
 */
namespace CustomQueue
{
    public class Queue<T>: LinkedList<T>
    {
        public void Enqueue(T newValue)
        {
            
            AddFirst(newValue);
        }

        public T Dequeue()
        {
            
            return Dequeue();

        }

        public T Peek()
        {
            
            return Peek();

        }
    }
}
