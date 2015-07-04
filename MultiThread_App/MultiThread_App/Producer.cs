using System;
using System.Threading;

/// <summary>
/// This class is to Generate Random Numbers. 
/// Named Producer due to its fuction.
/// </summary>
namespace MultiThreadApp
{
    public class Producer
    {
        /**
         * This is working as a Producer Thread. 
         * This will generate Random Numbers between 1 to 10000. 
         */
        public void producerTask()
        {
            //executing in thread
            //Console.WriteLine("Thread {0} Executed ", ThreadContext);

            Console.WriteLine("Thread 1 Executed ");
            Random rand = new Random();
            while (true)
            {
                //Thread.Sleep(1000);
                MainClass.BufferList.Enqueue(rand.Next(1, 10000));

            }
        }
    }

}
