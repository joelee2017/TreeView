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

namespace 李崇維_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection conn = null;
            SqlCommand command = null;
            try
            {
                conn = new  SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                command = new SqlCommand("select * from Customers", conn);
                SqlDataReader dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    string s = $"{dataReader["customerID"],-10}\t{dataReader["companyname"],20}";
                    listBox1.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                SqlConnection conn = null;
                SqlCommand command = null;
                using (conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True"))
                {
                    using (command = new SqlCommand("select * from Customers", conn))
                    {
                        conn.Disposed += Conn_Disposed;
                        conn.Open();
                        MessageBox.Show(conn.State.ToString());
                        SqlDataReader dataReader = command.ExecuteReader();
                        while(dataReader.Read())
                        {
                            string s = $"{dataReader["customerID"],-10}\t{dataReader["companyname"],20}";
                            listBox1.Items.Add(s);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Conn_Disposed(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
