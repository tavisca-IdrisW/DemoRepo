using System;
using System.Collections.Concurrent;
using System.Threading;

namespace MultiThreadApp
{
    public class MainClass
    {
        public static ConcurrentQueue<int> BufferList = new ConcurrentQueue<int>();
        public static ConcurrentQueue<int> EvenList = new ConcurrentQueue<int>();

        public static void Main(string[] args)
        {

            /**
             * Using ThreadPool here to improve performance.
             * Had the option of using Lambda Notation but prefered to choose delegate for performance.
             * The above statement could be wrong!! Please Correct if it is indeed wrong.
             */

                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Producer().producerTask(); }), null);
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Consumer().consumerTask(); }), null);
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Logger().loggerTask(); }), null);


                while (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Press Any Key to Exit................");
                    Environment.Exit(0);
                }
                Console.Read();
        }
    }

}