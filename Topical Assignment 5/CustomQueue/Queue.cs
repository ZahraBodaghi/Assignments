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
            
            AddLast(newValue); // EnQueue added to the end.
        }
        // queue is an ordered collection of items where the addition of new items happens at one end, called the “rear,” 
        //and the removal of existing items occurs at the other end, commonly called the “front.”
        public T Dequeue()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            var temp = First.Value;
            RemoveFirst();
            return temp;
            // Dequeue is removing the first in queue.
        }

        public T Peek()
        {
            //Peek in Queue returned the First Item.
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            var temp = First.Value;
            return temp;

        }
    }
}
