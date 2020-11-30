using System;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            MyLinkedList mylist = new MyLinkedList();
            mylist.AddFirst(90);
            mylist.AddLast(10);
            mylist.AddFirst(30);

            mylist.Reverse();

            foreach (var item in mylist.ToArray())
            {
                Console.WriteLine(item);
            }

            MyStack mystack = new MyStack();
            mystack.Push(52);

            Console.WriteLine(mystack.IsEmpty());
        }
    }
}
