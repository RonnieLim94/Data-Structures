using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(1);
            Tree tree2 = new Tree(2);
            Tree tree3 = new Tree(3);
            Tree tree4 = new Tree(4);
            tree.left = tree2;
            tree.right = tree3;
            tree.left.left = tree4;
            Console.WriteLine($"Sum: {Tree.SumOfTrees(tree)}");
            Console.WriteLine(tree2.left.data.ToString());
            Console.ReadLine();
        }
    }
}
