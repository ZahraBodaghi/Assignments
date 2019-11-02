using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Shouldly;

/*
 * Zahra Bodaghi
 */
namespace UnitTests.QueueTests
{
    public class NetGenericQueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static readonly int[][] QueueTestData = new[]
        {
            new int[0],
            new [] { 0 },
            new [] { 0, 1 },
            new [] { 0, 1, 2 },
            new [] { 0, 1, 2, 3 },
            new [] { 0, 1, 2, 3, 4 },
            new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
        };

        [Test]
        [TestCaseSource("QueueTestData")]
        public void Queue_Success_Cases(int[] testData)
        {
            var queue = new Queue<int>();


            for (var i = 0; i < testData.Length; i++)
            {
                queue.Count.ShouldBe(i, "The stack count is off");

                queue.Enqueue(testData[i]);

                queue.Count.ShouldBe(i + 1, "The Queue count is off");

                queue.Peek().ShouldBe(testData[0], "The recently pushed value is not peeking");
            }

            queue.Count.ShouldBe(testData.Length, "The end count was not as expected");

            /*
             * ProfReynolds4
             * This appears to have been copied without thought.
             * the Queue is loaded first to last and therefore the counter must
             * begin at 0. Think about what happened here - you started the counter
             * high, and then kept incrementing
             */
            var counter = queue.Count;
            foreach (int value in queue)
            {

                value.ShouldBe(testData[counter], "The enumeration is not accurate");
                counter++;
            }

            /*
             * ProfReynolds4
             * you forgot to initialize the counter.
             * since your queue begins loaded and then is depleated,
             * you should start at the ququq count and decrement.
             * may i suggest you change the counter to expectedQueueSize
             * AND, the final shouldbe should be looking at the expectedQueueSize, not the item
             */
            for (var item = 0; item < testData.Length; item++)
            {
                var expected = testData[item];
                queue.Peek().ShouldBe(expected, "The peeked value was not expected");
                queue.Dequeue().ShouldBe(expected, "The Dequeued value was not expected");
                counter--;
                queue.Count.ShouldBe(item, "The popped value was not expected");
            }
        }

        [Test]
        public void Dequeue_From_Empty_Throws()
        {
            var queue = new Queue<int>();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeueValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Dequeue_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var poppedValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws()
        {
            var queue = new Queue<int>();
            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeueValue = queue.Peek();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Peek();
            }
            );
        }
    }
}
