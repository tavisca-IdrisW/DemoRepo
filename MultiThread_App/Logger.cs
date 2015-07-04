using System;

/// <summary>
/// This class is to Log the Even numbers on the console.
/// Named Logger due to the fact that it logs the ouput.
/// </summary>
namespace MultiThreadApp
{
    public class Logger
    {
        /**
         * This will work as a Logger.
         * This will check if the Generated Random Numbers and Even Number Queues are empty or not.
         * Chances are that this will work the slowest and EvenQueue may be fuller so we spwan new thread to Improve performance.
         */
        public void loggerTask()
        {
            //executing in thread

            Console.WriteLine("Thread 3 Executed ");
            int EvenVal;
            while (true)
            {
                if ((Program.EvenList.Count != 0) || (Program.BufferList.Count != 0))
                {
                    //foreach (int Num in Program.BufferList)
                    //{
                    //   // Console.WriteLine("Even: ", Num);
                    //   ConsumerList.Add(Num);
                    //}

                    //foreach (int Num in ConsumerList)
                    //{
                    //    Console.WriteLine("Even: ", Num);
                    //    //ConsumerList.Add(Num);
                    //}
                    //for (int i = Program.BufferList.Count - 1; i >= 0; i--)
                    //{
                    //  Console.WriteLine(Program.BufferList[i]);
                    //  Program.BufferList.Remove(Program.BufferList[i]);
                    //}
                    Program.EvenList.TryDequeue(out EvenVal);
                    Console.WriteLine("Even is {0}", EvenVal);

                    if (Program.EvenList.Count > 20)
                    {
                        ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Logger().loggerTask(); }), null);
                        //If The Even Number Queue's Is exceeding the limit i.e. working slow then we spawn new threads.
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