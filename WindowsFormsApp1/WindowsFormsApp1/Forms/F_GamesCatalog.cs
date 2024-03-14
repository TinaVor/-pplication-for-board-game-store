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
    public partial class F_GamesCatalog : ClassLibraryPattern.FPattern
    {
        int Id_User;
        string StrConn = ConnectDB.conn;
        public F_GamesCatalog(int id_user)
        {
            Id_User = id_user; ;
            InitializeComponent();
        }
        public void Sql_Show()
        {
            string sql = $"Select G.ID_Game, G.Name, L.Age, P.Name_Publishing, Cost from Game as G inner join Publishing as P" +
               $" on G.ID_Publishing = P.ID_Publishing inner join Limitation as L on G.ID_Limitation = L.ID_Limitation";
            using (SqlConnection connection = new SqlConnection(StrConn))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void F_GamesCatalog_Load(object sender, EventArgs e)
        {
            Sql_Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            F_AddGame f_AddGame = new F_AddGame(Id_User);
            f_AddGame.ShowDialog();
            Sql_Show();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_Del.Text != "")
            {
                string sql2 = $"delete from Game where ID_Game = {tb_Del.Text}";
                string sql = $"delete from Buy where ID_Game = {tb_Del.Text}";
                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                   MessageBox.Show(
                      "Вы уверенны? Это действие приведет к потере данных",
                      "Внимание",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation );
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand(sql2, conn);
                    command2.ExecuteNonQuery();
                    SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','Delete Game')", conn);
                    command4.ExecuteNonQuery();
                    MessageBox.Show("Успешно");
                }
                Sql_Show();
                tb_Del.Text = "";
            }
            else {
                MessageBox.Show("Заполните ID");
            }
        }

        private void bt_Chenge_Click(object sender, EventArgs e)
        {
            if (tb_Chenge.Text != "")
            {
                int id = Convert.ToInt32(tb_Chenge.Text);
                F_ChangeGamecs f_AddGame = new F_ChangeGamecs(Id_User, id);
                f_AddGame.ShowDialog();
                Sql_Show();
                tb_Chenge.Text = "";

            } else
            {
                MessageBox.Show("Заполните ID");
            }
       
        }
    }
}
