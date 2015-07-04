using System;

/// <summary>
/// This class is to Check Teh Random Numbers.
/// It will filter out the Even Numbers and populate the EvenQueue.
/// Named Consumer due to the fact that it takes inputs from Producer.
/// </summary>
namespace MultiThreadApp
{
    public class Consumer
    {
        /**
         * This will work as a Consumer.
         * This will check if the Generated Random Numbers are Even and add it to an Even Queue.
         * Furthermore, if we find the Random numbers Queue to be empty then Thread will Pause execution and
         * give other threads more time to execute.
         * Chances are that this will work the slower and RandomQueue may be fuller so we spwan new thread to Improve performance.
         */
        public void consumerTask()
        {
            int CheckVal;
            //executing in thread

            Console.WriteLine("Thread 2 Executed ");

            while (true)
            {
                if (!(Program.BufferList.Count == 0))
                {
                    Program.BufferList.TryDequeue(out CheckVal);
                    if (CheckVal % 2 == 0)
                    {
                        Program.EvenList.Enqueue(CheckVal);
                    }
                    if (Program.EvenList.Count > 20)
                    {
                        ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Consumer().consumerTask(); }), null);
                        //If The Random Number Queue's Is exceeding the limit i.e. working slow then we spawn new threads.
                    }
                }
                else
                {
                    Thread.Yield();
                }
            }
        }
    }
}

