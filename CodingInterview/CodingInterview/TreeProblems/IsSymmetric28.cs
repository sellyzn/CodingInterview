using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TreeProblems
{
    public class IsSymmetric28
    {
        public bool isSymmetric(TreeNode root)
        {
            return root == null ? true : recur(root.left, root.right);
        }
        public bool recur(TreeNode l, TreeNode r)
        {
            if (l == null && r == null)
                return true;
            else if (l == null || r == null || l.val != r.val)
                return false;
            else return recur(l.left, r.right) && recur(l.right, r.left);
        }
    }
}
