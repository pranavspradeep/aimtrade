namespace MEDICALSHOP1
{
    partial class SalesReturnReport
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
            this.crystalReportViewer_SalesReturnREport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer_SalesReturnREport
            // 
            this.crystalReportViewer_SalesReturnREport.ActiveViewIndex = -1;
            this.crystalReportViewer_SalesReturnREport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_SalesReturnREport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_SalesReturnREport.Location = new System.Drawing.Point(7, 152);
            this.crystalReportViewer_SalesReturnREport.Name = "crystalReportViewer_SalesReturnREport";
            this.crystalReportViewer_SalesReturnREport.Size = new System.Drawing.Size(1036, 457);
            this.crystalReportViewer_SalesReturnREport.TabIndex = 0;
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromdateTimePicker.Location = new System.Drawing.Point(148, 60);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FromdateTimePicker.TabIndex = 1;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TodateTimePicker.Location = new System.Drawing.Point(307, 60);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.TodateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(78, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Dates To Check";
            // 
            // SalesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.crystalReportViewer_SalesReturnREport);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesReturnReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReturnReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_SalesReturnREport;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}