using System;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            QueueUsingStack myQ = new QueueUsingStack(3);
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Enqueue(30);
            myQ.Dequeue();

            Console.WriteLine(myQ.Dequeue());

        }
    }
}
