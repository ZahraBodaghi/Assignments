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
            /*
             * ProfReynolds4
             * Since we are 'pushing' onto the first of the stack, we have to wrap our heads around
             * the inverted logic. Peek should be looking at the stack value which will is the next
             * Pop. So the First Value is needed
             */
            var temp = Last.Value; 
            return temp;

        }

    }
}
