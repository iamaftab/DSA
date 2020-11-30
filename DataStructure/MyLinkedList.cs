using System;

namespace DataStructure
{

    public class MyLinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node first;
        private Node last;
        private int size;

        //isEmpty
        private bool IsEmpty()
        {
            return first == null;

        }

        //addLast
        public void AddLast(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++;
        }
        //addFirst
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            size++;
        }
        //indexOf
        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }
        //contains
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }
        //removeFirst
        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new Exception("List is empty.");

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }
            size--;
        }
        //removeLast
        public void RemoveLast()
        {
            if (IsEmpty())
                throw new Exception("List is empty.");

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }

            size--;
        }
        //getPrevious
        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node)
                    return current;
                current = current.next;
            }
            return null;
        }
        //size
        public int Size()
        {
            return size;
        }
        //ToArray
        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }
        //Reverse 
        public void Reverse()
        {
            if (IsEmpty()) return;

            var previous = first;
            var current = first.next;

            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            last = first;
            last.next = null;
            first = previous;
        }
    }
}
