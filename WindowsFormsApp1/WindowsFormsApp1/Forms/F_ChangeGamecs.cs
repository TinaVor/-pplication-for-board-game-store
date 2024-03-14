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
    public partial class F_ChangeGamecs : ClassLibraryPattern.FPattern
    {
        int id;
        int id_User;
        string StrConn = ConnectDB.conn;
        public F_ChangeGamecs(int Id_User, int ID)
        {
            id_User = Id_User;
            id = ID;
            InitializeComponent();
        }

        private void bt_AddGame_Click(object sender, EventArgs e)
        {
            string sql1 = $"select ID_Publishing from Publishing where Name_Publishing = '{Publishing.Text}'";
            string sql2 = $"select ID_Limitation from Limitation where Age = '{Limitation.Text}'";
            if (NameGame.Text != "" && Cost.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql1, conn);
                    var ID_Publishing = command.ExecuteScalar();
                    SqlCommand command2 = new SqlCommand(sql2, conn);
                    var ID_Limitation = command2.ExecuteScalar();
                    string sql = $"update Game set ID_Publishing ='{ID_Publishing}', ID_Limitation ='{ID_Limitation}', [Name]='{NameGame.Text}', [Cost]='{Cost.Text}' where ID_Game = {id}";
                    SqlCommand command3 = new SqlCommand(sql, conn);
                    command3.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{id_User}','Change Game')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                    
                }
                MessageBox.Show("Игра изменена успешно!");
                Close();
            } else {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void ChangePub_Click_1(object sender, EventArgs e)
        {
            string sql1 = $"select ID_Publishing from Publishing where Name_Publishing = '{cb_OldName.Text}'";
            if (txt_NewName.Text != "") {
                using (SqlConnection conn = new SqlConnection(StrConn))  {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql1, conn);
                    var ID_Publishing = command.ExecuteScalar();
                    Console.WriteLine("фффф");
                    Console.WriteLine(ID_Publishing);
                    Console.WriteLine(txt_NewName.Text);
                    Console.WriteLine("aaaa");
                    string sql = $"update Publishing set Name_Publishing = '{txt_NewName.Text}' where ID_Publishing = '{ID_Publishing}'";
                    SqlCommand command3 = new SqlCommand(sql, conn);
                    command3.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{id_User}','Change Publishing')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Издательство изменено успешно!");
                Close();
                F_ChangeGamecs f_AddGame = new F_ChangeGamecs(id_User, id);
                f_AddGame.ShowDialog();
            }else {
                MessageBox.Show("Заполните Название издательства");
            }
        }

        private void ChangeAge_Click(object sender, EventArgs e)
        {
            string sql1 = $"select ID_Limitation from Limitation where Age = '{cb_OldAge.Text}'";
            if (txt_NewAge.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql1, conn);
                    var ID_Limitation = command.ExecuteScalar();
                    string sql = $"update Limitation set [Age] = '{txt_NewAge.Text}' where ID_Limitation = {ID_Limitation}";
                    SqlCommand command3 = new SqlCommand(sql, conn);
                    command3.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{id_User}','Change Age')", conn);
                    command4.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Возраст изменен успешно!");
                Close();
                F_ChangeGamecs f_AddGame = new F_ChangeGamecs(id_User, id);
                f_AddGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Заполните Возраст продажи");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_ChangeGamecs_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Limitation". При необходимости она может быть перемещена или удалена.
            this.limitationTableAdapter.Fill(this.allData.Limitation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Publishing". При необходимости она может быть перемещена или удалена.
            this.publishingTableAdapter.Fill(this.allData.Publishing);
        }
    }
}
