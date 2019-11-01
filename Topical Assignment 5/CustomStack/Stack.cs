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
           /*
            * ProfReynolds3
            * The LinkedList is not a stack so Pop does not work here.
            *
            * This about the process of Pop:
            * 1. check for collection Count == 0. If so,
            *           throw new InvalidOperationException();
            * 2. get the First.Value into a temp / holding variable
            * 3. RemoveFirst()
            * 4. return the temp / holding value
            */
            return Pop();

        }

        public T Peek()
        {
            /*
             * ProfReynolds3
             * see comments above
             */

            return Peek();
            
        }

    }
}
