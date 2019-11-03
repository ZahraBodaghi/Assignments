using System;
using System.Collections.Generic;

/*
 * Zahra Bodaghi
 */

namespace CustomStack
{
    public class Stack<T>:LinkedList<T>
    {


        public void Push(T newValue)
        {
           
         AddFirst(newValue);
        }

        public T Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException();
            }
            var temp =  First.Value;
            RemoveFirst();
            return temp;

        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            var temp = First.Value; 
            return temp;

        }

    }
}
