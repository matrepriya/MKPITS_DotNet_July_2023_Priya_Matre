using System;
namespace program
{

    public partial class Form1 :
    {
        public Form1()
        {
            Initialize Component();
        }
        int[] marks = new int[3];
        int total = 0;
        float per;
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {

                if (cnt < 3)
                {
                    marks[cnt] = Convert.ToInt32(textBox1.Text);
                    cnt++;
                    textBox1.Clear();
                    textBox1.Focus();
                    if (cnt == 3)
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        MessageBox.Show("you have entered 3 subject marks now click on result button");
                    }
                }
            }

            private void button2_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    total = total + marks[i];
                }
                Label2.Text = "total marks " + total;
                per = (total / 300.0f) * 100.0f;
                Label3.Text = "percentage : " + per;
            }
        }
    }
        

    














            