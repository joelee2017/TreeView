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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter1.FillByCustomerIDdISTINCT(this.norWindDataSet1.Orders);
            this.ordersTableAdapter1.Fill(this.norWindDataSet1.Orders);

            foreach(DataRow dr in this.norWindDataSet1.Orders.Select("CustomerID is not null"))
            //使用foreach 宣告DataRow dr類型，提取資料來源norWindDataSet1.Orders.Select("CustomerID is not null")
            {
                TreeNode treeNode0 = new TreeNode();//宣告TreeNode類別  treeNode0父變數
                treeNode0.Text = dr["CustomerID"].ToString();//第一層節點的值 customerid
                treeNode0.Tag = dr["CustomerID"].ToString();//Key索引值以DB中的ID
                treeView1.Nodes.Add(treeNode0);//將剛剛建立的treenode放到treeView1中
                //第一層Customerid 撈出從DB中
            }

            foreach(TreeNode treeNode in treeView1.Nodes)
            {
                //MessageBox.Show(treeNode.Text);將treeNode的值提取出來(第一層)
                foreach(DataRow dr in this.norWindDataSet1.Orders.Select("CustomerID='"+treeNode.Tag.ToString()+"' "))
                    
                {
                    TreeNode treeNode01 = new TreeNode();//宣告TreeNode類別  treeNode01子變數
                    treeNode01.Text = dr["OrderID"].ToString();//第二層節點的值 OrderID
                    treeNode01.Tag = dr["OrderID"];//Key索引值以DB中的ID

                    treeNode.Nodes.Add(treeNode01);
                    //將子節結匯入treeNode之中
                    //第一層 treeView1.Nodes.Add(treeNode0)，在匯入第二層treeNode.Nodes.Add(treeNode01)
                    //第二層OrderID
                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //var sqlText = string.Empty;
            //sqlText = @"select 
            //                OrderID,
            //                CustomerID,
            //                ShipName,
            //                ShipCity,
            //                ShipAddress
            //            from
            //                Orders
            //            where
            //                OrderID =@orderid;";
            //using (var con = new SqlConnection(Settings.Default.NorthwindConnectionString))
            //using (var adp = new SqlDataAdapter(sqlText, con))
            //{
            //    adp.SelectCommand.Parameters.Add("Or", SqlDbType.Int).Value = OrderID;
                

                
                
            //}
        }
    }
}
