using System;
using System.Diagnostics;
using NodeNameSpace;

namespace NodeChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(value:"Zahra Bodaghi");

            Debug.WriteLine(message: "first...");
            // +-----+------+
            // |  3  | null +
            // +-----+------+
            var first = CreateNewNodeChainElement(value: 0, refrenceToPreviousNode: null);
            Debug.WriteLine(message: $"node #1: Value= {first.Value} Next Node={first.Next}");

            Debug.WriteLine("middle...");

            // +-----+------+    +-----+------+
            // |  3  | null +    |  5  | null +
            // +-----+------+    +-----+------+
            var middle = CreateNewNodeChainElement(value: 5, refrenceToPreviousNode: first);
            Debug.WriteLine(message: $"node #2: Value={middle.Value} Next Node={middle.Next}");

            // +-----+------+    +-----+------+
            // |  3  |  *---+--->|  5  | null +
            // +-----+------+    +-----+------+
            first.Next = middle;
            Debug.WriteLine(message: $"Node #3: Value={first.Value} Next Node={first.Next} Next Node Value={first.Next.Value}");

            Debug.WriteLine(message: "last...");
            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  | null +   |  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            var last = CreateNewNodeChainElement(value: 7, refrenceToPreviousNode: middle);

            Debug.WriteLine(message: $"Node #4 Value={first.Value} Next Node={first.Next} Next Node Value={first.Next.Value} Next Node Value={first.Next.Value}");

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            middle.Next = last;

            // now iterate over each node and print the value
            PrintList(first);
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        private static Node CreateNewNodeChainElement(int value, Node refrenceToPreviousNode)
        {
            var newNode = new Node();
            newNode.Value = value;
            newNode.Next = refrenceToPreviousNode;


            
            return newNode;
        }
    }
}
