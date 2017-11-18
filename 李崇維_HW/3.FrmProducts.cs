using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 李崇維_HW
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal aa = decimal.Parse(textBox1.Text);
                decimal bb = decimal.Parse(textBox2.Text);
                this.productsTableAdapter1.FillByProductUnitPrice(this.norWindDataSet1.Products, aa, bb);
                this.dataGridView1.DataSource = this.norWindDataSet1.Products;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
