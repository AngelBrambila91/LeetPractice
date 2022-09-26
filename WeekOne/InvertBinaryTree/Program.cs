using System;
using static System.Console;
namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode left = new TreeNode(1);
            TreeNode right = new TreeNode(3);
            TreeNode root = new TreeNode(2, left, right);
            TreeNode left2 = new TreeNode(6);
            TreeNode right2 = new TreeNode(9);
            TreeNode root2 = new TreeNode(7, left2, right2);
            TreeNode root3 = new TreeNode(4, root, root2);
            TreeNode invert = InvertTree(root3);

            // TreeNode root4 = new TreeNode();
            // TreeNode invert = InvertTree(root);
        }

        public static TreeNode InvertTree (TreeNode root)
        {
            if(root == null)
            {
                return null;
            }
                TreeNode aux;
                aux = root.left;
                root.left = root.right;
                root.right = aux;
                InvertTree(root.left);
                InvertTree(root.right);
            return root;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode( int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}