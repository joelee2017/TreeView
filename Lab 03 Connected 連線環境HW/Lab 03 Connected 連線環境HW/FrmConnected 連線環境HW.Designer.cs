namespace Lab_03_Connected_連線環境HW
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deatalViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sToLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lToSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tabControl1.Location = new System.Drawing.Point(12, 30);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(900, 592);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(892, 565);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TreeView/ListView";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(886, 559);
			this.splitContainer1.SplitterDistance = 204;
			this.splitContainer1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(605, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(3, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Country:";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(117, 78);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// listView1
			// 
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listView1.LargeImageList = this.ImageList2;
			this.listView1.Location = new System.Drawing.Point(4, 4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(862, 343);
			this.listView1.SmallImageList = this.ImageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.deatalViewToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(141, 114);
			// 
			// largeIconToolStripMenuItem
			// 
			this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
			this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.largeIconToolStripMenuItem.Text = "Large Icon";
			this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
			// 
			// smallIconToolStripMenuItem
			// 
			this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
			this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.smallIconToolStripMenuItem.Text = "Small Icon";
			this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
			// 
			// deatalViewToolStripMenuItem
			// 
			this.deatalViewToolStripMenuItem.Name = "deatalViewToolStripMenuItem";
			this.deatalViewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.deatalViewToolStripMenuItem.Text = "DeatalView";
			this.deatalViewToolStripMenuItem.Click += new System.EventHandler(this.deatalViewToolStripMenuItem_Click);
			// 
			// orderByToolStripMenuItem
			// 
			this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToLToolStripMenuItem,
            this.lToSToolStripMenuItem});
			this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
			this.orderByToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.orderByToolStripMenuItem.Text = "OrderBy";
			// 
			// sToLToolStripMenuItem
			// 
			this.sToLToolStripMenuItem.Name = "sToLToolStripMenuItem";
			this.sToLToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.sToLToolStripMenuItem.Text = "s to L";
			this.sToLToolStripMenuItem.Click += new System.EventHandler(this.sToLToolStripMenuItem_Click);
			// 
			// lToSToolStripMenuItem
			// 
			this.lToSToolStripMenuItem.Name = "lToSToolStripMenuItem";
			this.lToSToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.lToSToolStripMenuItem.Text = "L to s";
			this.lToSToolStripMenuItem.Click += new System.EventHandler(this.lToSToolStripMenuItem_Click);
			// 
			// groupToolStripMenuItem
			// 
			this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
			this.groupToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.groupToolStripMenuItem.Text = "GroupBy";
			this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
			// 
			// ImageList2
			// 
			this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
			this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
			this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
			this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
			this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
			this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
			this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
			this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
			this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
			this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
			this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
			this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
			this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
			this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
			this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
			this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
			this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
			this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
			this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
			this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
			// 
			// ImageList1
			// 
			this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
			this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
			this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
			this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
			this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
			this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
			this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
			this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
			this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
			this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
			this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
			this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
			this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
			this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
			this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
			this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
			this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
			this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
			this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(892, 565);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 638);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		internal System.Windows.Forms.ImageList ImageList2;
		internal System.Windows.Forms.ImageList ImageList1;
		private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deatalViewToolStripMenuItem;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sToLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lToSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
	}
}

