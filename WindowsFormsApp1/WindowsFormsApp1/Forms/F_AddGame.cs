using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class F_AddGame : ClassLibraryPattern.FPattern
    {
        string StrConn = ConnectDB.conn;
        int Id_User;
        public F_AddGame(int id_user)
        {
            Id_User = id_user;
            InitializeComponent();
        }

        private void bt_AddGame_Click(object sender, EventArgs e) {
            if (NameGame.Text != "" && Cost.Text != "") {
                using (SqlConnection conn = new SqlConnection(StrConn)) {
                    string sql1 = $"select ID_Publishing from Publishing where Name_Publishing = '{Publishing.Text}'";
                    string sql2 = $"select ID_Limitation from Limitation where Age = '{Limitation.Text}'";
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql1, conn);
                    var ID_Publishing = command.ExecuteScalar();
                    SqlCommand command2 = new SqlCommand(sql2, conn);
                    var ID_Limitation = command2.ExecuteScalar();
                    SqlCommand command3 = new SqlCommand($"insert into Game ([ID_Publishing],[ID_Limitation],[Name],[Cost]) values ('{ID_Publishing}','{ID_Limitation}','{NameGame.Text}','{Cost.Text}')", conn);
                    command3.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','Add new Game')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Игра успешно добавлена!");
                Close();
            } else {
                MessageBox.Show("Запоните все поля!");
            }
        }
                
    private void AddNewAge_Click(object sender, EventArgs e) {
            if (txt_NewAge.Text != "") {
                using (SqlConnection conn = new SqlConnection(StrConn)) {
                    conn.Open ();
                    SqlCommand command = new SqlCommand($"insert into Limitation ([Age]) values ('{txt_NewAge.Text}')", conn);
                    command.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','Add new Age')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Ограничение добавлено");
                Close ();
                F_AddGame f_AddGame = new F_AddGame(Id_User);
                f_AddGame.ShowDialog();
            } else {
                MessageBox.Show("Заполните Возраст продажи");
            }
        }

        private void AddNewPub_Click(object sender, EventArgs e) {
            if (txt_NewPub.Text != "") {
                using (SqlConnection conn = new SqlConnection(StrConn)) {
                    conn.Open();
                    SqlCommand command = new SqlCommand($"insert into Publishing ([Name_Publishing]) values ('{txt_NewPub.Text}')", conn);
                    command.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','Add new Publiching')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Издательство добавлено");
                Close();
                F_AddGame f_AddGame = new F_AddGame(Id_User);
                f_AddGame.ShowDialog();
            } else {
                MessageBox.Show("Заполните Название издательства");
            }
        }

        public void F_AddGame_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Limitation". При необходимости она может быть перемещена или удалена.
            this.limitationTableAdapter.Fill(this.allData.Limitation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Publishing". При необходимости она может быть перемещена или удалена.
            this.publishingTableAdapter.Fill(this.allData.Publishing);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
