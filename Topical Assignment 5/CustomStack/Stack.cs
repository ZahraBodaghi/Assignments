using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class Stack<T>:LinkedList<T>
    {
        // note: the Count method is implemented in the LinkedList class and must not be replicated here

        public void Push(T newValue)
        {
            throw new NotImplementedException(); // replace this with an implementation
        }

        public T Pop()
        {
            throw new NotImplementedException(); // replace this with an implementation
        }

        public T Peek()
        {
            throw new NotImplementedException(); // replace this with an implementation
        }

    }
}
