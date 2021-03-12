using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TreeProblems
{
    public class PathSum34
    {
        List<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        //public IList<IList<int>> pathSum(TreeNode root, int sum)
        //{
        //    recur(root, sum);
        //    return res;
        //}
        //private void recur(TreeNode root, int tar)
        //{
        //    if (root == null)
        //        return;
        //    path.Add(root.val);
        //    tar -= root.val;
        //    if (tar == 0 && root.left == null && root.left == null)
        //        res.Add(new List<int>(path));
        //    recur(root.left, tar);
        //    recur(root.right, tar);
        //    path.RemoveAt();
        //}
    }
}
