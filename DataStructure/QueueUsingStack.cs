using System;
using System.Collections;

namespace DataStructure
{
    public class QueueUsingStack
    {
        readonly Stack stack1;
        readonly Stack stack2;
        public int Length { get; set; }

        public QueueUsingStack(int size)
        {
            stack1 = new Stack(size);
            stack2 = new Stack(size);
            Length = size;
        }
        public bool IsEmpty()
        {
            return (stack1.Count == 0 && stack2.Count == 0);
        }
        public void Enqueue(int item)
        {
            stack1.Push(item);
        }
        public int Dequeue()
        {
            if (IsEmpty())
                throw new ArgumentNullException();
            MoveStack1ToStack2();

            return (int)stack2.Pop();
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new ArgumentNullException();

            MoveStack1ToStack2();

            return (int)stack2.Peek();
        }

        private void MoveStack1ToStack2()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
        }
    }
}
