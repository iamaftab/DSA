using System;

namespace DataStructure
{
    public class MyStack
    {
        private readonly int[] items = new int[5];
        private int count;

        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Push(int item)
        {
            if (count == items.Length)
                throw new IndexOutOfRangeException();

            items[count++] = item;
        }
        public int Pop()
        {
            if (count == 0)
                throw new ArgumentNullException();
            var pop = items[--count];
            items[count] = 0;
            return pop;

        }
        public int Peek()
        {
            if (count == 0)
                throw new ArgumentNullException();
            return items[count - 1];
        }

        public override string ToString()
        {
            string stackItems = "[ ";
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == 0)
                    continue;
                stackItems += items[i] + " ";
            }
            stackItems += "]";

            return stackItems;
        }
    }
}
