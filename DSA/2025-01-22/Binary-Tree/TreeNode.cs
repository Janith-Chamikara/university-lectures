using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class TreeNode
    {
        public int Key;
        public TreeNode? Left;
        public TreeNode? Right;

        public TreeNode(int key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }

}
