namespace WindowsFormsApp1.Forms
{
    partial class F_Worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Worker));
            this.bt_See = new System.Windows.Forms.Button();
            this.bt_buy = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_See
            // 
            this.bt_See.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_See.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_See.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_See.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_See.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_See.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_See.Location = new System.Drawing.Point(161, 229);
            this.bt_See.Name = "bt_See";
            this.bt_See.Size = new System.Drawing.Size(259, 95);
            this.bt_See.TabIndex = 1;
            this.bt_See.Text = "Просмотр Игр";
            this.bt_See.UseVisualStyleBackColor = true;
            this.bt_See.Click += new System.EventHandler(this.bt_See_Click);
            // 
            // bt_buy
            // 
            this.bt_buy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buy.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_buy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_buy.Location = new System.Drawing.Point(161, 357);
            this.bt_buy.Name = "bt_buy";
            this.bt_buy.Size = new System.Drawing.Size(259, 95);
            this.bt_buy.TabIndex = 2;
            this.bt_buy.Text = "Продажа Игр";
            this.bt_buy.UseVisualStyleBackColor = true;
            this.bt_buy.Click += new System.EventHandler(this.bt_buy_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Exit.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_Exit.Location = new System.Drawing.Point(803, 589);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(143, 56);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "ВЫЙТИ";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(75, 28);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(73, 32);
            this.lb_login.TabIndex = 17;
            this.lb_login.Text = "login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(625, -52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(445, 838);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // F_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_buy);
            this.Controls.Add(this.bt_See);
            this.Controls.Add(this.pictureBox2);
            this.Name = "F_Worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инструменты Работника";
            this.Load += new System.EventHandler(this.F_Worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_See;
        private System.Windows.Forms.Button bt_buy;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}