﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculate;
namespace calculate_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c = new Calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            int r = c.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Add two no :" + r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = c.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Substract two no :" + r;
        }
    }

}
//*//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    public class Calculate
    {
        public int addition(int n1, int n2)
        {
            int result;
            result = n1 + n2;
            return result;
        }
        public int substraction(int n1, int n2)
        {
            int result;
            result = n1 - n2;
            return result;
        }
    }
}

