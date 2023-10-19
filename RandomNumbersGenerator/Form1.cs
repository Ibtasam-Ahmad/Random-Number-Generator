using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbersGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random obj = new Random();
            int num = 100;

            for (int i = 0; i < num; i++)
            {
                //int var;
                //var = obj.Next(1, 6);
                textBox1.Text = textBox1.Text +"\r\t"+ i + " = " + obj.Next(1, 7);
                System.Threading.Thread.Sleep(20);
                textBox1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random obj = new Random();
            int num = 100;

            for (int i = 0; i < num; i++)
            {
                //int var;
                //var = obj.Next();
                textBox1.Text = textBox1.Text + "\r\t" + i + " = " + obj.Next();
                System.Threading.Thread.Sleep(20);
                textBox1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random obj = new Random();
            int num = 100;

            for (int i = 0; i < num; i++)
            {
                //int var;
                //var = obj.Next();
                textBox1.Text = textBox1.Text + "\r\t" + i + " = " + obj.Next(60);
                System.Threading.Thread.Sleep(20);
                textBox1.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random obj = new Random();
            int num = 100;

            for (int i = 0; i < num; i++)
            {
                //int var;
                //var = obj.Next();
                textBox1.Text = textBox1.Text + "\r\t" + i + " = " + obj.NextDouble();
                System.Threading.Thread.Sleep(20);
                textBox1.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random obj = new Random();
            int num = 100;
            double min = 0.1, max = 1.1;

            for (int i = 0; i < num; i++)
            {
                //int var;
                //var = obj.Next();
                textBox1.Text = textBox1.Text + "\r\t" + i + " = " + ( min + (max - min) * obj.NextDouble());
                System.Threading.Thread.Sleep(20);
                textBox1.Refresh();
            }
        }
    }
}
