using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class LeverOrder32III
    {
        //public IList<IList<int>> levelOrder(TreeNode root)
        //{
        //    var queue = new Queue<TreeNode>();
        //    var res = new List<LinkedList<int>>();
        //    if (root != null)
        //        queue.Enqueue(root);
        //    while (queue != null)
        //    {
        //        var subList = new LinkedList<int>();
        //        for (var i = queue.Count; i > 0; i--)
        //        {
        //            var node = queue.Dequeue();
        //            if (res.Count % 2 == 0)
        //                subList.AddLast(node.val);
        //            else
        //                subList.AddFirst(node.val);
        //            if (node.left != null)
        //                queue.Enqueue(node.left);
        //            if (node.right != null)
        //                queue.Enqueue(node.right);
        //        }
        //        res.Add(subList);
        //    }

        //    return res;
        //}

        public void Test()
        {
            var array = new int?[] { 3, 9, 20, null, null, 15, 7 };

            var root = new TreeNode(array[0]);
            Recursion(root,array,0);

            var list = LevelOrder(root);
            for(var i = 0; i < list.Count; i++)
            {
                foreach(var num in list[i])
                {
                    Console.WriteLine(num);
                }
            }

        }
        public void Recursion(TreeNode root, int?[] arr, int index)
        {
            if (2 * index + 1 < arr.Length)
            {
                if(arr[2 * index + 1] != null)
                {
                    root.left = new TreeNode(arr[2 * index + 1]);
                    Recursion(root.left, arr, 2 * index + 1);
                }
            }
            if (2 * index + 2 < arr.Length)
            {
                if(arr[2 * index + 2] != null)
                {
                    root.right = new TreeNode(arr[2 * index + 2]);
                    Recursion(root.right, arr, 2 * index + 2);
                }
            }
            return;
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            var queue = new Queue<TreeNode>();            
            var level = 0;
            if (root != null)
                queue.Enqueue(root);
            while(queue.Count > 0)
            {
                var subList = new List<int>();               
                var len = queue.Count;
                while (len-- > 0)
                {
                    var node = queue.Dequeue();                    
                    subList.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    
                }

                if (level % 2 == 0)
                {
                    res.Add(subList);
                }
                else
                {
                    var stack = new Stack<int>();
                    var subListOdd = new List<int>();
                    foreach(var item in subList)
                    {
                        stack.Push(item);
                    }
                    while(stack.Count > 0)
                    {
                        subListOdd.Add(stack.Pop());
                    }
                    res.Add(subListOdd);
                }   
                
                level++;
            }

            return res;
        }
    }
}
