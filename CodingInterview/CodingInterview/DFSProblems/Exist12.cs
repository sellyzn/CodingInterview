using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DFSProblems
{
    public class Exist12
    {
        //剑指offer 12. 矩阵中的路径
        //DFS+剪枝
        /*
        典型的矩阵搜索问题

        1. 深度优先搜索： 可以理解为暴力法遍历矩阵中所有字符串可能性。
                        DFS 通过递归，先朝一个方向搜到底，再回溯至上个节点，沿另一个方向搜索，以此类推。
        
        2. 剪枝： 在搜索中，遇到 这条路不可能和目标字符串匹配成功 的情况
                （例如：此矩阵元素和目标字符不同、此元素已被访问），则应立即返回，称之为可行性剪枝 。

         */

        /*
        DFS 解析：
        1. 递归参数： 当前元素在矩阵 board 中的行列索引 i 和 j ，当前目标字符在 word 中的索引 k 。
        2. 终止条件：
            1)返回 falsefalse ： (1) 行或列索引越界 或 (2) 当前矩阵元素与目标字符不同 或 (3) 当前矩阵元素已访问过 （ (3) 可合并至 (2) ） 。
            2)返回 truetrue ： k = len(word) - 1 ，即字符串 word 已全部匹配。
        3. 递推工作：
           1) 标记当前矩阵元素： 将 board[i][j] 修改为 空字符 '' ，代表此元素已访问过，防止之后搜索时重复访问。
           2)搜索下一单元格： 朝当前元素的 上、下、左、右 四个方向开启下层递归，使用 或 连接 （代表只需找到一条可行路径就直接返回，不再做后续 DFS ），并记录结果至 res 。
           3)还原当前矩阵元素： 将 board[i][j] 元素还原至初始值，即 word[k] 。
        4. 返回值： 返回布尔量 res ，代表是否搜索到目标字符串。

         */


        public bool Exist(char[][] board, string word)
        {
            char[] words = word.ToCharArray();
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[0].Length; j++)
                {
                    if (DFS(board, word, i, j, 0))
                        return true;
                }
            }
            return false;
        }
        public bool DFS(char[][] board, string word, int i, int j, int k)
        {
            if (i >= board.Length || i < 0 || j >= board[0].Length || j < 0 || board[i][j] != word[k])
                return false;
            if (k == word.Length - 1)
                return true;
            //char temp = board[i][j];
            board[i][j] = '\0';
            bool res = DFS(board, word, i + 1, j, k + 1) || DFS(board, word, i - 1, j, k + 1)
                        || DFS(board, word, i, j + 1, k + 1) || DFS(board, word, i, j - 1, k + 1);
            board[i][j] = word[k];
            return res;
            //int[] dx = new int[] { -1, 0, 1, 0 };
            //int[] dy = new int[] { 0, 1, 0, -1 };
            //for(int q = 0; q < 4; q++)
            //{
            //    int m = i + dx[q], n = j + dy[q];
            //    if (DFS(board, word, m, n, k + 1))
            //        return true;
            //}
            //board[i][j] = temp;
            //return false;
        }
    }
}
