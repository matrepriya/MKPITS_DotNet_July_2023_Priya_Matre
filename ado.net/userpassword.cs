using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace usernamepassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = " server=.\\SQLEXPRESS;integrated security = true ;database = passdb";
        SqlConnection conn = null;
        SqlCommand cmd = null;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                string qr = "select count(*) from username where username = @username and password = @password";
                cmd = new SqlCommand(qr, conn);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password",textBox2.Text);
                conn.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)
                    label3.Text = "login successfully";
                Form f = new Form();
                f.Show();
                this.Hide();
            }
            catch ( Exception ex)
            {
                    MessageBox.Show(ex.ToString());
                }
             finally
            {
                conn.Close();
            }



        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
