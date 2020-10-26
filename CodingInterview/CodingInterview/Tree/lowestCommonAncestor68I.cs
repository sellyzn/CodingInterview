﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class lowestCommonAncestor68I
    {
        public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while(root != null)
            {
                if (root.val < p.val && root.val < q.val)
                    root = root.right;
                else if (root.val > p.val && root.val > q.val)
                    root = root.left;
                else
                    break;
            }
            return root;
        }
    }
}
