using System;

namespace DataStructure
{
    public class QueueUsingArray
    {
        readonly int[] items;
        int rear, front, count;
        public int Length { get; set; }
        public QueueUsingArray(int size)
        {
            items = new int[size];
            Length = size;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public void Enqueue(int item)
        {
            if (count == items.Length)
                throw new ArgumentOutOfRangeException();

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }
        public int Dequeue()
        {
            if (count == 0)
                return 0;
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }
        public override string ToString()
        {
            string queueItems = "[ ";
            for (int i = 0; i < items.Length; i++)
            {
                //if (items[i] == 0)
                //    continue;
                queueItems += items[i] + " ";
            }
            queueItems += "]";
            if (queueItems == "[ ]")
                return "Queue is Empty";
            return queueItems;
        }
    }
}
