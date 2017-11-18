using Lab_03_Connected_連線環境HW.Properties;
using System;
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

namespace Lab_03_Connected_連線環境HW
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			LoadCountryToComboBox();
			CreateListViewColumns();
		}
		

		private void LoadCountryToComboBox()
		{
			try
			{
				string connString = Settings.Default.NWConnectionString;
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					using (SqlCommand command = new SqlCommand("select distinct Country from Customers", conn))
					{
						SqlDataReader dataReader = command.ExecuteReader();

						this.comboBox1.Items.Clear();
						this.comboBox1.Items.Add("ALLCountry");//創建combobox集合內容時加入allCountry
						while(dataReader.Read())
						{
							this.comboBox1.Items.Add($"{ dataReader["Country"],-20}");
						}
						this.comboBox1.SelectedIndex = 0;
					}
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void CreateListViewColumns()
		{
			this.listView1.View = View.Details;

			try
			{
				string connString = Settings.Default.NWConnectionString;
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					using (SqlCommand command = new SqlCommand("select * from Customers", conn))
					{
						SqlDataReader dataReader = command.ExecuteReader();
						DataTable table = dataReader.GetSchemaTable();
						this.dataGridView1.DataSource = table;
						for(int i=0; i<=table.Rows.Count-1;i++)
						{
							this.listView1.Columns.Add(table.Rows[i][0].ToString());
						}
						this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string connString = Settings.Default.NWConnectionString;
				using (SqlConnection conn = new SqlConnection(connString))
				{
					conn.Open();
					//加入全國判斷
					string commandALLCountry = null;
					if(comboBox1.Text =="ALLCountry")
					{
						commandALLCountry = "select * from Customers";
					}
					else
					{
						commandALLCountry = 
							"select * from Customers where Country='" + this.comboBox1.Text + "'";
					}
					using (SqlCommand command = new SqlCommand
						(commandALLCountry, conn))
					{
						SqlDataReader dataReader = command.ExecuteReader();
						this.listView1.Items.Clear();

						Random r = new Random();

							
						while(dataReader.Read())
						{
							ListViewItem listView = this.listView1.Items.Add(dataReader["CustomerID"].ToString());
							listView.ImageIndex = r.Next(0, this.ImageList1.Images.Count);
							if(listView.Index % 2==0)
							{
								listView.BackColor = Color.LightGreen;
							}
							else
							{
								listView.BackColor = Color.Wheat;
							}

							for(int i=1; i<=dataReader.FieldCount-1; i++)
							{
								if (dataReader.IsDBNull(i))
								{
									listView.SubItems.Add("空值");
								}
								else
								{
									listView.SubItems.Add(dataReader[i].ToString());
								}
								
							}
						}

					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//ToDo ..
		string commandFormat = "select * from customers  {0}  {1}";
		string commandWhere = "";
		string commandOrder = "";

		private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listView1.View = View.LargeIcon;
		}

		private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listView1.View = View.SmallIcon;
		}

		private void deatalViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listView1.View = View.Details;
		}

		private void sToLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//小到大
			listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;

		}

		private void lToSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//大到小
			listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
		}

		private void groupToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
