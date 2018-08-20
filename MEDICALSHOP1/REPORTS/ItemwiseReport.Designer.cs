namespace MEDICALSHOP1.REPORTS
{
    partial class ItemwiseReport
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
            this.print_btn = new System.Windows.Forms.Button();
            this.infogrid_dgv = new System.Windows.Forms.DataGridView();
            this.Productname_txt = new System.Windows.Forms.TextBox();
            this.Todatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FromDatepicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.GroupBox();
            this.datewise_btn = new System.Windows.Forms.Button();
            this.Doctorname_txt = new System.Windows.Forms.TextBox();
            this.Companyname_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prod_btn = new System.Windows.Forms.Button();
            this.company_wise_btn = new System.Windows.Forms.Button();
            this.doct_wise_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infogrid_dgv)).BeginInit();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.print_btn);
            this.panel1.Controls.Add(this.infogrid_dgv);
            this.panel1.Controls.Add(this.Todatetimepicker);
            this.panel1.Controls.Add(this.FromDatepicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 540);
            this.panel1.TabIndex = 0;
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(700, 482);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(139, 23);
            this.print_btn.TabIndex = 1;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // infogrid_dgv
            // 
            this.infogrid_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infogrid_dgv.Location = new System.Drawing.Point(29, 197);
            this.infogrid_dgv.Name = "infogrid_dgv";
            this.infogrid_dgv.Size = new System.Drawing.Size(810, 279);
            this.infogrid_dgv.TabIndex = 0;
            // 
            // Productname_txt
            // 
            this.Productname_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Productname_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Productname_txt.Location = new System.Drawing.Point(93, 71);
            this.Productname_txt.Name = "Productname_txt";
            this.Productname_txt.Size = new System.Drawing.Size(478, 20);
            this.Productname_txt.TabIndex = 3;
            this.Productname_txt.Leave += new System.EventHandler(this.Productname_txt_Leave_1);
            // 
            // Todatetimepicker
            // 
            this.Todatetimepicker.Location = new System.Drawing.Point(394, 61);
            this.Todatetimepicker.Name = "Todatetimepicker";
            this.Todatetimepicker.Size = new System.Drawing.Size(200, 20);
            this.Todatetimepicker.TabIndex = 2;
            this.Todatetimepicker.Leave += new System.EventHandler(this.Todatetimepicker_Leave_1);
            // 
            // FromDatepicker
            // 
            this.FromDatepicker.Location = new System.Drawing.Point(116, 61);
            this.FromDatepicker.Name = "FromDatepicker";
            this.FromDatepicker.Size = new System.Drawing.Size(200, 20);
            this.FromDatepicker.TabIndex = 1;
            this.FromDatepicker.Leave += new System.EventHandler(this.FromDatepicker_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date From ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM WISE REPORT";
            // 
            // Search
            // 
            this.Search.Controls.Add(this.doct_wise_btn);
            this.Search.Controls.Add(this.company_wise_btn);
            this.Search.Controls.Add(this.prod_btn);
            this.Search.Controls.Add(this.datewise_btn);
            this.Search.Controls.Add(this.Productname_txt);
            this.Search.Controls.Add(this.Doctorname_txt);
            this.Search.Controls.Add(this.Companyname_txtbox);
            this.Search.Controls.Add(this.label6);
            this.Search.Controls.Add(this.label5);
            this.Search.Location = new System.Drawing.Point(23, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(822, 166);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // datewise_btn
            // 
            this.datewise_btn.Location = new System.Drawing.Point(578, 36);
            this.datewise_btn.Name = "datewise_btn";
            this.datewise_btn.Size = new System.Drawing.Size(134, 20);
            this.datewise_btn.TabIndex = 6;
            this.datewise_btn.Text = "Datewise report";
            this.datewise_btn.UseVisualStyleBackColor = true;
            this.datewise_btn.Click += new System.EventHandler(this.Todatetimepicker_Leave);
            // 
            // Doctorname_txt
            // 
            this.Doctorname_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Doctorname_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Doctorname_txt.Location = new System.Drawing.Point(93, 133);
            this.Doctorname_txt.Name = "Doctorname_txt";
            this.Doctorname_txt.Size = new System.Drawing.Size(478, 20);
            this.Doctorname_txt.TabIndex = 5;
            // 
            // Companyname_txtbox
            // 
            this.Companyname_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Companyname_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Companyname_txtbox.Location = new System.Drawing.Point(93, 101);
            this.Companyname_txtbox.Name = "Companyname_txtbox";
            this.Companyname_txtbox.Size = new System.Drawing.Size(478, 20);
            this.Companyname_txtbox.TabIndex = 4;
            this.Companyname_txtbox.Leave += new System.EventHandler(this.Companyname_txtbox_Leave_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doctor  name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Company name";
            // 
            // prod_btn
            // 
            this.prod_btn.Location = new System.Drawing.Point(578, 71);
            this.prod_btn.Name = "prod_btn";
            this.prod_btn.Size = new System.Drawing.Size(134, 20);
            this.prod_btn.TabIndex = 7;
            this.prod_btn.Text = "Product wise report";
            this.prod_btn.UseVisualStyleBackColor = true;
            this.prod_btn.Click += new System.EventHandler(this.Productname_txt_Leave);
            // 
            // company_wise_btn
            // 
            this.company_wise_btn.Location = new System.Drawing.Point(577, 101);
            this.company_wise_btn.Name = "company_wise_btn";
            this.company_wise_btn.Size = new System.Drawing.Size(135, 26);
            this.company_wise_btn.TabIndex = 8;
            this.company_wise_btn.Text = "Company wise report";
            this.company_wise_btn.UseVisualStyleBackColor = true;
            this.company_wise_btn.Click += new System.EventHandler(this.Companyname_txtbox_Leave);
            // 
            // doct_wise_btn
            // 
            this.doct_wise_btn.Location = new System.Drawing.Point(578, 133);
            this.doct_wise_btn.Name = "doct_wise_btn";
            this.doct_wise_btn.Size = new System.Drawing.Size(134, 27);
            this.doct_wise_btn.TabIndex = 9;
            this.doct_wise_btn.Text = "Doctorwise report";
            this.doct_wise_btn.UseVisualStyleBackColor = true;
            this.doct_wise_btn.Click += new System.EventHandler(this.Doctorname_txt_Leave);
            // 
            // ItemwiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 544);
            this.Controls.Add(this.panel1);
            this.Name = "ItemwiseReport";
            this.Text = "ITEM WISE REPORT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infogrid_dgv)).EndInit();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Todatetimepicker;
        private System.Windows.Forms.DateTimePicker FromDatepicker;
        private System.Windows.Forms.TextBox Companyname_txtbox;
        private System.Windows.Forms.TextBox Doctorname_txt;
        private System.Windows.Forms.TextBox Productname_txt;
        private System.Windows.Forms.DataGridView infogrid_dgv;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button datewise_btn;
        private System.Windows.Forms.Button doct_wise_btn;
        private System.Windows.Forms.Button company_wise_btn;
        private System.Windows.Forms.Button prod_btn;
    }
}