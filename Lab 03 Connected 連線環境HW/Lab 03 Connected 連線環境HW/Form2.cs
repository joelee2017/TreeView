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
using Lab_03_Connected_連線環境HW.Properties;
using System.Collections;

namespace Lab_03_Connected_連線環境HW
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			ControlsInitialize();
			LoadCountryToComboBox();
			CreateListViewColumns();
		}

		private void ControlsInitialize()
		{
			splitContainer1.Panel1.BackColor = Color.LightYellow;
			splitContainer1.Panel2.BackColor = Color.LightGreen;

			//listView1 上下左右綁定畫面
			listView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			listView1.View = View.Details;//調整檢視方式:Details(詳細資料)
			listView1.ContextMenuStrip = contextMenuStrip1;//設定contextMenuStrip1為listView1滑鼠右鍵的小功能列
			listView1.SmallImageList = ImageList1;////設定listView1的小圖示
			listView1.LargeImageList = ImageList2;//設定listView1的大圖示

		}

		/// <summary>
		/// 讀取 國家的資料到 ComboBox 中
		/// </summary>
		/// <param name="">該方法無參數</param>
		private void LoadCountryToComboBox()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(Settings.Default.NWConnectionString))
				{
					using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT [Country] FROM [Northwind].[dbo].[Customers]", conn))
					{
						conn.Open();
						using (SqlDataReader dr = cmd.ExecuteReader())
						{
							cboCountry.Items.Clear();
							cboCountry.Items.Add("All Country");
							while(dr.Read())
							{
								cboCountry.Items.Add(dr["Country"]);
							}
							cboCountry.SelectedIndex = 0;
						}
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
			try
			{
				using (SqlConnection conn = new SqlConnection(Settings.Default.NWConnectionString))
				{
					using (SqlCommand cmd = new SqlCommand("select top 1 * from Customers",conn))
					{
						conn.Open();
						using (SqlDataReader dr = cmd.ExecuteReader())
						{
							DataTable dt = dr.GetSchemaTable();
							listView1.Columns.Clear();
							for(int i=0; i<dt.Rows .Count; i++)
							{
								listView1.Columns.Add(dt.Rows[i][0].ToString());
							}

							//依照Columns的名稱自動調整listView1標頭欄位的寬度
							listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							dt.Dispose();
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string sqlcmd = string.Empty;
				if(cboCountry.Text == "All Country")
				{
					sqlcmd = "select * from Customers";
				}
				else
				{
					sqlcmd = $"select * from Customers where Country ='{cboCountry.Text}'";
				}

				using (SqlConnection conn = new SqlConnection(Settings.Default.NWConnectionString))
				{
					using (SqlCommand cmd = new SqlCommand(sqlcmd, conn))
					{
						conn.Open();
						using (SqlDataReader dr = cmd.ExecuteReader())
						{
							Random r = new Random();//建立隨機物件
							listView1.Items.Clear();
							while(dr.Read())
							{
								//dr["CustomerID"].ToString() 等於 dr.GetString(0)
								ListViewItem lvItem = listView1.Items.Add(dr["CustomerID"].ToString());

								//例: r.Next(0,5) 就是從0~4取隨機
								//每一列 隨機 設定一張圖片

								lvItem.ImageIndex = r.Next(0, this.ImageList1.Images.Count);

								//根據奇數列與偶數列 來調整 lvItem 的背景顏色
								if(lvItem.Index % 2 ==0)
								{
									lvItem.BackColor = Color.LightCoral;
								}
								else
								{
									lvItem.BackColor = Color.GreenYellow;
								}

								for(int i=1; i< dr.FieldCount; i++)
								{
									//如果欄位的值是Null的話
									if(dr.IsDBNull(i))
									{
										lvItem.SubItems.Add("空值");
									}
									else
									{
										lvItem.SubItems.Add(dr[i].ToString());
									}
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

		private void ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			switch(((ToolStripMenuItem)sender).Text)
			{
				case "Large Icon":
					listView1.View = View.LargeIcon;
					break;
				case "Samll Icon":
					listView1.View = View.LargeIcon;
					break;
				case "Details":
					listView1.View = View.LargeIcon;
					break;
				//case "Order By":
				//    listView1.Sorting = 
				//    break;

				default:
					break;
			}
		}

		/*
參考 MSDN: https://msdn.microsoft.com/en-us/library/ms996467.aspx
*/
		private int sortColumn = -1;
		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if(e.Column != sortColumn)
			{
				sortColumn = e.Column;
				listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			}
			else
			{
				if(listView1.Sorting == System.Windows.Forms.SortOrder.Ascending)
				{
					listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
				}
				else
				{
					listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
				}
			}

			listView1.Sort();
			this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
		}

		/// Implements the manual sorting of items by columns.
		class ListViewItemComparer : IComparer
		{
			private int col;
			private System.Windows.Forms.SortOrder order;
			public ListViewItemComparer()
			{
				col = 0;
				order = System.Windows.Forms.SortOrder.Ascending;
			}
			public ListViewItemComparer(int column, System.Windows.Forms.SortOrder order)
			{
				col = column;
				this.order = order;
			}
			public int Compare(object x, object y)
			{
				int returnVal = -1;
				returnVal = string.Compare(((ListViewItem)x).SubItems[col].Text,
											((ListViewItem)y).SubItems[col].Text);
				// Determine whether the sort order is descending
				if (order == System.Windows.Forms.SortOrder.Descending)
				{
					// Invert the value returned by String.Compare.
					returnVal *= -1;
					
				}
return returnVal;

			}
		}


	}
}
