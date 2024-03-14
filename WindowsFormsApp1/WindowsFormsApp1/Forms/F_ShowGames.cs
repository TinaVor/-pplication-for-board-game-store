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
    public partial class F_ShowGames : ClassLibraryPattern.FPattern
    {
        public string loginUser;
        string StrConn = ConnectDB.conn;
        bool find = false;
        public F_ShowGames(string login)
        {
            loginUser = login;
            InitializeComponent();
        }
        public void Sql_Show()
        {
            string sql = "";
            if (find == false)
            {
                sql = $"Select G.ID_Game, G.Name, L.Age, P.Name_Publishing, Cost from Game as G inner join Publishing as P " +
                $"on G.ID_Publishing = P.ID_Publishing inner join Limitation as L on G.ID_Limitation = L.ID_Limitation";
            }
            if (find == true)
            {
                sql = sql = $"Select G.ID_Game, G.Name, L.Age, P.Name_Publishing, Cost from Game as G inner join Publishing as P " +
                $"on G.ID_Publishing = P.ID_Publishing inner join Limitation as L on G.ID_Limitation = L.ID_Limitation where G.Name = '{txt_Name.Text}'";
            }
            using (SqlConnection connection = new SqlConnection(StrConn))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void F_ShowGames_Load(object sender, EventArgs e)
        {
            lb_login.Text = loginUser;
            Sql_Show();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "")
            {
                find = true;
                Sql_Show();
            }
            else
            {
                MessageBox.Show("Строка поиска пуска ");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
