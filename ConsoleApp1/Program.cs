using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class TreeNode
    {
        public int Number { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count(null));
        }

        
       
        //This function will return the number of nodes in a tree
        public static int Count(TreeNode root)
        {
            //Base case, there is no node so return 0
            if (root == null) return 0;
            //Else there is a node so we count it and both its left and right subtrees.
            return 1 + Count(root.Left) + Count(root.Right);
        }

        //Another count function that returns the numbers of nodes in the tree
        public static int CountNodes(TreeNode root)
        {
            return root == null ? 0 : 1 + Count(root.Left) + Count(root.Right);
        }


        /****************************************************
          These functions were written during the interview
        ****************************************************/
        public double Area(double radius)
        {
            //Check that input is valid
            if (radius > 0)
                return Math.PI * radius * radius;
            //If the input is invalid return -1, I could also throw an exception here depending oh how we wanted to handle this
            return -1;
        }


        //Function that was written during interview
        /*public static int Count(TreeNode root)
        {
            int i, j;
            if (root == null)
                return 0;
            else
            {
                i = Count(root.Left);
                j= Count(root.Right);
               
            }
            return i+j+1;

        }
        */

    }
}
