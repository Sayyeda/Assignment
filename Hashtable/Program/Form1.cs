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
           
            listBox1.Items.Add(textBox2.Text);

            //students.Add(textBox2.Text,a);
           // Console.WriteLine(textBox2);
            PrintKeysAndValues(students);
            
        }

        public static void PrintKeysAndValues(Hashtable students)
        {
            foreach (DictionaryEntry de in students)
            Console.WriteLine("    {0}:   {1}",de.Key, de.Value);
            Console.WriteLine();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Remove(textBox1.Text);
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

        private void list2_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Peter", 67);
            students.Add("Brayan", 76);
            students.Add("Lincoln", 56);
            students.Add("Jack", 65);
            students.Add("Mahone", 0);
            students.Add("Kevin", 64);

            foreach (var student in students)
            {
                listBox1.Items.Add(student.Key);
                listBox1.Items.Add(student.Value);
            }

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        

    }
}
