using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BST
    {
        private TreeNode? Root;
        private InsertMethods Method;

        //types
        public enum TraversalOrder
        {
            PRE,
            IN,
            POST
        }

        public enum InsertMethods
        {
            RECURSIVE,
            ITERATIVE
        }

        public BST(InsertMethods method )
        {
            Root = null;
            Method = method;
        }

        private TreeNode InsertRecursive(int key, TreeNode root)
        {
            if (root == null)
            {
                root = new TreeNode(key);
                return root;
            }
            if (key < root.Key) 
            { 
                root.Left = InsertRecursive(key, root.Left);
          
            }
            if (key > root.Key)
            {
                root.Right = InsertRecursive(key, root.Right);
            }

            return root;

        }        

        private void InsertIterative(int key)
        {
            TreeNode? current = Root;
            TreeNode? parent = null;

            if (Root == null) 
            {
                Root = new TreeNode(key);
                return;
            }

            while(current != null)
            {
                if (key > current.Key)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (key < current.Key) 
                {
                    parent = current;
                    current = current.Left;
                }
                else
                {
                    return;
                }
            }
            if(key < parent.Key)
            {
                parent.Left = new TreeNode(key);
            }
            if(key > parent.Key)
            {
                parent.Right = new TreeNode(key);
            }
        }
        
        public void PrintInOrder(TreeNode root)
        {
            if(root != null)
            {
                PrintInOrder(root.Left);
                Console.WriteLine(root.Key);
                PrintInOrder(root.Right);
            }
        }

        public void PrintPreOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Key);
                PrintInOrder(root.Left);
                PrintInOrder(root.Right);
            }
        }
        public void PrintPostOrder(TreeNode root)
        {
            if (root != null)
            {
                PrintInOrder(root.Left);
                PrintInOrder(root.Right);
                Console.WriteLine(root.Key);
            }
        }
        

        public void Print(TraversalOrder order = TraversalOrder.IN)
        {
            switch (order) {
                case TraversalOrder.IN:
                    PrintInOrder(Root); break;
                case TraversalOrder.PRE:
                    PrintPreOrder(Root); break;
                case TraversalOrder.POST:
                    PrintPostOrder(Root); break;



            }
        }
     

        public void Insert(int key)
        {
            switch (Method)
            {
                case InsertMethods.RECURSIVE:
                    Root = InsertRecursive(key, Root); break;
                case InsertMethods.ITERATIVE:
                    InsertIterative(key);break;
            }
        }
    }

}
