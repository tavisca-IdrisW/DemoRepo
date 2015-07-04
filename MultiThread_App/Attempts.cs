//ThreadStart ProducerThreadStart = new ThreadStart(new Producer().producerThread);
//ThreadStart ConsumerThreadStart = new ThreadStart(new Consumer().consumerThread);
//ThreadStart LoggerThreadStart = new ThreadStart(new Logger().LoggerThread);

//Thread[] testThread = new Thread[3];
//testThread[0] = new Thread(ProducerThreadStart);
//testThread[1] = new Thread(ConsumerThreadStart);
//testThread[2] = new Thread(LoggerThreadStart);

//foreach (Thread myThread in testThread)
//{
//    myThread.Start();
//}
//while (!(Console.ReadKey(true).Key == ConsoleKey.Enter))
//{
//    Task.Factory.StartNew(() => new Producer().producerThread())
//    .ContinueWith((prevTask) => new Consumer().consumerThread())
//    .ContinueWith((prevTask) => new Logger().LoggerThread());
//}

//Task.Factory.StartNew(new Consumer().consumerThread);
//Task.Factory.StartNew(new Logger().LoggerThread);
//if (Console.ReadKey(true).Key == ConsoleKey.Enter)
//{
//    Console.WriteLine("Thread Aborted!!!>>>>>>>>>>>>>>>>>");
//    testThread[0].Abort();
//    testThread[1].Abort();
//    testThread[2].Abort();
//}

//List<ManualResetEvent> doneEvents = new List<ManualResetEvent>();

//while (!(Console.ReadKey(true).Key == ConsoleKey.Enter))
//{
//    doneEvents[count] = new ManualResetEvent(false);
//    ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object state) { new Producer().producerThread(); }), null);
//}
//WaitHandle.WaitAll(doneEvents.ToArray());