using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BinarySearch
    {
        private class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data)
            {
                this.data = data;

            }

        }
        private Node root;

        public void deleteNode(int data)
        {
            deleteNode(ref root, data);
        }


        private void deleteNode(ref Node curr, int data)
        {
            if (curr == null)
            {
                return;
            }

            if (curr.data == data)
            {
                if (curr.left == null && curr.right == null)
                {
                    curr = null;
                    return;
                }
                if (curr.left == null && curr.right != null)
                {
                    curr = curr.right;
                    return;
                }
                if (curr.left != null && curr.right == null)
                {
                    curr = curr.left;
                    return;
                }

                if (curr.left != null && curr.right != null)
                {
                    Node temp = curr.left;
                    while (temp.right != null)
                    {
                        temp = temp.right;
                    }
                    curr.data = temp.data;
                    return;
                }

            }

            else
            {

                if (curr.data > data)
                {
                    deleteNode(ref curr.left, data);
                }
                if (curr.data < data)
                {
                    deleteNode(ref curr.right, data);
                }
            }
        }



        public void Insert(int data)
        {
            Insert(ref root, new Node(data));

        }

        private void Insert(ref Node curr, Node newNode)
        {
            if (curr == null)
            {
                curr = newNode;
            }

            if (newNode.data < curr.data)
            {
                Insert(ref curr.left, newNode);
            }

            if (newNode.data > curr.data)
            {
                Insert(ref curr.right, newNode);
            }


        }

        public void printNode()
        {
            printNode(root);
        }


        private void printNode(Node node)
        {

            if (node == null) return;
            printNode(node.left);
            System.Console.WriteLine(node.data);
            printNode(node.right);
              
        }
     
    }

    }
  
