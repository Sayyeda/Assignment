using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace caluclator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void BtnCClick_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void BtnCEClick(object sender, EventArgs e)
        {

            if (num1 == 0 && textBox1.TextLength > 0)
            {
                num1 = 0; textBox1.Clear();
            }
            else if (num1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
            }

        }

        private void BtnbackClick(object sender, EventArgs e)
        {

            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];

        }

        private void BtnMinusClick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void BtnOneClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void BttnTwoClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void BtntThreeClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void BtnPlusClick(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void BtnFourClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void BtnFiveClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void BtnSixClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void BtnMultiplyClick(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void BtnSevenClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void BtnEightClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void BtnnineClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void BtnDivideClick(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void BtnZeroClick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void BtnPeriodClick(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void BtnEqualClick(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
           
    }
}
