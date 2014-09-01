using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
 class BinarySearch
    {
     
        Node root = null;
        
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            
            
        }
        

        public void Insert(int Data)
        {
            Add(Data, ref root);
        }
        private void Add(int Data, ref Node temp)
        {
            if (temp == null)
            {
                
                temp=new Node();
                temp.data = Data;

            }
            else if (temp.data > Data)
            {
                Add(Data, ref temp.left);
            }
            else
            {
                Add(Data, ref temp.right);
            }
            

        }

     
        private void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.Write(Root.data + " ");
                Inorder(Root.right);
            }
        }
        public void Inorder()
        {
            Inorder(root);
        }

        public void Delete()
        {

        }

     }
}
