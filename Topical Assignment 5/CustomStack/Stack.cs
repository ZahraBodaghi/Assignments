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
           
            return Pop();

        }

        public T Peek()
        {
            return Peek();
            
        }

    }
}
