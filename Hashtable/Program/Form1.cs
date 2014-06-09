using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Program
{
    public partial class HashTable : Form
    {
        public HashTable()
        {
            InitializeComponent();
        }
        
        Hashtable students = new Hashtable();

        char a;
        
        private void Add_Click(object sender, EventArgs e)
        {         
            students.Add(textBox2.Text,a);
            Console.WriteLine("The Hashtable initially contains the following:",textBox2);
            PrintKeysAndValues(students);    
        }

        public static void PrintKeysAndValues(Hashtable students)
        {
            foreach (DictionaryEntry de in students)
            Console.WriteLine("    {0}:    {1}", de.Key, de.Value);
            Console.WriteLine();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            students.Remove(textBox1.Text);
            Console.WriteLine("After removing :");
            PrintKeysAndValues(students);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        

    }
}
