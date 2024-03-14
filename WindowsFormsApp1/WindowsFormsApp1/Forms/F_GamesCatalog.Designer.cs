namespace WindowsFormsApp1.Forms
{
    partial class F_GamesCatalog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Chenge = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_Del = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Chenge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 606);
            this.dataGridView1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Candara", 16F);
            this.Exit.Location = new System.Drawing.Point(805, 602);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(153, 48);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "НАЗАД";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Add.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Add.Location = new System.Drawing.Point(805, 62);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(153, 58);
            this.bt_Add.TabIndex = 15;
            this.bt_Add.Text = "Добавить";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Chenge
            // 
            this.bt_Chenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_Chenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Chenge.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_Chenge.Location = new System.Drawing.Point(11, 110);
            this.bt_Chenge.Name = "bt_Chenge";
            this.bt_Chenge.Size = new System.Drawing.Size(153, 52);
            this.bt_Chenge.TabIndex = 16;
            this.bt_Chenge.Text = "Изменить";
            this.bt_Chenge.UseVisualStyleBackColor = true;
            this.bt_Chenge.Click += new System.EventHandler(this.bt_Chenge_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(207)))), ((int)(((byte)(246)))));
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Candara", 16F);
            this.bt_delete.Location = new System.Drawing.Point(11, 113);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(153, 52);
            this.bt_delete.TabIndex = 17;
            this.bt_delete.Text = "Удалить";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.UseWaitCursor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_Del
            // 
            this.tb_Del.Location = new System.Drawing.Point(11, 56);
            this.tb_Del.Name = "tb_Del";
            this.tb_Del.Size = new System.Drawing.Size(153, 36);
            this.tb_Del.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_delete);
            this.groupBox1.Controls.Add(this.tb_Del);
            this.groupBox1.Location = new System.Drawing.Point(794, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 186);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tb_Chenge);
            this.groupBox2.Controls.Add(this.bt_Chenge);
            this.groupBox2.Location = new System.Drawing.Point(794, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 194);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите ID";
            // 
            // tb_Chenge
            // 
            this.tb_Chenge.Location = new System.Drawing.Point(11, 56);
            this.tb_Chenge.Name = "tb_Chenge";
            this.tb_Chenge.Size = new System.Drawing.Size(153, 36);
            this.tb_Chenge.TabIndex = 19;
            // 
            // F_GamesCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1000, 720);
            this.Name = "F_GamesCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог Игр";
            this.Load += new System.EventHandler(this.F_GamesCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Chenge;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Chenge;
    }
}