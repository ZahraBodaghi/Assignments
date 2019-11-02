using System;
using System.Collections.Generic; // ProfReynolds - I made a change here
using NUnit.Framework;
using Shouldly;

/*
*Zahra Bodaghi
 */
namespace UnitTests.QueueTests
{
    public class EmployeeQueueTests
    {
        private static readonly string[][] EmployeeQueueTestData = new[]
        {
            new string[]
            {
            "Fred Flintstone",
            "Wilma Flintstone",
            "Barney Rubble",
            "Fred Mertz",
            "Ethel Mertz",
            "Fred Astair",
            "Ginger Rogers",
            "Fred Savage",
            "Winnie Cooper"
            }
        };
        [Test]

        [TestCaseSource("QueueTestData")]
        public void Queue_Success_Cases(string[] testData) 
        {
            var queue = new Queue<string>();

            for (var i = 0; i < testData.Length; i++) 
            {
                queue.Count.ShouldBe(i, "The queue count is off");

                queue.Enqueue(testData[i]);

                queue.Count.ShouldBe(i + 1, "The queue count is off");

                queue.Peek().ShouldBe(testData[0], "The first Enqueueed value is not peeking");

            }

            queue.Count.ShouldBe(testData.Length, "The end count was not as expected");
            var counter = 0; 
            foreach (string value in queue)
            {
                value.ShouldBe(testData[counter], "The enumeration is not accurate");
                counter++;
            }
            counter = queue.Count;
            for (var item = 0; item < testData.Length; item++)
            {
                var expected = testData[item];
                queue.Peek().ShouldBe(expected, "The peeked value was not expected");
                queue.Dequeue().ShouldBe(expected, "The Dequeued value was not expected");
                counter--;
                queue.Count.ShouldBe(counter, "The Dequeued value was not expected");
            }
        }

        [Test]
        public void Dequeue_From_Empty_Throws()
        {
            var queue = new Queue<string>();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Dequeue_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue<string>();

            queue.Enqueue("Wilma Flintstone");
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws()
        {
            var queue = new Queue<string>();
            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Peek();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue<string>();

            queue.Enqueue("Wilma Flintstone");
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Peek();
            }
            );
        }
    }
}

