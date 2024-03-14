namespace WindowsFormsApp1.Forms
{
    partial class F_ChangeGamecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ChangeGamecs));
            this.txt_NewAge = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_AddGame = new System.Windows.Forms.Button();
            this.ChangeAge = new System.Windows.Forms.Button();
            this.ChangePub = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Publishing = new System.Windows.Forms.ComboBox();
            this.publishingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allData = new WindowsFormsApp1.AllData();
            this.Limitation = new System.Windows.Forms.ComboBox();
            this.limitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameGame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_OldAge = new System.Windows.Forms.ComboBox();
            this.limitationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_OldName = new System.Windows.Forms.ComboBox();
            this.publishingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_NewName = new System.Windows.Forms.TextBox();
            this.publishingTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.PublishingTableAdapter();
            this.limitationTableAdapter = new WindowsFormsApp1.AllDataTableAdapters.LimitationTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NewAge
            // 
            this.txt_NewAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NewAge.Location = new System.Drawing.Point(160, 614);
            this.txt_NewAge.Multiline = true;
            this.txt_NewAge.Name = "txt_NewAge";
            this.txt_NewAge.Size = new System.Drawing.Size(215, 33);
            this.txt_NewAge.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 80);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсказка, Друг!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F);
            this.label2.Location = new System.Drawing.Point(47, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "Так же можно изменить издательство или возраст    ";
            // 
            // bt_AddGame
            // 
            this.bt_AddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_AddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddGame.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddGame.Location = new System.Drawing.Point(16, 290);
            this.bt_AddGame.Name = "bt_AddGame";
            this.bt_AddGame.Size = new System.Drawing.Size(734, 49);
            this.bt_AddGame.TabIndex = 65;
            this.bt_AddGame.Text = "Изменить игру";
            this.bt_AddGame.UseVisualStyleBackColor = true;
            this.bt_AddGame.Click += new System.EventHandler(this.bt_AddGame_Click);
            // 
            // ChangeAge
            // 
            this.ChangeAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.ChangeAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeAge.Location = new System.Drawing.Point(16, 487);
            this.ChangeAge.Name = "ChangeAge";
            this.ChangeAge.Size = new System.Drawing.Size(359, 61);
            this.ChangeAge.TabIndex = 64;
            this.ChangeAge.Text = "Изменить возраст продажи";
            this.ChangeAge.UseVisualStyleBackColor = true;
            this.ChangeAge.Click += new System.EventHandler(this.ChangeAge_Click);
            // 
            // ChangePub
            // 
            this.ChangePub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.ChangePub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePub.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePub.Location = new System.Drawing.Point(422, 487);
            this.ChangePub.Name = "ChangePub";
            this.ChangePub.Size = new System.Drawing.Size(328, 61);
            this.ChangePub.TabIndex = 63;
            this.ChangePub.Text = "Изменить издательство";
            this.ChangePub.UseVisualStyleBackColor = true;
            this.ChangePub.Click += new System.EventHandler(this.ChangePub_Click_1);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(829, 576);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(126, 54);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "НАЗАД";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Publishing
            // 
            this.Publishing.DataSource = this.publishingBindingSource;
            this.Publishing.DisplayMember = "Name_Publishing";
            this.Publishing.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Publishing.FormattingEnabled = true;
            this.Publishing.Location = new System.Drawing.Point(419, 96);
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(272, 32);
            this.Publishing.TabIndex = 61;
            // 
            // publishingBindingSource
            // 
            this.publishingBindingSource.DataMember = "Publishing";
            this.publishingBindingSource.DataSource = this.allData;
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
            this.Limitation.Location = new System.Drawing.Point(419, 168);
            this.Limitation.Name = "Limitation";
            this.Limitation.Size = new System.Drawing.Size(272, 32);
            this.Limitation.TabIndex = 60;
            // 
            // limitationBindingSource
            // 
            this.limitationBindingSource.DataMember = "Limitation";
            this.limitationBindingSource.DataSource = this.allData;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 16F);
            this.label8.Location = new System.Drawing.Point(91, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 33);
            this.label8.TabIndex = 59;
            this.label8.Text = "Возраст продажи";
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost.Location = new System.Drawing.Point(419, 227);
            this.Cost.Multiline = true;
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(272, 33);
            this.Cost.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 16F);
            this.label7.Location = new System.Drawing.Point(91, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 33);
            this.label7.TabIndex = 57;
            this.label7.Text = "Стоимость";
            // 
            // NameGame
            // 
            this.NameGame.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGame.Location = new System.Drawing.Point(419, 41);
            this.NameGame.Multiline = true;
            this.NameGame.Name = "NameGame";
            this.NameGame.Size = new System.Drawing.Size(272, 33);
            this.NameGame.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16F);
            this.label5.Location = new System.Drawing.Point(91, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 33);
            this.label5.TabIndex = 55;
            this.label5.Text = "Издательство";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F);
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "Название";
            // 
            // cb_OldAge
            // 
            this.cb_OldAge.DataSource = this.limitationBindingSource1;
            this.cb_OldAge.DisplayMember = "Age";
            this.cb_OldAge.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_OldAge.FormattingEnabled = true;
            this.cb_OldAge.Location = new System.Drawing.Point(160, 571);
            this.cb_OldAge.Name = "cb_OldAge";
            this.cb_OldAge.Size = new System.Drawing.Size(215, 32);
            this.cb_OldAge.TabIndex = 69;
            // 
            // limitationBindingSource1
            // 
            this.limitationBindingSource1.DataMember = "Limitation";
            this.limitationBindingSource1.DataSource = this.allData;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Новый возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Старый возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(418, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "Старое имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(418, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 75;
            this.label9.Text = "Новое имя";
            // 
            // cb_OldName
            // 
            this.cb_OldName.DataSource = this.publishingBindingSource1;
            this.cb_OldName.DisplayMember = "Name_Publishing";
            this.cb_OldName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_OldName.FormattingEnabled = true;
            this.cb_OldName.Location = new System.Drawing.Point(535, 568);
            this.cb_OldName.Name = "cb_OldName";
            this.cb_OldName.Size = new System.Drawing.Size(215, 32);
            this.cb_OldName.TabIndex = 74;
            // 
            // publishingBindingSource1
            // 
            this.publishingBindingSource1.DataMember = "Publishing";
            this.publishingBindingSource1.DataSource = this.allData;
            // 
            // txt_NewName
            // 
            this.txt_NewName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_NewName.Location = new System.Drawing.Point(535, 611);
            this.txt_NewName.Multiline = true;
            this.txt_NewName.Name = "txt_NewName";
            this.txt_NewName.Size = new System.Drawing.Size(215, 33);
            this.txt_NewName.TabIndex = 73;
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
            this.pictureBox1.Location = new System.Drawing.Point(697, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // F_ChangeGamecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_OldName);
            this.Controls.Add(this.txt_NewName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_OldAge);
            this.Controls.Add(this.txt_NewAge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_AddGame);
            this.Controls.Add(this.ChangeAge);
            this.Controls.Add(this.ChangePub);
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
            this.Name = "F_ChangeGamecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить Игру";
            this.Load += new System.EventHandler(this.F_ChangeGamecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NewAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_AddGame;
        private System.Windows.Forms.Button ChangeAge;
        private System.Windows.Forms.Button ChangePub;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox Publishing;
        private System.Windows.Forms.ComboBox Limitation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_OldAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_OldName;
        private System.Windows.Forms.TextBox txt_NewName;
        private AllData allData;
        private System.Windows.Forms.BindingSource publishingBindingSource;
        private AllDataTableAdapters.PublishingTableAdapter publishingTableAdapter;
        private System.Windows.Forms.BindingSource limitationBindingSource;
        private AllDataTableAdapters.LimitationTableAdapter limitationTableAdapter;
        private System.Windows.Forms.BindingSource limitationBindingSource1;
        private System.Windows.Forms.BindingSource publishingBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}