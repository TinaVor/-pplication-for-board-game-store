using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Classes;
using System.Windows;

namespace WindowsFormsApp1.Forms
{
    public partial class F_Regictration : ClassLibraryPattern.FPattern
    {
        string DB_name = ConnectDB.conn;
        String TextPicture = String.Empty;
        public F_Regictration()
        {
            InitializeComponent();
            PictureBox.Image = this.CreateImage(PictureBox.Width, PictureBox.Height);
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);
            int Xpos = 35;
            int Ypos = 20;
            Brush color = Brushes.Black;
            Graphics g = Graphics.FromImage(result);
            PictureBox.BackColor = Color.FromArgb(255, 211, 6);
            TextPicture = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
                TextPicture += ALF[rnd.Next(ALF.Length)];
                g.DrawString(TextPicture, new Font("Arial", 16), color, new PointF(Xpos, Ypos));
            return result;
        }

        private void Registr_Load(object sender, EventArgs e) {
            PictureBox.Image = this.CreateImage(PictureBox.Width, PictureBox.Height);
        }

        private bool PrLogin(SqlConnection conn) {
            SqlCommand Com = new SqlCommand($"select count(*) from Workers where '{Login.Text}' = Login", conn);
            var value = Com.ExecuteScalar();
            if (Convert.ToInt32(value) > 0)  return false;
            else return true;
        }
        private void button1_Click(object sender, EventArgs e) {
            if (TextPicture != Capha.Text) {
                MessageBox.Show("Ошибка CAPTCHA");
                return;
            }
            if (Password.Text != DoublePassword.Text){
                MessageBox.Show("Пароль не совпадает");
                return;
            }
            string sql = "INSERT INTO Workers" + "([Login], [Password], [Full_Name], [Passport])" + $"VALUES('{Login.Text}', '{Password.Text}', '{FullName.Text}', '{Passport.Text}')";
            string sql1 = $"select ID_Workers from Workers where Login = '{Login.Text}'";
            string sql2 = $"select ID_Shop from Shop where Name = '{filial.Text}'";
            string sql3 = $"select ID_Post from Post where Name = '{Post.Text}'";
            using (SqlConnection conn = new SqlConnection(DB_name)) {
                if ((Login.Text == "") || (Password.Text == "") || (FullName.Text == "") || (Passport.Text == "") || (Post.Text == ""))
                {
                    MessageBox.Show("Введите данные !");
                } else {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    if (PrLogin(conn))
                    {
                        command.ExecuteNonQuery();
                        SqlCommand command2 = new SqlCommand(sql1, conn);
                        var id_workers = command2.ExecuteScalar();
                        SqlCommand command3 = new SqlCommand(sql2, conn);
                        var id_shop = command3.ExecuteScalar();
                        SqlCommand command4 = new SqlCommand(sql3, conn);
                        var id_post= command4.ExecuteScalar();
                        SqlCommand command5 = new SqlCommand($"insert into Work values ('{id_workers}', '{id_shop}','{id_post}')", conn);
                        command5.ExecuteNonQuery();
                        SqlCommand command6 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{id_workers}','Registration')", conn);
                        command6.ExecuteNonQuery();
                        MessageBox.Show("Регистрация завершкна успешно");
                        ActiveForm.Close();
                    } else {
                        MessageBox.Show("Пользователь уже существует");
                    }
                    conn.Close();
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ubdate_Click(object sender, EventArgs e)
        {
            PictureBox.Image = this.CreateImage(PictureBox.Width, PictureBox.Height);
        }

        private void F_Regictration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Publishing". При необходимости она может быть перемещена или удалена.
            this.publishingTableAdapter.Fill(this.allData.Publishing);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.allData.Post);

        }
    }
}

    

