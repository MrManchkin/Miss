namespace Miss
{
    partial class Registration
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
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RepeatPasswordTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(215, 170);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 11;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.MouseEnter += new System.EventHandler(this.PasswordTB_MouseEnter);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(215, 140);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 20);
            this.LoginTB.TabIndex = 10;
            this.LoginTB.Text = "Name";
            this.LoginTB.TextChanged += new System.EventHandler(this.LoginTB_TextChanged);
            this.LoginTB.MouseEnter += new System.EventHandler(this.LoginTB_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome";
            // 
            // EnterBT
            // 
            this.EnterBT.BackColor = System.Drawing.Color.Transparent;
            this.EnterBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBT.Location = new System.Drawing.Point(230, 240);
            this.EnterBT.Name = "EnterBT";
            this.EnterBT.Size = new System.Drawing.Size(75, 23);
            this.EnterBT.TabIndex = 7;
            this.EnterBT.Text = "Registration";
            this.EnterBT.UseVisualStyleBackColor = false;
            this.EnterBT.Click += new System.EventHandler(this.EnterBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Miss.Properties.Resources.image_1811;
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // RepeatPasswordTB
            // 
            this.RepeatPasswordTB.Location = new System.Drawing.Point(215, 200);
            this.RepeatPasswordTB.Name = "RepeatPasswordTB";
            this.RepeatPasswordTB.Size = new System.Drawing.Size(100, 20);
            this.RepeatPasswordTB.TabIndex = 12;
            this.RepeatPasswordTB.Text = "Repeat Password";
            this.RepeatPasswordTB.MouseEnter += new System.EventHandler(this.RepeatPasswordTB_MouseEnter);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.RepeatPasswordTB);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterBT;
        private System.Windows.Forms.TextBox RepeatPasswordTB;
    }
}