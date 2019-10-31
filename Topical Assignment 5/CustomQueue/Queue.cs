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
            /*
             * ProfReynolds2
             * see my comments in the CustomStack
             */
            var example = new Queue<T>();
            example.Enqueue(newValue);
        }

        public T Dequeue()
        {
            var example = new Queue<T>();
            return example.Dequeue();

        }

        public T Peek()
        {
            var example = new Queue<T>();
            return example.Peek();

        }
    }
}
