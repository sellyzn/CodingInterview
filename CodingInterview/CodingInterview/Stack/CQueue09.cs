using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Stack
{
    public class CQueue09
    {
        private Stack<int> stackIn;
        private Stack<int> stackOut;
        
        public CQueue09()
        {
            stackIn = new Stack<int>();
            stackOut = new Stack<int>();
        }
        
        public void appendTail(int value)
        {
            stackIn.Push(value);
        }

        public int deleteHead()
        {
            //if(stackIn.Count == 0)
            //{
            //    while(stackIn.Count!= 0)
            //    {
            //        stackOut.Push(stackIn.Pop());
            //    }
            //}
            //if(stackOut.Count == 0)
            //{
            //    return -1;
            //}
            //else
            //{
            //    var deleteItem = stackOut.Pop();
            //    return deleteItem;
            //}

            if(stackOut.Count != 0)
            {
                return stackOut.Pop();
            }
            else
            {
                while(stackIn.Count != 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
                return stackOut.Count == 0 ? -1 : stackOut.Pop();
            }
        }
    }
}
