namespace MEDICALSHOP1
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date_label = new System.Windows.Forms.Label();
            this.TotalAmount_textbox = new System.Windows.Forms.TextBox();
            this.Toatalamount_label = new System.Windows.Forms.Label();
            this.TotalProduct_textBox = new System.Windows.Forms.TextBox();
            this.TotalProduct_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Stock_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Location = new System.Drawing.Point(31, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(966, 198);
            this.dataGridView1.TabIndex = 93;
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(463, 400);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(106, 29);
            this.Close_btn.TabIndex = 92;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 22);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 27, 20, 18, 50, 0);
            // 
            // Date_label
            // 
            this.Date_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date_label.AutoSize = true;
            this.Date_label.BackColor = System.Drawing.Color.Transparent;
            this.Date_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.Location = new System.Drawing.Point(30, 66);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(110, 19);
            this.Date_label.TabIndex = 86;
            this.Date_label.Text = "Stock Till Date";
            // 
            // TotalAmount_textbox
            // 
            this.TotalAmount_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalAmount_textbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount_textbox.Location = new System.Drawing.Point(170, 100);
            this.TotalAmount_textbox.Name = "TotalAmount_textbox";
            this.TotalAmount_textbox.Size = new System.Drawing.Size(319, 26);
            this.TotalAmount_textbox.TabIndex = 97;
            // 
            // Toatalamount_label
            // 
            this.Toatalamount_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Toatalamount_label.AutoSize = true;
            this.Toatalamount_label.BackColor = System.Drawing.Color.Transparent;
            this.Toatalamount_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toatalamount_label.Location = new System.Drawing.Point(30, 107);
            this.Toatalamount_label.Name = "Toatalamount_label";
            this.Toatalamount_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Toatalamount_label.Size = new System.Drawing.Size(98, 19);
            this.Toatalamount_label.TabIndex = 96;
            this.Toatalamount_label.Text = "Total Amount";
            // 
            // TotalProduct_textBox
            // 
            this.TotalProduct_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalProduct_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProduct_textBox.Location = new System.Drawing.Point(612, 23);
            this.TotalProduct_textBox.Name = "TotalProduct_textBox";
            this.TotalProduct_textBox.Size = new System.Drawing.Size(352, 26);
            this.TotalProduct_textBox.TabIndex = 95;
            // 
            // TotalProduct_label
            // 
            this.TotalProduct_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalProduct_label.AutoSize = true;
            this.TotalProduct_label.BackColor = System.Drawing.Color.Transparent;
            this.TotalProduct_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProduct_label.Location = new System.Drawing.Point(508, 30);
            this.TotalProduct_label.Name = "TotalProduct_label";
            this.TotalProduct_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalProduct_label.Size = new System.Drawing.Size(98, 19);
            this.TotalProduct_label.TabIndex = 94;
            this.TotalProduct_label.Text = "Total Product";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalProduct_label);
            this.groupBox1.Controls.Add(this.TotalProduct_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 111);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 240);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Display";
            // 
            // Stock_label
            // 
            this.Stock_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stock_label.AutoSize = true;
            this.Stock_label.BackColor = System.Drawing.Color.Transparent;
            this.Stock_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_label.Location = new System.Drawing.Point(467, 10);
            this.Stock_label.Name = "Stock_label";
            this.Stock_label.Size = new System.Drawing.Size(93, 23);
            this.Stock_label.TabIndex = 85;
            this.Stock_label.Text = " STOCKS";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1019, 446);
            this.Controls.Add(this.TotalAmount_textbox);
            this.Controls.Add(this.Toatalamount_label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Stock_label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox TotalAmount_textbox;
        private System.Windows.Forms.Label Toatalamount_label;
        private System.Windows.Forms.TextBox TotalProduct_textBox;
        private System.Windows.Forms.Label TotalProduct_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Stock_label;
    }
}