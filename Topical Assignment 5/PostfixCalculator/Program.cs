using System;
using System.Collections.Generic;
using System.Diagnostics;

/*
 * Zahra Bodaghi
 */

namespace PostfixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("<< Zahra Bodaghi >>");
            Console.WriteLine("Assignment 4, Project 1");
            Console.WriteLine();

            // The stack of integers not yet operated on
            var values = new Stack<double>();

            foreach (string token in args)
            {
                if (double.TryParse(token, out double value)) // if the value is an integer...
                {
                    values.Push(value); // ... push it to the stack
                }
                else
                {
                    // otherwise evaluate the expresion...
                    var rightSideExpressionValue = values.Pop();
                    var leftSideExpressionValue = values.Pop();

                    switch (token) // ... and push the result back to the stack
                    {
                        case "+":
                            values.Push(leftSideExpressionValue + rightSideExpressionValue);
                            break;
                        case "*":
                            values.Push(leftSideExpressionValue * rightSideExpressionValue);
                            break;
                        case "/":
                            values.Push(leftSideExpressionValue / rightSideExpressionValue);
                            break;
                        case "-":
                            values.Push(leftSideExpressionValue - rightSideExpressionValue);
                            break;
                        case "^":
                            values.Push(Math.Pow(leftSideExpressionValue, rightSideExpressionValue));
                            break;
                        default:
                            throw new ArgumentException($"Unrecognized token: {token}");
                    }

                    Debug.WriteLine($"{leftSideExpressionValue}     {rightSideExpressionValue}     {values.Peek()}");

                }
            }

            // the last item on the stack is the result
            Console.WriteLine($"The final result is: {values.Pop()}");

            Console.WriteLine();
            Console.Write("Press a key to continue");
            Console.ReadKey();
        }
    }
}
