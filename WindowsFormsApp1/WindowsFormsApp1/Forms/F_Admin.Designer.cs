namespace WindowsFormsApp1.Forms
{
    partial class F_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Admin));
            this.Exit = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.bt_Catalog = new System.Windows.Forms.Button();
            this.bt_history = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_ChangeUser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(757, 605);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 56);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(75, 28);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(73, 32);
            this.lb_login.TabIndex = 15;
            this.lb_login.Text = "login";
            // 
            // bt_Catalog
            // 
            this.bt_Catalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Catalog.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Catalog.Location = new System.Drawing.Point(214, 144);
            this.bt_Catalog.Name = "bt_Catalog";
            this.bt_Catalog.Size = new System.Drawing.Size(259, 85);
            this.bt_Catalog.TabIndex = 16;
            this.bt_Catalog.Text = "Каталог Игр";
            this.bt_Catalog.UseVisualStyleBackColor = true;
            this.bt_Catalog.Click += new System.EventHandler(this.bt_Catalog_Click);
            // 
            // bt_history
            // 
            this.bt_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_history.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_history.Location = new System.Drawing.Point(214, 300);
            this.bt_history.Name = "bt_history";
            this.bt_history.Size = new System.Drawing.Size(259, 93);
            this.bt_history.TabIndex = 17;
            this.bt_history.Text = "Просмотр Истории Изменений";
            this.bt_history.UseVisualStyleBackColor = true;
            this.bt_history.Click += new System.EventHandler(this.bt_history_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bt_ChangeUser
            // 
            this.bt_ChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_ChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ChangeUser.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_ChangeUser.Location = new System.Drawing.Point(214, 459);
            this.bt_ChangeUser.Name = "bt_ChangeUser";
            this.bt_ChangeUser.Size = new System.Drawing.Size(259, 82);
            this.bt_ChangeUser.TabIndex = 18;
            this.bt_ChangeUser.Text = "Изменить Пользователя";
            this.bt_ChangeUser.UseVisualStyleBackColor = true;
            this.bt_ChangeUser.Click += new System.EventHandler(this.bt_ChangeUser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(443, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(756, 692);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // F_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.bt_ChangeUser);
            this.Controls.Add(this.bt_history);
            this.Controls.Add(this.bt_Catalog);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox2);
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "F_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Инструменты Администратора";
            this.Load += new System.EventHandler(this.F_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Button bt_Catalog;
        private System.Windows.Forms.Button bt_history;
        private System.Windows.Forms.Button bt_ChangeUser;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}