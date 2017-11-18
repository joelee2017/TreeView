namespace 李崇維_HW
{
    partial class FrmAdventureWork
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.productYearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.adventureWorkDataSet1 = new 李崇維_HW.AdventureWorkDataSet();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.productPhotoTableAdapter1 = new 李崇維_HW.AdventureWorkDataSetTableAdapters.ProductPhotoTableAdapter();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.productYearsTableAdapter1 = new 李崇維_HW.AdventureWorkDataSetTableAdapters.ProductYearsTableAdapter();
			this.productPhotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productYearsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adventureWorkDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 140);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(608, 339);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(184, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "至";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(373, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "期間";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(373, 108);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "排序";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(26, 35);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(70, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "<<";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Mouse_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(103, 35);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(70, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "<";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Mouse_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(226, 35);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(70, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = ">";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Mouse_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(303, 35);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(70, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = ">>";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Mouse_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(181, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(36, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 12);
			this.label3.TabIndex = 11;
			this.label3.Text = "年";
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.productYearsBindingSource;
			this.comboBox3.DisplayMember = "Year";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(62, 108);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(140, 20);
			this.comboBox3.TabIndex = 12;
			this.comboBox3.ValueMember = "Year";
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// productYearsBindingSource
			// 
			this.productYearsBindingSource.DataMember = "ProductYears";
			this.productYearsBindingSource.DataSource = this.adventureWorkDataSet1;
			// 
			// adventureWorkDataSet1
			// 
			this.adventureWorkDataSet1.DataSetName = "AdventureWorkDataSet";
			this.adventureWorkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(654, 247);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "GName";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(628, 265);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(282, 22);
			this.textBox1.TabIndex = 14;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(646, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(237, 161);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(654, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 12);
			this.label5.TabIndex = 16;
			this.label5.Text = "Picture";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(39, 72);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
			this.dateTimePicker1.TabIndex = 17;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(214, 73);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(141, 22);
			this.dateTimePicker2.TabIndex = 18;
			// 
			// productPhotoTableAdapter1
			// 
			this.productPhotoTableAdapter1.ClearBeforeFill = true;
			// 
			// productYearsTableAdapter1
			// 
			this.productYearsTableAdapter1.ClearBeforeFill = true;
			// 
			// productPhotoBindingSource
			// 
			this.productPhotoBindingSource.DataMember = "ProductPhoto";
			this.productPhotoBindingSource.DataSource = this.adventureWorkDataSet1;
			// 
			// FrmAdventureWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(922, 641);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Name = "FrmAdventureWork";
			this.Text = "FrmAdventureWork";
			this.Load += new System.EventHandler(this.FrmAdventureWork_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productYearsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adventureWorkDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private AdventureWorkDataSet adventureWorkDataSet1;
        private AdventureWorkDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
		private AdventureWorkDataSetTableAdapters.ProductYearsTableAdapter productYearsTableAdapter1;
		private System.Windows.Forms.BindingSource productYearsBindingSource;
		private System.Windows.Forms.BindingSource productPhotoBindingSource;
	}
}