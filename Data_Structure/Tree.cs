using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Tree
    {
        public int data;
        public Tree left = null;
        public Tree right = null;

        public Tree(int data)
        {
            this.data = data;
        }

        public static int SumOfTrees(Tree root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return root.data + SumOfTrees(root.left) + SumOfTrees(root.right);
            }
        }
    }
}
