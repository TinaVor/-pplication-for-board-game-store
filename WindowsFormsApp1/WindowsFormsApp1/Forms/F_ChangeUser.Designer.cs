namespace WindowsFormsApp1.Forms
{
    partial class F_ChangeUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ChangeUser));
            this.Password = new System.Windows.Forms.TextBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_Change = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Full_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filial = new System.Windows.Forms.ComboBox();
            this.Post = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allData = new WindowsFormsApp1.AllData();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.PostTableAdapter();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.ShopTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(248, 313);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(207, 33);
            this.Password.TabIndex = 45;
            // 
            // Passport
            // 
            this.Passport.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport.Location = new System.Drawing.Point(248, 207);
            this.Passport.Multiline = true;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(207, 33);
            this.Passport.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 33);
            this.label7.TabIndex = 40;
            this.label7.Text = "Номер паспорта";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(1336, 689);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 52);
            this.Exit.TabIndex = 36;
            this.Exit.Text = "НАЗАД";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_Change
            // 
            this.bt_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Change.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Change.Location = new System.Drawing.Point(6, 393);
            this.bt_Change.Name = "bt_Change";
            this.bt_Change.Size = new System.Drawing.Size(472, 52);
            this.bt_Change.TabIndex = 34;
            this.bt_Change.Text = "ИЗМЕНИТЬ ПОЛЬЗОВАТЕЛЯ";
            this.bt_Change.UseVisualStyleBackColor = true;
            this.bt_Change.Click += new System.EventHandler(this.bt_Change_Click);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(248, 261);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(207, 33);
            this.Login.TabIndex = 33;
            // 
            // Full_Name
            // 
            this.Full_Name.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Full_Name.Location = new System.Drawing.Point(248, 52);
            this.Full_Name.Multiline = true;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Size = new System.Drawing.Size(207, 33);
            this.Full_Name.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(22, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16F);
            this.label6.Location = new System.Drawing.Point(75, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 33);
            this.label6.TabIndex = 47;
            this.label6.Text = "ID";
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Id.Location = new System.Drawing.Point(273, 42);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(205, 33);
            this.txt_Id.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.filial);
            this.groupBox1.Controls.Add(this.Post);
            this.groupBox1.Controls.Add(this.Full_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.bt_Change);
            this.groupBox1.Controls.Add(this.Passport);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(25, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 456);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите новые";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(23, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 53;
            this.label8.Text = "Филиал";
            // 
            // filial
            // 
            this.filial.DataSource = this.shopBindingSource;
            this.filial.DisplayMember = "Name";
            this.filial.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filial.FormattingEnabled = true;
            this.filial.Location = new System.Drawing.Point(248, 158);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(207, 32);
            this.filial.TabIndex = 54;
            // 
            // Post
            // 
            this.Post.DataSource = this.postBindingSource;
            this.Post.DisplayMember = "Name";
            this.Post.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post.FormattingEnabled = true;
            this.Post.Location = new System.Drawing.Point(248, 106);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(207, 32);
            this.Post.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16F);
            this.label5.Location = new System.Drawing.Point(22, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 33);
            this.label5.TabIndex = 52;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F);
            this.label4.Location = new System.Drawing.Point(700, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 33);
            this.label4.TabIndex = 46;
            this.label4.Text = "Изменить пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-124, 590);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 549);
            this.dataGridView1.TabIndex = 51;
            // 
            // allData
            // 
            this.allData.DataSetName = "AllData";
            this.allData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.allData;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "Shop";
            this.shopBindingSource.DataSource = this.allData;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // F_ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "F_ChangeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить Пользователя";
            this.Load += new System.EventHandler(this.F_ChangeUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_Change;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Full_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filial;
        private System.Windows.Forms.ComboBox Post;
        private System.Windows.Forms.Label label5;
        private AllData allData;
        private System.Windows.Forms.BindingSource postBindingSource;
        private AllDataTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private AllDataTableAdapters.ShopTableAdapter shopTableAdapter;
    }
}