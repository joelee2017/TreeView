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
	public partial class FrmAdventureWork : Form
	{
		public FrmAdventureWork()
		{
			InitializeComponent();
		}
		
		private void FrmAdventureWork_Load(object sender, EventArgs e)
		{
			this.productYearsTableAdapter1.FillYears(this.adventureWorkDataSet1.ProductYears);


			var year = (int)this.comboBox3.SelectedValue;

			var beginDate = new DateTime(year, 1, 1);
			var endDate = new DateTime(year + 1, 1, 1).AddSeconds(-1);

			this.adventureWorkDataSet1.ProductPhoto.Clear();
			this.productPhotoTableAdapter1.FillByModifiedDateBetween(
				this.adventureWorkDataSet1.ProductPhoto, beginDate, endDate);


			////主顯示區域
			//this.productPhotoTableAdapter1.Fill(this.adventureWorkDataSet1.ProductPhoto);//建立連結DataSet

			//資料順序記錄
			this.bindingSource1.DataSource = this.adventureWorkDataSet1.ProductPhoto;//記錄順序
			this.dataGridView1.DataSource = this.bindingSource1;//記錄順序顯示

			this.textBox1.DataBindings.Add("Text", this.bindingSource1, "LargePhotoFileName");
			//選取項目顯示右側名字圖片欄位
			this.pictureBox1.DataBindings.Add("Image", this.bindingSource1, "ThumbNailPhoto", true);

			label2.Text = string.Format("{0} / {1}", this.bindingSource1.Position + 1, this.bindingSource1.Count);


		}


		private void button1_Click(object sender, EventArgs e)
		{
			//年份範圍選取
			DateTime aa = DateTime.Parse(dateTimePicker1.Text);
			DateTime bb = DateTime.Parse(dateTimePicker2.Text);
			this.productPhotoTableAdapter1.FillByModifiedDateBetween(
				this.adventureWorkDataSet1.ProductPhoto, aa, bb);//建立連結DataSet
		}

		private void Mouse_Click(object sender, EventArgs e)
		{
			//資料功能鍵設置
			switch (((Button)sender).Text)
			{
				case "<<":
					this.bindingSource1.Position = 0;
					break;
				case ">":
					this.bindingSource1.Position += 1;
					break;
				case "<":
					this.bindingSource1.Position -= -1;
					break;
				case ">>":
					this.bindingSource1.Position = this.bindingSource1.Count - 1;
					break;
			}
		}
		

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox3.SelectedValue != null)
			{
				var year = (int)this.comboBox3.SelectedValue;
		
			var beginDate = new DateTime(year, 1, 1);
				var endDate = new DateTime(year + 1, 1, 1).AddSeconds(-1);
				this.adventureWorkDataSet1.ProductPhoto.Clear();
				this.productPhotoTableAdapter1.FillByModifiedDateBetween(
					this.adventureWorkDataSet1.ProductPhoto, beginDate, endDate);
			}
			return;


		}

		private void button2_Click(object sender, EventArgs e)
		{
			//string cc = comboBox3.SelectedValue.ToString;

			this.dataGridView1.DataSource = null;
			this.productYearsTableAdapter1.FillByOrderbyYear(this.adventureWorkDataSet1.ProductYears);
			this.dataGridView1.DataSource = this.adventureWorkDataSet1.ProductYears;

		}
	}
}
