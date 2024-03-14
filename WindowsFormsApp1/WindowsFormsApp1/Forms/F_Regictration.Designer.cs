
namespace WindowsFormsApp1.Forms
{
    partial class F_Regictration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Regictration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ubdate = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Passport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.filial = new System.Windows.Forms.ComboBox();
            this.publishingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allData = new WindowsFormsApp1.AllData();
            this.shopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tinaVorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Post = new System.Windows.Forms.ComboBox();
            this.postBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoublePassword = new System.Windows.Forms.TextBox();
            this.Capha = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.postTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.PostTableAdapter();
            this.publishingTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.PublishingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaVorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(100, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(100, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16F);
            this.label4.Location = new System.Drawing.Point(99, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Повторите пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16F);
            this.label5.Location = new System.Drawing.Point(101, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Должность";
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullName.Location = new System.Drawing.Point(396, 46);
            this.FullName.Multiline = true;
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(207, 33);
            this.FullName.TabIndex = 5;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(396, 264);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(207, 33);
            this.Login.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Candara", 16F);
            this.button1.Location = new System.Drawing.Point(659, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ubdate
            // 
            this.Ubdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Ubdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ubdate.Font = new System.Drawing.Font("Candara", 16F);
            this.Ubdate.Location = new System.Drawing.Point(105, 593);
            this.Ubdate.Name = "Ubdate";
            this.Ubdate.Size = new System.Drawing.Size(176, 52);
            this.Ubdate.TabIndex = 11;
            this.Ubdate.Text = "ОБНОВИТЬ";
            this.Ubdate.UseVisualStyleBackColor = true;
            this.Ubdate.Click += new System.EventHandler(this.Ubdate_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(822, 593);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 52);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "ВЫЙТИ";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16F);
            this.label6.Location = new System.Drawing.Point(99, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите текст";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(602, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 628);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(105, 497);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(176, 81);
            this.PictureBox.TabIndex = 13;
            this.PictureBox.TabStop = false;
            // 
            // Passport
            // 
            this.Passport.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport.Location = new System.Drawing.Point(396, 210);
            this.Passport.Multiline = true;
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(207, 33);
            this.Passport.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(99, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Номер паспорта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(101, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 19;
            this.label8.Text = "Филиал";
            // 
            // filial
            // 
            this.filial.DataSource = this.publishingBindingSource;
            this.filial.DisplayMember = "Name_Publishing";
            this.filial.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filial.FormattingEnabled = true;
            this.filial.Location = new System.Drawing.Point(396, 147);
            this.filial.Name = "filial";
            this.filial.Size = new System.Drawing.Size(207, 32);
            this.filial.TabIndex = 20;
            // 
            // publishingBindingSource
            // 
            this.publishingBindingSource.DataMember = "Publishing";
            this.publishingBindingSource.DataSource = this.allDataBindingSource;
            // 
            // allDataBindingSource
            // 
            this.allDataBindingSource.DataSource = this.allData;
            this.allDataBindingSource.Position = 0;
            // 
            // allData
            // 
            this.allData.DataSetName = "AllData";
            this.allData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Post
            // 
            this.Post.DataSource = this.postBindingSource2;
            this.Post.DisplayMember = "Name";
            this.Post.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post.FormattingEnabled = true;
            this.Post.Location = new System.Drawing.Point(396, 97);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(207, 32);
            this.Post.TabIndex = 21;
            // 
            // postBindingSource2
            // 
            this.postBindingSource2.DataMember = "Post";
            this.postBindingSource2.DataSource = this.allDataBindingSource;
            // 
            // DoublePassword
            // 
            this.DoublePassword.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoublePassword.Location = new System.Drawing.Point(396, 386);
            this.DoublePassword.Multiline = true;
            this.DoublePassword.Name = "DoublePassword";
            this.DoublePassword.PasswordChar = '*';
            this.DoublePassword.Size = new System.Drawing.Size(207, 33);
            this.DoublePassword.TabIndex = 3;
            // 
            // Capha
            // 
            this.Capha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Capha.Location = new System.Drawing.Point(396, 443);
            this.Capha.Multiline = true;
            this.Capha.Name = "Capha";
            this.Capha.PasswordChar = '*';
            this.Capha.Size = new System.Drawing.Size(207, 33);
            this.Capha.TabIndex = 3;
            this.Capha.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(396, 324);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(207, 33);
            this.Password.TabIndex = 24;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // publishingTableAdapter
            // 
            this.publishingTableAdapter.ClearBeforeFill = true;
            // 
            // F_Regictration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Capha);
            this.Controls.Add(this.DoublePassword);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.filial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ubdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "F_Regictration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.F_Regictration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinaVorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Ubdate;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Passport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filial;
        private System.Windows.Forms.BindingSource tinaVorDataSetBindingSource;
        private System.Windows.Forms.ComboBox Post;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource shopBindingSource;

        private System.Windows.Forms.BindingSource postBindingSource1;
     
       
        private System.Windows.Forms.BindingSource shopBindingSource1;

        private System.Windows.Forms.TextBox DoublePassword;
        private System.Windows.Forms.TextBox Capha;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.BindingSource allDataBindingSource;
        private AllData allData;
        private System.Windows.Forms.BindingSource postBindingSource2;
        private AllDataTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource publishingBindingSource;
        private AllDataTableAdapters.PublishingTableAdapter publishingTableAdapter;
    }
}