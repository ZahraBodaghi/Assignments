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
