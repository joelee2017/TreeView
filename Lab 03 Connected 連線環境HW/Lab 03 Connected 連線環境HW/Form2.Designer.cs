namespace Lab_03_Connected_連線環境HW
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.cboCountry = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aSCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dESCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(857, 537);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(849, 511);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ListView";
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
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.cboCountry);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(843, 505);
			this.splitContainer1.SplitterDistance = 157;
			this.splitContainer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Country";
			// 
			// cboCountry
			// 
			this.cboCountry.FormattingEnabled = true;
			this.cboCountry.Location = new System.Drawing.Point(69, 59);
			this.cboCountry.Name = "cboCountry";
			this.cboCountry.Size = new System.Drawing.Size(121, 20);
			this.cboCountry.TabIndex = 0;
			this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(21, 22);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(698, 280);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.orderByToolStripMenuItem,
            this.groupToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(136, 114);
			// 
			// largeIconToolStripMenuItem
			// 
			this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
			this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.largeIconToolStripMenuItem.Text = "Large Icon";
			this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// smallIconToolStripMenuItem
			// 
			this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
			this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.smallIconToolStripMenuItem.Text = "Small Icon";
			// 
			// detailsToolStripMenuItem
			// 
			this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
			this.detailsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.detailsToolStripMenuItem.Text = "Details";
			// 
			// orderByToolStripMenuItem
			// 
			this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSCToolStripMenuItem,
            this.dESCToolStripMenuItem});
			this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
			this.orderByToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.orderByToolStripMenuItem.Text = "Order By";
			// 
			// aSCToolStripMenuItem
			// 
			this.aSCToolStripMenuItem.Name = "aSCToolStripMenuItem";
			this.aSCToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aSCToolStripMenuItem.Text = "ASC";
			// 
			// dESCToolStripMenuItem
			// 
			this.dESCToolStripMenuItem.Name = "dESCToolStripMenuItem";
			this.dESCToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.dESCToolStripMenuItem.Text = "DESC";
			// 
			// groupToolStripMenuItem
			// 
			this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
			this.groupToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.groupToolStripMenuItem.Text = "Group";
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
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 537);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboCountry;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aSCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dESCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
		internal System.Windows.Forms.ImageList ImageList1;
		internal System.Windows.Forms.ImageList ImageList2;
	}
}