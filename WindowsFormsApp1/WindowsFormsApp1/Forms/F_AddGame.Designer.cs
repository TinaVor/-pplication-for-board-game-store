
namespace WindowsFormsApp1.Forms
{
    partial class F_AddGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AddGame));
            this.Publishing = new System.Windows.Forms.ComboBox();
            this.publishingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allData = new WindowsFormsApp1.AllData();
            this.Limitation = new System.Windows.Forms.ComboBox();
            this.limitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameGame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.AddNewPub = new System.Windows.Forms.Button();
            this.AddNewAge = new System.Windows.Forms.Button();
            this.bt_AddGame = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_NewAge = new System.Windows.Forms.TextBox();
            this.txt_NewPub = new System.Windows.Forms.TextBox();
            this.publishingTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.PublishingTableAdapter();
            this.limitationTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.LimitationTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Publishing
            // 
            this.Publishing.DataSource = this.publishingBindingSource;
            this.Publishing.DisplayMember = "Name_Publishing";
            this.Publishing.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Publishing.FormattingEnabled = true;
            this.Publishing.Location = new System.Drawing.Point(377, 124);
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(272, 32);
            this.Publishing.TabIndex = 39;
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
            // Limitation
            // 
            this.Limitation.DataSource = this.limitationBindingSource;
            this.Limitation.DisplayMember = "Age";
            this.Limitation.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Limitation.FormattingEnabled = true;
            this.Limitation.Location = new System.Drawing.Point(377, 196);
            this.Limitation.Name = "Limitation";
            this.Limitation.Size = new System.Drawing.Size(272, 32);
            this.Limitation.TabIndex = 38;
            this.Limitation.ValueMember = "Age";
            // 
            // limitationBindingSource
            // 
            this.limitationBindingSource.DataMember = "Limitation";
            this.limitationBindingSource.DataSource = this.allDataBindingSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(49, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 33);
            this.label8.TabIndex = 37;
            this.label8.Text = "Возраст продажи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(49, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 33);
            this.label7.TabIndex = 35;
            this.label7.Text = "Стоимость";
            // 
            // NameGame
            // 
            this.NameGame.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGame.Location = new System.Drawing.Point(377, 69);
            this.NameGame.Multiline = true;
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(272, 33);
            this.NameGame.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16F);
            this.label5.Location = new System.Drawing.Point(49, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 33);
            this.label5.TabIndex = 31;
            this.label5.Text = "Издательство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Название";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(828, 613);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(142, 48);
            this.Exit.TabIndex = 41;
            this.Exit.Text = "НАЗАД";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddNewPub
            // 
            this.AddNewPub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.AddNewPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewPub.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewPub.Location = new System.Drawing.Point(435, 565);
            this.AddNewPub.Name = "AddNewPub";
            this.AddNewPub.Size = new System.Drawing.Size(298, 61);
            this.AddNewPub.TabIndex = 43;
            this.AddNewPub.Text = "Добавить новое издательство";
            this.AddNewPub.UseVisualStyleBackColor = true;
            this.AddNewPub.Click += new System.EventHandler(this.AddNewPub_Click);
            // 
            // AddNewAge
            // 
            this.AddNewAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.AddNewAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewAge.Location = new System.Drawing.Point(55, 565);
            this.AddNewAge.Name = "AddNewAge";
            this.AddNewAge.Size = new System.Drawing.Size(298, 61);
            this.AddNewAge.TabIndex = 44;
            this.AddNewAge.Text = "Добавить новый возраст продажи";
            this.AddNewAge.UseVisualStyleBackColor = true;
            this.AddNewAge.Click += new System.EventHandler(this.AddNewAge_Click);
            // 
            // bt_AddGame
            // 
            this.bt_AddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_AddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddGame.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddGame.Location = new System.Drawing.Point(42, 321);
            this.bt_AddGame.Name = "bt_AddGame";
            this.bt_AddGame.Size = new System.Drawing.Size(691, 49);
            this.bt_AddGame.TabIndex = 46;
            this.bt_AddGame.Text = "Добавить игру";
            this.bt_AddGame.UseVisualStyleBackColor = true;
            this.bt_AddGame.Click += new System.EventHandler(this.bt_AddGame_Click);
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.Location = new System.Drawing.Point(377, 255);
            this.Cost.Multiline = true;
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(272, 33);
            this.Cost.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(47, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "Не нашел нужное изтательство или возраст продажи? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F);
            this.label3.Location = new System.Drawing.Point(140, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 33);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ты можете добавить свое!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(42, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 130);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсказка, Друг!";
            // 
            // txt_NewAge
            // 
            this.txt_NewAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NewAge.Location = new System.Drawing.Point(95, 632);
            this.txt_NewAge.Multiline = true;
            this.txt_NewAge.Name = "txt_NewAge";
            this.txt_NewAge.Size = new System.Drawing.Size(215, 33);
            this.txt_NewAge.TabIndex = 52;
            // 
            // txt_NewPub
            // 
            this.txt_NewPub.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NewPub.Location = new System.Drawing.Point(471, 632);
            this.txt_NewPub.Multiline = true;
            this.txt_NewPub.Name = "txt_NewPub";
            this.txt_NewPub.Size = new System.Drawing.Size(229, 33);
            this.txt_NewPub.TabIndex = 53;
            // 
            // publishingTableAdapter
            // 
            this.publishingTableAdapter.ClearBeforeFill = true;
            // 
            // limitationTableAdapter
            // 
            this.limitationTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 638);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // F_AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.txt_NewPub);
            this.Controls.Add(this.txt_NewAge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_AddGame);
            this.Controls.Add(this.AddNewAge);
            this.Controls.Add(this.AddNewPub);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Publishing);
            this.Controls.Add(this.Limitation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "F_AddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_AddGame";
            this.Load += new System.EventHandler(this.F_AddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Publishing;
        private System.Windows.Forms.ComboBox Limitation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddNewPub;
        private System.Windows.Forms.Button AddNewAge;
        private System.Windows.Forms.Button bt_AddGame;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NewAge;
        private System.Windows.Forms.TextBox txt_NewPub;
        private System.Windows.Forms.BindingSource allDataBindingSource;
        private AllData allData;
        private System.Windows.Forms.BindingSource publishingBindingSource;
        private AllDataTableAdapters.PublishingTableAdapter publishingTableAdapter;
        private System.Windows.Forms.BindingSource limitationBindingSource;
        private AllDataTableAdapters.LimitationTableAdapter limitationTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}