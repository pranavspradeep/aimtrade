namespace MEDICALSHOP1.REPORTS
{
    partial class SaleReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.To_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.From_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesReportViewer);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 336);
            this.panel1.TabIndex = 0;
            // 
            // SalesReportViewer
            // 
            this.SalesReportViewer.ActiveViewIndex = -1;
            this.SalesReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesReportViewer.Name = "SalesReportViewer";
            this.SalesReportViewer.Size = new System.Drawing.Size(796, 336);
            this.SalesReportViewer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Submit_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.To_dateTimePicker);
            this.groupBox1.Controls.Add(this.From_dateTimePicker);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select date range";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(526, 34);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(93, 23);
            this.Submit_btn.TabIndex = 4;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From date";
            // 
            // To_dateTimePicker
            // 
            this.To_dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.To_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To_dateTimePicker.Location = new System.Drawing.Point(319, 36);
            this.To_dateTimePicker.Name = "To_dateTimePicker";
            this.To_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.To_dateTimePicker.TabIndex = 1;
            // 
            // From_dateTimePicker
            // 
            this.From_dateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.From_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From_dateTimePicker.Location = new System.Drawing.Point(60, 34);
            this.From_dateTimePicker.Name = "From_dateTimePicker";
            this.From_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.From_dateTimePicker.TabIndex = 0;
            // 
            // SaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SaleReport";
            this.Text = "SaleReport";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer SalesReportViewer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker To_dateTimePicker;
        private System.Windows.Forms.DateTimePicker From_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit_btn;
    }
}