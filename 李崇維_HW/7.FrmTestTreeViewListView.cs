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
using 李崇維_HW.Properties;

namespace 李崇維_HW
{
    public partial class frmTestTreeViewListView : Form
    {
        public frmTestTreeViewListView()
        {
            InitializeComponent();
        }

        private void TestTreeViewListView_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
            using (var Tree01 = new SqlDataAdapter((@"
                        select 
                        customerid  
                        from Customers"), conn))
            {
                var dt = new DataTable();
                Tree01.Fill(dt);
                
            }
        }
    }
}
