using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TreeProblems
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        private int? v;

        public TreeNode(int x)
        {
            val = x;
        }

        public TreeNode(int? v)
        {
            this.v = v;
        }
    }
}
