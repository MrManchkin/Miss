namespace Miss
{
    partial class EditingData
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
            this.NewNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceNameBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LastPassTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.RepeatPassTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewNameTB
            // 
            this.NewNameTB.Location = new System.Drawing.Point(215, 140);
            this.NewNameTB.Name = "NewNameTB";
            this.NewNameTB.Size = new System.Drawing.Size(100, 20);
            this.NewNameTB.TabIndex = 10;
            this.NewNameTB.Text = "New Name";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(215, 110);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(100, 20);
            this.LastNameTB.TabIndex = 9;
            this.LastNameTB.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(212, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editing Name";
            // 
            // ReplaceNameBT
            // 
            this.ReplaceNameBT.BackColor = System.Drawing.Color.Transparent;
            this.ReplaceNameBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReplaceNameBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReplaceNameBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceNameBT.Location = new System.Drawing.Point(215, 170);
            this.ReplaceNameBT.Name = "ReplaceNameBT";
            this.ReplaceNameBT.Size = new System.Drawing.Size(100, 23);
            this.ReplaceNameBT.TabIndex = 6;
            this.ReplaceNameBT.Text = "Replace Name";
            this.ReplaceNameBT.UseVisualStyleBackColor = false;
            this.ReplaceNameBT.Click += new System.EventHandler(this.ReplaceNameTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Miss.Properties.Resources.pose_f30_p_1080;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LastPassTB
            // 
            this.LastPassTB.Location = new System.Drawing.Point(215, 269);
            this.LastPassTB.Name = "LastPassTB";
            this.LastPassTB.Size = new System.Drawing.Size(100, 20);
            this.LastPassTB.TabIndex = 14;
            this.LastPassTB.Text = "Last Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Editing Password";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(215, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Replace Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(215, 299);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(100, 20);
            this.PassTB.TabIndex = 15;
            this.PassTB.Text = "New Password";
            // 
            // RepeatPassTB
            // 
            this.RepeatPassTB.Location = new System.Drawing.Point(215, 325);
            this.RepeatPassTB.Name = "RepeatPassTB";
            this.RepeatPassTB.Size = new System.Drawing.Size(100, 20);
            this.RepeatPassTB.TabIndex = 16;
            this.RepeatPassTB.Text = "Repeat Password";
            // 
            // EditingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.RepeatPassTB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LastPassTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewNameTB);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceNameBT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EditingData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditingData";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewNameTB;
        public System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReplaceNameBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox LastPassTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox RepeatPassTB;
    }
}