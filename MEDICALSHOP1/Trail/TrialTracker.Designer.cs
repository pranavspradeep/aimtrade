namespace MEDICALSHOP1.Trail
{
    partial class TrialTracker
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
            this.trialbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.conttrail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.conttrail);
            this.panel1.Controls.Add(this.trialbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(94, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 305);
            this.panel1.TabIndex = 0;
            // 
            // trialbtn
            // 
            this.trialbtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.trialbtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialbtn.Location = new System.Drawing.Point(191, 153);
            this.trialbtn.Name = "trialbtn";
            this.trialbtn.Size = new System.Drawing.Size(178, 33);
            this.trialbtn.TabIndex = 4;
            this.trialbtn.Text = "start trial version";
            this.trialbtn.UseVisualStyleBackColor = false;
            this.trialbtn.Visible = false;
            this.trialbtn.Click += new System.EventHandler(this.trialbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone number:9495840799,7561028710,7510511969";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "website:www.aimsoftsoloutions.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thank You For Choosing Aimsoft soloution as your technology partner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO TRIAL VERSION OF AIMSOFT SOLOUTIONS INVENTORY MANAGEMENT SYSTEM";
            // 
            // conttrail
            // 
            this.conttrail.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.conttrail.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conttrail.Location = new System.Drawing.Point(191, 192);
            this.conttrail.Name = "conttrail";
            this.conttrail.Size = new System.Drawing.Size(178, 33);
            this.conttrail.TabIndex = 5;
            this.conttrail.Text = "continue trial version";
            this.conttrail.UseVisualStyleBackColor = false;
            this.conttrail.Visible = false;
            this.conttrail.Click += new System.EventHandler(this.conttrail_Click);
            // 
            // TrialTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 372);
            this.Controls.Add(this.panel1);
            this.Name = "TrialTracker";
            this.Text = "TrialTracker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button trialbtn;
        private System.Windows.Forms.Button conttrail;
    }
}