namespace Miss
{
    partial class PagePost
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
            this.CreatePostTB = new System.Windows.Forms.Button();
            this.ShowPostTB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EditingDataBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePostTB
            // 
            this.CreatePostTB.BackColor = System.Drawing.Color.Transparent;
            this.CreatePostTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreatePostTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreatePostTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePostTB.Location = new System.Drawing.Point(120, 100);
            this.CreatePostTB.Name = "CreatePostTB";
            this.CreatePostTB.Size = new System.Drawing.Size(150, 46);
            this.CreatePostTB.TabIndex = 1;
            this.CreatePostTB.Text = "Create Post";
            this.CreatePostTB.UseVisualStyleBackColor = false;
            this.CreatePostTB.Click += new System.EventHandler(this.CreatePostTB_Click);
            // 
            // ShowPostTB
            // 
            this.ShowPostTB.BackColor = System.Drawing.Color.Transparent;
            this.ShowPostTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowPostTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShowPostTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPostTB.Location = new System.Drawing.Point(120, 170);
            this.ShowPostTB.Name = "ShowPostTB";
            this.ShowPostTB.Size = new System.Drawing.Size(150, 46);
            this.ShowPostTB.TabIndex = 2;
            this.ShowPostTB.Text = "Show Post";
            this.ShowPostTB.UseVisualStyleBackColor = false;
            this.ShowPostTB.Click += new System.EventHandler(this.ShowPostTB_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(120, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editing Post";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // EditingDataBT
            // 
            this.EditingDataBT.BackColor = System.Drawing.Color.Transparent;
            this.EditingDataBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditingDataBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EditingDataBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditingDataBT.Location = new System.Drawing.Point(120, 310);
            this.EditingDataBT.Name = "EditingDataBT";
            this.EditingDataBT.Size = new System.Drawing.Size(150, 46);
            this.EditingDataBT.TabIndex = 5;
            this.EditingDataBT.Text = "Editing Login and Password";
            this.EditingDataBT.UseVisualStyleBackColor = false;
            this.EditingDataBT.Click += new System.EventHandler(this.EditingDataBT_Click);
            // 
            // PagePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.EditingDataBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPostTB);
            this.Controls.Add(this.CreatePostTB);
            this.Name = "PagePost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagePost";
            this.Load += new System.EventHandler(this.PagePost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePostTB;
        private System.Windows.Forms.Button ShowPostTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditingDataBT;
    }
}