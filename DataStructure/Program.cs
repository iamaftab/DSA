using System;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            ArrayQueue myQ = new ArrayQueue(5);
            myQ.Enqueue(10);
            myQ.Enqueue(20);
            myQ.Dequeue();
            Console.WriteLine(myQ.ToString());
        }
    }
}
