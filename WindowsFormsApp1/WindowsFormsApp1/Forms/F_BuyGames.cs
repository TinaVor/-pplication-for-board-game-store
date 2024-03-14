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
    public partial class F_BuyGames : ClassLibraryPattern.FPattern
    {
        string StrConn = ConnectDB.conn;
        string login;
        int Id_User;
        public F_BuyGames(string loginUser, int id_user)
        {
            Id_User = id_user;
            login = loginUser;
            InitializeComponent();
        }
        public void Sql_Show() {
            string sql = $"Select B.ID_Buy, W.[Full_Name],G.[Name], Quantity, [Data]  from Buy as B  inner join Workers as W " +
                $"on B.[ID_Workers]= W.[ID_Workers] inner join[dbo].[Game] as G on B.[ID_Game] = G.[ID_Game]";
            using (SqlConnection connection = new SqlConnection(StrConn)) {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    

        private void bt_Buy_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(StrConn)) {
                string sql1 = $"select ID_Workers from Workers where Login = '{login}'";
                string sql2 = $"select ID_Game from Game where Name = '{cb_Name.Text}'";
                conn.Open();
                SqlCommand command = new SqlCommand(sql1, conn);
                var ID_Workers = command.ExecuteScalar();
                SqlCommand command2 = new SqlCommand(sql2, conn);
                var ID_Game = command2.ExecuteScalar();
                SqlCommand command3 = new SqlCommand($"insert into Buy ([ID_Workers],[ID_Game],[Quantity],[Data]) values ('{ID_Workers}','{ID_Game}','{num_col.Text}','{DateTime.Now}')", conn);
                command3.ExecuteNonQuery();
                SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','Buy Game')", conn);
                command4.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Продажа прошла успешно!");
            Sql_Show();
        }

        private void F_BuyGames_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.allData.Game);
            Sql_Show();
        }

        private void Exit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
