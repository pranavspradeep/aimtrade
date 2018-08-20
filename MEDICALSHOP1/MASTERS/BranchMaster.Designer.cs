namespace MEDICALSHOP1
{
    partial class BranchMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BranchMaster_label = new System.Windows.Forms.Label();
            this.BranchID_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Branchmaster_datagrid = new System.Windows.Forms.DataGridView();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.kgst_txtbox = new System.Windows.Forms.TextBox();
            this.Kgstno_label = new System.Windows.Forms.Label();
            this.PhoneNo_txtbox = new System.Windows.Forms.TextBox();
            this.Location_txtbox = new System.Windows.Forms.TextBox();
            this.Branchname_txtbox = new System.Windows.Forms.TextBox();
            this.Phone_No_label = new System.Windows.Forms.Label();
            this.Location_label = new System.Windows.Forms.Label();
            this.Branch_Name_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.error_label = new System.Windows.Forms.Label();
            this.branchInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Branchmaster_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchMaster_label
            // 
            this.BranchMaster_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BranchMaster_label.AutoSize = true;
            this.BranchMaster_label.BackColor = System.Drawing.Color.Transparent;
            this.BranchMaster_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchMaster_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BranchMaster_label.Location = new System.Drawing.Point(461, 10);
            this.BranchMaster_label.Name = "BranchMaster_label";
            this.BranchMaster_label.Size = new System.Drawing.Size(179, 22);
            this.BranchMaster_label.TabIndex = 0;
            this.BranchMaster_label.Text = "BRANCH MASTER";
            // 
            // BranchID_Label
            // 
            this.BranchID_Label.AutoSize = true;
            this.BranchID_Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_Label.Location = new System.Drawing.Point(754, 92);
            this.BranchID_Label.Name = "BranchID_Label";
            this.BranchID_Label.Size = new System.Drawing.Size(0, 19);
            this.BranchID_Label.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(612, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Branch ID";
            // 
            // Branchmaster_datagrid
            // 
            this.Branchmaster_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Branchmaster_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Branchmaster_datagrid.Location = new System.Drawing.Point(15, 105);
            this.Branchmaster_datagrid.Name = "Branchmaster_datagrid";
            this.Branchmaster_datagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Branchmaster_datagrid.Size = new System.Drawing.Size(566, 240);
            this.Branchmaster_datagrid.TabIndex = 83;
            this.Branchmaster_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Branchmaster_datagrid_CellClick);
            this.Branchmaster_datagrid.Click += new System.EventHandler(this.Branchmaster_datagrid_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Delete_button.Location = new System.Drawing.Point(1106, 261);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(77, 35);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Clear_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Clear_button.Location = new System.Drawing.Point(1018, 261);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(77, 35);
            this.Clear_button.TabIndex = 7;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Edit_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Edit_button.Location = new System.Drawing.Point(930, 261);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(77, 35);
            this.Edit_button.TabIndex = 6;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Close_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Close_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Close_button.Location = new System.Drawing.Point(842, 261);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(77, 35);
            this.Close_button.TabIndex = 5;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save_Button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Save_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Save_Button.Location = new System.Drawing.Point(754, 261);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(77, 35);
            this.Save_Button.TabIndex = 4;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // kgst_txtbox
            // 
            this.kgst_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kgst_txtbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgst_txtbox.Location = new System.Drawing.Point(754, 180);
            this.kgst_txtbox.Name = "kgst_txtbox";
            this.kgst_txtbox.Size = new System.Drawing.Size(429, 22);
            this.kgst_txtbox.TabIndex = 2;
            // 
            // Kgstno_label
            // 
            this.Kgstno_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kgstno_label.AutoSize = true;
            this.Kgstno_label.BackColor = System.Drawing.Color.Transparent;
            this.Kgstno_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kgstno_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Kgstno_label.Location = new System.Drawing.Point(612, 182);
            this.Kgstno_label.Name = "Kgstno_label";
            this.Kgstno_label.Size = new System.Drawing.Size(69, 19);
            this.Kgstno_label.TabIndex = 74;
            this.Kgstno_label.Text = "Kgst.No.";
            // 
            // PhoneNo_txtbox
            // 
            this.PhoneNo_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneNo_txtbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo_txtbox.Location = new System.Drawing.Point(754, 210);
            this.PhoneNo_txtbox.Name = "PhoneNo_txtbox";
            this.PhoneNo_txtbox.Size = new System.Drawing.Size(429, 22);
            this.PhoneNo_txtbox.TabIndex = 3;
            // 
            // Location_txtbox
            // 
            this.Location_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Location_txtbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_txtbox.Location = new System.Drawing.Point(754, 148);
            this.Location_txtbox.Name = "Location_txtbox";
            this.Location_txtbox.Size = new System.Drawing.Size(429, 22);
            this.Location_txtbox.TabIndex = 1;
            // 
            // Branchname_txtbox
            // 
            this.Branchname_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Branchname_txtbox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branchname_txtbox.Location = new System.Drawing.Point(754, 118);
            this.Branchname_txtbox.Name = "Branchname_txtbox";
            this.Branchname_txtbox.Size = new System.Drawing.Size(429, 22);
            this.Branchname_txtbox.TabIndex = 0;
            // 
            // Phone_No_label
            // 
            this.Phone_No_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone_No_label.AutoSize = true;
            this.Phone_No_label.BackColor = System.Drawing.Color.Transparent;
            this.Phone_No_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_No_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Phone_No_label.Location = new System.Drawing.Point(612, 209);
            this.Phone_No_label.Name = "Phone_No_label";
            this.Phone_No_label.Size = new System.Drawing.Size(78, 19);
            this.Phone_No_label.TabIndex = 70;
            this.Phone_No_label.Text = "Phone No.";
            // 
            // Location_label
            // 
            this.Location_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Location_label.AutoSize = true;
            this.Location_label.BackColor = System.Drawing.Color.Transparent;
            this.Location_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Location_label.Location = new System.Drawing.Point(612, 151);
            this.Location_label.Name = "Location_label";
            this.Location_label.Size = new System.Drawing.Size(67, 19);
            this.Location_label.TabIndex = 69;
            this.Location_label.Text = "Location";
            // 
            // Branch_Name_label
            // 
            this.Branch_Name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Branch_Name_label.AutoSize = true;
            this.Branch_Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Branch_Name_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch_Name_label.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Branch_Name_label.Location = new System.Drawing.Point(612, 121);
            this.Branch_Name_label.Name = "Branch_Name_label";
            this.Branch_Name_label.Size = new System.Drawing.Size(101, 19);
            this.Branch_Name_label.TabIndex = 68;
            this.Branch_Name_label.Text = "Branch Name";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.error_label);
            this.panel1.Controls.Add(this.BranchID_Label);
            this.panel1.Controls.Add(this.BranchMaster_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Branch_Name_label);
            this.panel1.Controls.Add(this.Branchmaster_datagrid);
            this.panel1.Controls.Add(this.Location_label);
            this.panel1.Controls.Add(this.Phone_No_label);
            this.panel1.Controls.Add(this.Delete_button);
            this.panel1.Controls.Add(this.Branchname_txtbox);
            this.panel1.Controls.Add(this.Clear_button);
            this.panel1.Controls.Add(this.Location_txtbox);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.PhoneNo_txtbox);
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Controls.Add(this.Kgstno_label);
            this.panel1.Controls.Add(this.Save_Button);
            this.panel1.Controls.Add(this.kgst_txtbox);
            this.panel1.Controls.Add(this.branchInfo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 381);
            this.panel1.TabIndex = 44;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(754, 317);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 15);
            this.error_label.TabIndex = 86;
            this.error_label.Visible = false;
            // 
            // branchInfo
            // 
            this.branchInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.branchInfo.Location = new System.Drawing.Point(596, 65);
            this.branchInfo.Name = "branchInfo";
            this.branchInfo.Size = new System.Drawing.Size(600, 290);
            this.branchInfo.TabIndex = 87;
            this.branchInfo.TabStop = false;
            this.branchInfo.Text = "Branch Informations";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 290);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Branch Informations Display";
            // 
            // BranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 384);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BranchMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BRANCH MASTER";
            ((System.ComponentModel.ISupportInitialize)(this.Branchmaster_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BranchMaster_label;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.TextBox kgst_txtbox;
        private System.Windows.Forms.Label Kgstno_label;
        private System.Windows.Forms.TextBox PhoneNo_txtbox;
        private System.Windows.Forms.TextBox Location_txtbox;
        private System.Windows.Forms.TextBox Branchname_txtbox;
        private System.Windows.Forms.Label Phone_No_label;
        private System.Windows.Forms.Label Location_label;
        private System.Windows.Forms.Label Branch_Name_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Branchmaster_datagrid;
        private System.Windows.Forms.Label BranchID_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.GroupBox branchInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}