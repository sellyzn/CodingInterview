using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Stack
{
    public class MinStack30
    {
        //栈A存放的是需要压栈的值
        private Stack<int> stackA;
        //栈B存放的是最小值
        private Stack<int> stackB;
        
        public MinStack30()
        {
            stackA = new Stack<int>();
            stackB = new Stack<int>();
        }

        public void push(int x)
        {
            stackA.Push(x);
            if (stackB.Count == 0 || x < min())
                stackB.Push(x);
        }

        public void pop()
        {
            //如果出栈的值等于最小值，说明栈中的最小值
            //已经出栈了，因为stackB中的栈顶元素存放的
            //就是最小值，所以stack栈B顶元素也要出栈
            if (stackA.Pop() == min())
                stackB.Pop();
        }

        public int top()
        {
            return stackA.Peek();
        }

        public int min()
        {
            return stackB.Peek();
        }
    }
}
