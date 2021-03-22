using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.BackTrackingProblems
{
    public class Permutation38
    {
        //LinkedList<string> res = new LinkedList<string>();   //为了让递归函数添加结果方便，定义到函数之外，这样无需带到递归函数的参数列表中
        //char[] c;  //同
        //public string[] permutation(string s)
        //{
        //    c = s.ToCharArray();
        //    dfs(0);  //从第一层开始递归
        //    return res.ToArray(new string[res.Count]);  //将字符串数组转化为string类型数组
        //}
        //private void dfs(int x)
        //{
        //    if (x == c.Length - 1)
        //    {
        //        res.Add(c.ToString);  //将字符数组转化为字符串,添加排列方案
        //        return;
        //    }
        //    var set = new HashSet<char>();  //为了防止同一层递归出现重复元素

        //    //第一层可以是a,b,c，那么有三种情况，这里i=x, dfs(0)正好是i=0开始
        //    //当第二层只有两种情况，dfs(1)， i=1开始
        //    for (var i = x; i < c.Length; i++)
        //    {
        //        if (set.Contains(c[i]))  //包含这个元素时，重复，因此剪枝
        //            continue;
        //        set.Add(c[i]);
        //        swap(i, x);  //交换元素，将c[i]固定在第x位。
        //        dfs(x + 1);  //开启固定第x+1位字符
        //        swap(i, x);  //恢复交换
        //    }
        //}
        //private void swap(int a, int b)
        //{
        //    var temp = c[a];
        //    c[a] = c[b];
        //    c[b] = temp;
        //}

        public List<string> res = new List<string>();
        //List<List<string>> res = new List<List<string>>();
        public string[] Permutation(string s)
        {
            //记录路径
            LinkedList<char> track = new LinkedList<char>();
            
            Backtrack(s, track);
            return res.ToArray();
        }
        //路径：记录在track中
        //选择列表：s中不存在于track的那些元素
        //结束条件：s中的全部元素都在track中出现
        public void Backtrack(string s, LinkedList<char> track)
        {
            //触发结束条件
            if (track.Count == s.Length)
            {
                string tmp = "";
                for(int i = 0; i < track.Count; i++)
                {
                    tmp += s[i];
                }
                res.Add(tmp);
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                //排除不合法的选择
                if (track.Contains(s[i]))
                    continue;
                //做选择
                track.AddLast(s[i]);
                //进入下一层决策树
                Backtrack(s, track);
                //取消选择
                track.RemoveLast();
            }
        }

    }
}
