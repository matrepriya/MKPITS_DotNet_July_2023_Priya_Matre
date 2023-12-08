using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buswindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student first Name:" + textBox1.Text + "/n");
            sb.Append( " student Last Name:" + textBox2.Text + "/n");
            sb.Append("Student Grade:" + textBox3.Text + "/n");
            sb.Append("parent First Name:" + textBox4.Text + "/n");
            sb.Append("parent last Name:" + textBox5.Text + "/n");
            sb.Append("parent email:" + textBox6.Text + "/n");
            sb.Append("parent phone number:" + textBox7.Text + "/n");
            sb.Append("address:" + textBox8.Text + "/n");
            label12.Text = sb.ToString();


        }
    }
}
