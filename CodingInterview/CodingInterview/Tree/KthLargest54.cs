using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class KthLargest54
    {
        int res;
        int k;
        public int kthLargest(TreeNode root, int k)
        {
            this.k = k;
            dfs(root);
            return res;
        }
        public void dfs(TreeNode root)
        {
            if (root == null)
                return;
            dfs(root.right);
            if (k == 0)
                return;
            //if(k - 1 == 0)
            //{
            //    res = root.val;
            //    k--;
            //}
            //if(k - 1 == 0)
            //{
            //    res = root.val;
            //    return;
            //}
            if (--k == 0)
                res = root.val;
            dfs(root.left);
        }

        public int kthLargest1(TreeNode root, int k)
        {
            dfs1(root, k);
            return res;
        }
        public void dfs1(TreeNode root, int k)
        {
            if (root == null)
                return;
            dfs1(root.right, k);
            if (k == 0)
                return;
            if (k - 1 == 0)
            {
                res = root.val;
                k--;
            }
            dfs1(root.left, k);
        }
    }
}
