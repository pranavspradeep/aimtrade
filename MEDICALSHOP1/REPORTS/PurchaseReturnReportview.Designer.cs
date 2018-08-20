namespace MEDICALSHOP1
{
    partial class PurchaseReturnReportview
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
            this.crystalReportViewer_purchasereturn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer_purchasereturn
            // 
            this.crystalReportViewer_purchasereturn.ActiveViewIndex = -1;
            this.crystalReportViewer_purchasereturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer_purchasereturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer_purchasereturn.Location = new System.Drawing.Point(1, 108);
            this.crystalReportViewer_purchasereturn.Name = "crystalReportViewer_purchasereturn";
            this.crystalReportViewer_purchasereturn.Size = new System.Drawing.Size(1027, 445);
            this.crystalReportViewer_purchasereturn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(153, 45);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FromdateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker.Location = new System.Drawing.Point(312, 45);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.TodateTimePicker.TabIndex = 4;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(431, 45);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 5;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // PurchaseReturnReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 565);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer_purchasereturn);
            this.Name = "PurchaseReturnReportview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseReturnReportview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer_purchasereturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Button Submit_btn;
    }
}