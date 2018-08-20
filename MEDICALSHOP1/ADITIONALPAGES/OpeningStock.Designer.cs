namespace MEDICALSHOP1
{
    partial class OpeningStock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowSupplier_Radiobutton = new System.Windows.Forms.RadioButton();
            this.Date_label = new System.Windows.Forms.Label();
            this.ChequesNo_radiobutton = new System.Windows.Forms.RadioButton();
            this.Skipgst_radiobutton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Import_Button = new System.Windows.Forms.Button();
            this.Newcomm_button = new System.Windows.Forms.Button();
            this.Heading_Panel = new System.Windows.Forms.Panel();
            this.OpeningStock_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product_label = new System.Windows.Forms.Label();
            this.Amount_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.Product_replace = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.Heading_Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 240);
            this.dataGridView1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.ShowSupplier_Radiobutton);
            this.panel2.Controls.Add(this.Date_label);
            this.panel2.Controls.Add(this.ChequesNo_radiobutton);
            this.panel2.Controls.Add(this.Skipgst_radiobutton);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(60, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 76);
            this.panel2.TabIndex = 56;
            // 
            // ShowSupplier_Radiobutton
            // 
            this.ShowSupplier_Radiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowSupplier_Radiobutton.AutoSize = true;
            this.ShowSupplier_Radiobutton.Location = new System.Drawing.Point(453, 39);
            this.ShowSupplier_Radiobutton.Name = "ShowSupplier_Radiobutton";
            this.ShowSupplier_Radiobutton.Size = new System.Drawing.Size(89, 18);
            this.ShowSupplier_Radiobutton.TabIndex = 88;
            this.ShowSupplier_Radiobutton.TabStop = true;
            this.ShowSupplier_Radiobutton.Text = "Show Supplier";
            this.ShowSupplier_Radiobutton.UseVisualStyleBackColor = true;
            // 
            // Date_label
            // 
            this.Date_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.Location = new System.Drawing.Point(2, 15);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(32, 15);
            this.Date_label.TabIndex = 84;
            this.Date_label.Text = "Date";
            // 
            // ChequesNo_radiobutton
            // 
            this.ChequesNo_radiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChequesNo_radiobutton.AutoSize = true;
            this.ChequesNo_radiobutton.Location = new System.Drawing.Point(751, 39);
            this.ChequesNo_radiobutton.Name = "ChequesNo_radiobutton";
            this.ChequesNo_radiobutton.Size = new System.Drawing.Size(71, 18);
            this.ChequesNo_radiobutton.TabIndex = 85;
            this.ChequesNo_radiobutton.TabStop = true;
            this.ChequesNo_radiobutton.Text = "Skip Rack";
            this.ChequesNo_radiobutton.UseVisualStyleBackColor = true;
            this.ChequesNo_radiobutton.CheckedChanged += new System.EventHandler(this.ChequesNo_radiobutton_CheckedChanged);
            // 
            // Skipgst_radiobutton
            // 
            this.Skipgst_radiobutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Skipgst_radiobutton.AutoSize = true;
            this.Skipgst_radiobutton.Location = new System.Drawing.Point(750, 14);
            this.Skipgst_radiobutton.Name = "Skipgst_radiobutton";
            this.Skipgst_radiobutton.Size = new System.Drawing.Size(68, 18);
            this.Skipgst_radiobutton.TabIndex = 84;
            this.Skipgst_radiobutton.TabStop = true;
            this.Skipgst_radiobutton.Text = "Skip GST";
            this.Skipgst_radiobutton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.Value = new System.DateTime(2017, 8, 19, 0, 0, 0, 0);
            // 
            // Import_Button
            // 
            this.Import_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Import_Button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import_Button.Location = new System.Drawing.Point(194, 18);
            this.Import_Button.Name = "Import_Button";
            this.Import_Button.Size = new System.Drawing.Size(68, 30);
            this.Import_Button.TabIndex = 77;
            this.Import_Button.Text = "Import";
            this.Import_Button.UseVisualStyleBackColor = true;
            // 
            // Newcomm_button
            // 
            this.Newcomm_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Newcomm_button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newcomm_button.Location = new System.Drawing.Point(127, 18);
            this.Newcomm_button.Name = "Newcomm_button";
            this.Newcomm_button.Size = new System.Drawing.Size(68, 30);
            this.Newcomm_button.TabIndex = 78;
            this.Newcomm_button.Text = "New.Comm";
            this.Newcomm_button.UseVisualStyleBackColor = true;
            // 
            // Heading_Panel
            // 
            this.Heading_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Heading_Panel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Heading_Panel.Controls.Add(this.OpeningStock_label);
            this.Heading_Panel.Location = new System.Drawing.Point(60, 13);
            this.Heading_Panel.Name = "Heading_Panel";
            this.Heading_Panel.Size = new System.Drawing.Size(851, 44);
            this.Heading_Panel.TabIndex = 54;
            // 
            // OpeningStock_label
            // 
            this.OpeningStock_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpeningStock_label.AutoSize = true;
            this.OpeningStock_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpeningStock_label.Location = new System.Drawing.Point(340, 10);
            this.OpeningStock_label.Name = "OpeningStock_label";
            this.OpeningStock_label.Size = new System.Drawing.Size(122, 21);
            this.OpeningStock_label.TabIndex = 0;
            this.OpeningStock_label.Text = "Opening Stock";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.Product_replace);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Product_label);
            this.panel3.Controls.Add(this.Amount_label);
            this.panel3.Controls.Add(this.Import_Button);
            this.panel3.Controls.Add(this.clear_button);
            this.panel3.Controls.Add(this.Newcomm_button);
            this.panel3.Controls.Add(this.Close_button);
            this.panel3.Location = new System.Drawing.Point(60, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 117);
            this.panel3.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(677, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 20);
            this.textBox4.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 84;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 82;
            this.label4.Text = "Total Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 80;
            this.label1.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 81;
            this.label3.Text = "Total Amount";
            // 
            // Product_label
            // 
            this.Product_label.AutoSize = true;
            this.Product_label.Location = new System.Drawing.Point(627, 34);
            this.Product_label.Name = "Product_label";
            this.Product_label.Size = new System.Drawing.Size(43, 14);
            this.Product_label.TabIndex = 80;
            this.Product_label.Text = "Product";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(403, 34);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(45, 14);
            this.Amount_label.TabIndex = 79;
            this.Amount_label.Text = "Amount";
            // 
            // clear_button
            // 
            this.clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(1, 19);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(68, 30);
            this.clear_button.TabIndex = 77;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(67, 19);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(61, 30);
            this.Close_button.TabIndex = 78;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            // 
            // Product_replace
            // 
            this.Product_replace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Product_replace.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_replace.Location = new System.Drawing.Point(261, 18);
            this.Product_replace.Name = "Product_replace";
            this.Product_replace.Size = new System.Drawing.Size(108, 30);
            this.Product_replace.TabIndex = 85;
            this.Product_replace.Text = "Prodouct Replace";
            this.Product_replace.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 525);
            this.panel1.TabIndex = 58;
            // 
            // OpeningStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Heading_Panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OpeningStock";
            this.Text = "OpeningStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Heading_Panel.ResumeLayout(false);
            this.Heading_Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.RadioButton ChequesNo_radiobutton;
        private System.Windows.Forms.RadioButton Skipgst_radiobutton;
        private System.Windows.Forms.Button Import_Button;
        private System.Windows.Forms.Button Newcomm_button;
        private System.Windows.Forms.Panel Heading_Panel;
        private System.Windows.Forms.Label OpeningStock_label;
        private System.Windows.Forms.RadioButton ShowSupplier_Radiobutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Product_label;
        private System.Windows.Forms.Label Amount_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Product_replace;
        private System.Windows.Forms.Panel panel1;
    }
}