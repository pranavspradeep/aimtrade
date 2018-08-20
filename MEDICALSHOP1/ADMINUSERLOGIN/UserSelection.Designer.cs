namespace MEDICALSHOP1
{
    partial class UserSelection
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
            this.User_btn = new System.Windows.Forms.Button();
            this.Admin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User_btn
            // 
            this.User_btn.BackgroundImage = global::MEDICALSHOP1.Properties.Resources.User_botton;
            this.User_btn.Location = new System.Drawing.Point(69, 30);
            this.User_btn.Name = "User_btn";
            this.User_btn.Size = new System.Drawing.Size(184, 47);
            this.User_btn.TabIndex = 0;
            this.User_btn.UseVisualStyleBackColor = true;
            this.User_btn.Click += new System.EventHandler(this.User_btn_Click);
            // 
            // Admin_btn
            // 
            this.Admin_btn.BackgroundImage = global::MEDICALSHOP1.Properties.Resources.admin_button;
            this.Admin_btn.Location = new System.Drawing.Point(260, 30);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(180, 47);
            this.Admin_btn.TabIndex = 1;
            this.Admin_btn.UseVisualStyleBackColor = true;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(507, 131);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.User_btn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button User_btn;
        private System.Windows.Forms.Button Admin_btn;
    }
}