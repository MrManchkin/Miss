namespace Miss
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EnterBT = new System.Windows.Forms.Button();
            this.RegBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterBT
            // 
            this.EnterBT.BackColor = System.Drawing.Color.Transparent;
            this.EnterBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnterBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnterBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBT.Location = new System.Drawing.Point(230, 200);
            this.EnterBT.Name = "EnterBT";
            this.EnterBT.Size = new System.Drawing.Size(75, 23);
            this.EnterBT.TabIndex = 0;
            this.EnterBT.Text = "Login";
            this.EnterBT.UseVisualStyleBackColor = false;
            this.EnterBT.Click += new System.EventHandler(this.EnterBT_Click);
            // 
            // RegBT
            // 
            this.RegBT.BackColor = System.Drawing.Color.Transparent;
            this.RegBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBT.Location = new System.Drawing.Point(198, 306);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(128, 23);
            this.RegBT.TabIndex = 1;
            this.RegBT.Text = "Registration Account";
            this.RegBT.UseVisualStyleBackColor = false;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(215, 140);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 20);
            this.LoginTB.TabIndex = 3;
            this.LoginTB.Text = "Vanya";
            this.LoginTB.MouseEnter += new System.EventHandler(this.LoginTB_MouseEnter);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(215, 170);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.Text = "12345";
            this.PasswordTB.MouseEnter += new System.EventHandler(this.PasswordTB_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBT);
            this.Controls.Add(this.EnterBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBT;
        private System.Windows.Forms.Button RegBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox LoginTB;
    }
}

