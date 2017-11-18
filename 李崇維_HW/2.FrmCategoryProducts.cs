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
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                SqlConnection conn = null;
                SqlCommand command = null;
                using (conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True"))
                {
                    using (command = new SqlCommand("select p.ProductName from Categories AS C join Products as p on c.CategoryID = p.CategoryID", conn))
                    {
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            string s = $"{dataReader["ProductName"]}";
                            listBox1.Items.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCategoryProducts_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = null;
                SqlCommand command = null;
                using (conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True"))
                {
                    using (command = new SqlCommand("select * from Categories", conn))
                    {
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            string s = $"{dataReader["CategoryName"]}";
                            comboBox1.Items.Add(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
