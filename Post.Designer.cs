namespace Miss
{
    partial class Post
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PostTB = new System.Windows.Forms.TextBox();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.EnterBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name Post";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Miss.Properties.Resources.pose_m23_p_1600;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PostTB
            // 
            this.PostTB.Location = new System.Drawing.Point(218, 80);
            this.PostTB.Name = "PostTB";
            this.PostTB.Size = new System.Drawing.Size(100, 20);
            this.PostTB.TabIndex = 7;
            this.PostTB.Text = "Post";
            // 
            // TextTB
            // 
            this.TextTB.Location = new System.Drawing.Point(218, 110);
            this.TextTB.Multiline = true;
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(296, 215);
            this.TextTB.TabIndex = 8;
            this.TextTB.Text = "Your text";
            this.TextTB.TextChanged += new System.EventHandler(this.TextTB_TextChanged);
            // 
            // EnterBT
            // 
            this.EnterBT.BackColor = System.Drawing.Color.Transparent;
            this.EnterBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnterBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnterBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBT.Location = new System.Drawing.Point(439, 340);
            this.EnterBT.Name = "EnterBT";
            this.EnterBT.Size = new System.Drawing.Size(75, 23);
            this.EnterBT.TabIndex = 9;
            this.EnterBT.Text = "Create Post";
            this.EnterBT.UseVisualStyleBackColor = false;
            this.EnterBT.Click += new System.EventHandler(this.EnterBT_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.EnterBT);
            this.Controls.Add(this.TextTB);
            this.Controls.Add(this.PostTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Post";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Post_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PostTB;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Button EnterBT;
    }
}