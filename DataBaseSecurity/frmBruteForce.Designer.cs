namespace DataBaseSecurity
{
    partial class frmBruteForce
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lstPasswordList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "DB Name : ";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(200, 49);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(271, 32);
            this.txtServerIP.TabIndex = 4;
            this.txtServerIP.Text = "192.168.74.128";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(200, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 32);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "SA";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(200, 194);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(271, 32);
            this.txtDBName.TabIndex = 6;
            this.txtDBName.Text = "MASTER";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(30, 26);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "...";
            // 
            // lstPasswordList
            // 
            this.lstPasswordList.FormattingEnabled = true;
            this.lstPasswordList.ItemHeight = 25;
            this.lstPasswordList.Location = new System.Drawing.Point(51, 346);
            this.lstPasswordList.Name = "lstPasswordList";
            this.lstPasswordList.Size = new System.Drawing.Size(420, 229);
            this.lstPasswordList.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Count : ";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(606, 46);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(116, 32);
            this.txtCount.TabIndex = 10;
            this.txtCount.Text = "1000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(540, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 38);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmBruteForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 585);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstPasswordList);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmBruteForce";
            this.Text = "frmBruteForce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ListBox lstPasswordList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnStart;
    }
}