using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList2
    {
        private Node Head;
        public void add(string data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.next = Head ;
            Head = temp;
            
        }

        public void delete(string data)
        {
            Node prev = Head;
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                {
                    if (temp == Head)
                    {
                        Head = Head.next;
                        temp = null;
                    }
                    else
                    {
                        prev.next = temp.next;
                        temp = null;
                    }
                }
                else
                {
                    prev = temp;
                    temp = temp.next;
                }
            }
          // scan through list one by one
            // compare delete value with current item value .Equals(string)
            // if they match, delete this node: set the previous node's next ref to the delete node's next ref, return
            // prev = temp
            // go to temp next
            
        }

        public void print()
        {
            
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.next;
            }
        
        }
    }
}
