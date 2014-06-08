using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caluclator_1
{
   public  class Node
    {
        public Node next;
        public object Data;

        public Node(object data, Node next)
        {
            this.Data=Data;
            this.next = next;
        }
        public object data
        {
            get{return this.Data;}
            set { this.Data = value; }
        }
        public Node Next
        {
            get { return this.next; }
            set { this.Data = value; }
        }
    }
}
