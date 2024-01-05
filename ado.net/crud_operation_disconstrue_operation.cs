using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crud_operation_disconsture_operation
{
    public partial class Form1 : Form

    {
        public string connectionstring {  get; set; }= @"Datasource = Priya\SQLEXPRESS;intial catalog = company; integrated security = true";
        SqlDataAdapter Sqlda;
         DataSet ds;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            Sqlda = new SqlDataAdapter("select * from employee", connectionstring);
            cb = new SqlCommandBuilder( Sqlda);
            DataSet ds = new DataSet();
            Sqlda.Fill(ds, "employee");

        }

       
        

        

       
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables ["employee"].NewRow();
            dr[0] = textBox1.Text;
            dr[1]= textBox2.Text;
            dr[2]= textBox3.Text;
            dr[3]= Convert.ToInt32(textBox4.Text);
            dr[4]= (textBox5.Text);
            dr[5]= Convert.ToInt16(textBox6.Text);
            Sqlda.Update(ds.Tables["employee"]);
            MessageBox.Show("Data successfully inserted");










            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds.Tables["employee"].Rows) 
            {
                if (dr[0].ToString()== textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = (textBox5.Text);
                        dr[5] = Convert.ToInt16(textBox6.Text);
                        Sqlda.Update(ds.Tables["employee"]);
                        MessageBox.Show(" Data successfully updated");
                    }
                    catch(Exception ex)
                    {  
                        MessageBox.Show(ex.Message);
                    }
                    break;

                    

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1 . DataSource = ds.Tables["employee"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in ds .Tables["employee"].Rows ) 
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        ds.Tables["employee"].Rows.Remove(dr);
                        Sqlda.Update(ds.Tables["employee"]);
                        MessageBox.Show("data successfully..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox .Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ds.Tables["employee"];
            comboBox1.DisplayMember = "emp_id";
        }
    }
}
