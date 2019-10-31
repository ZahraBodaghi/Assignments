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
            /*
             * ProfReynolds2
             * The LinkedList inherited class contains, internal to it
             * a collection (check back to last week ~p98)
             * do not create as new stack here
             * instead, replace example.AddFirst with AddFirst
             * (make similar changes to Pop and Peek)
             */
            var example = new Stack<T>();
            example.AddFirst(newValue);
        }

        public T Pop()
        {
            var example = new Stack<T>();
            return example.Pop();

        }

        public T Peek() 
        {
            var example = new Stack<T>();
            return example.Peek();
            
        }

    }
}
