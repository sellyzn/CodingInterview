using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.QueueProblems
{
    public class MaxQueue59II
    {
        public LinkedList<int> queue;
        public LinkedList<int> deque;
        public MaxQueue59II()
        {
            queue = new LinkedList<int>();
            deque = new LinkedList<int>();
        }

        public int Max_Value()
        {
            if (deque == null || deque.Count == 0)
                return -1;
            return deque.First.Value;
        }

        public void Push_back(int value)
        {
            queue.AddLast(value);
            while(deque.Count != 0 && value > deque.Last.Value)
            {
                deque.RemoveLast();
            }
            deque.AddLast(value);
        }

        public int Pop_front()
        {
            if (queue == null || queue.Count == 0)
                return -1;
            int first = queue.First.Value;
            if (first == deque.First.Value)
                deque.RemoveFirst();
            queue.RemoveFirst();
            return first;
        }
    }
}
