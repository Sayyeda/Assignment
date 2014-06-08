using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        LinkedList2 myLinkedList2;
        public Form1()
        {
            InitializeComponent();
            myLinkedList2 = new LinkedList2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myLinkedList2.add(textBox1.Text);
            myLinkedList2.print();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myLinkedList2.delete(textBox1.Text);
            myLinkedList2.print();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
