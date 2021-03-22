using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.StackProblems
{
    public class ValidateStackSequences31
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> s = new Stack<int>();
            int i = 0;
            foreach(int num in pushed)
            {
                s.Push(num);
                while(s.Count != 0 && s.Peek() == popped[i])
                {
                    s.Pop();
                    i++;
                }
            }
            //for(int i = 0, j = 0; i < pushed.Length; i++)
            //{
            //    s.Push(pushed[i]);
            //    if(s.Count != 0 && s.Peek() == popped[j])   //if换成while
            //    {
            //        s.Pop();
            //        j++;
            //    }
            //}
            return s.Count == 0;
        }
    }
}
