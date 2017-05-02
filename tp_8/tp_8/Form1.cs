using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);

            double sum = 0;
            int prime = 2; // "frist" prime in this case
            for (int i = 1; i <= N; ++i)
            {
                sum += ((double)i / prime);
                richTextBox1.Text += String.Format("{0} / {1}\n",i,prime);
                prime = NextPrime(prime);
            }
            textBox2.Text = sum.ToString();
        }

        private static int NextPrime(int _firstPrime)
        {
            for (int i = _firstPrime + 1; i <= int.MaxValue; ++i)
            {
                if (IsPrime(i))
                {
                    return i;
                }
            }
            return 1;
        }

        protected static Boolean IsPrime(int _number)
        {
            for (int i = 2; i <= Math.Sqrt(_number); ++i) // 2 is a first prime
            {
                if (_number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }  
    }
}
