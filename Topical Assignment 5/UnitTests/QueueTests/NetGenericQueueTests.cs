using System;
using System.Collections.Generic; 
using NUnit.Framework;
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
        [TestCaseSource("QueeTestDate")]
        public void Quee_Sucess_Cass(int[] testDate)
        {
            var queue = new Queue<int>();
            for (var i = 0; i < testDate.Length; i++)
            {
                queue.Count.ShouldBe(i, "The Queue Count is Off");
                queue.Enqueue(testDate[i]);
                queue.Peek().ShouldBe(testDate[i], "The Recently pushed value is not peeking");
            }
            queue.Count.ShouldBe(testDate.Length, "The end count was not as expected");
            var counter = queue.Count;
            foreach (int value in queue)
            {
                counter--;
                value.ShouldBe(testDate[counter], "The enumeration is not accurate");
            }
            for (var item = testDate.Length - 1; item >= 0; item--)
            {
                var expected = testDate[item];
                queue.Peek().ShouldBe(expected, "The Peeked value was not expected");
                queue.Dequeue().ShouldBe(expected, "The dequeue was not expected");
                queue.Count.ShouldBe(item, "The dequeue value was not expected");
            }
        }

        [Test]
        public void Dequeue_From_Empty_Throws()
        {
            var queue = new Queue<int>();

            Should.Throw<InvalidOperationException>(() =>
            {
                var poppedValue = queue.Dequeue();
            });
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
                var dequeuedValue = queue.Peek();
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
