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
    public partial class F_SeeWorkers : ClassLibraryPattern.FPattern
    {
        public string loginUser;
        int id_user;
        string StrConn = ConnectDB.conn;
        bool find = false;
        public F_SeeWorkers(string login, int Id_User)
        {
            id_user = Id_User;
            loginUser = login;
            InitializeComponent();
        }
        public void Sql_Show()
        {
            string sql = "";
            if (find == false)
            {
                sql = $"Select W.[ID_Workers], [Full_Name], [Passport], P.[Name] as [Post], S.[Name] as [Name_Shop]  from Workers as W" +
                    $" inner join Work as WW on W.[ID_Workers] = WW.[ID_Workers] inner join Post as P on WW.[ID_Post] = P.[ID_Post]" +
                    $" inner join Shop as S on WW.ID_Shop = S.ID_Shop Where P.Name = 'Работник'";
            }
            if (find == true)
            {
                sql = $"Select DISTINCT  W.[ID_Workers], [Full_Name], [Passport], P.[Name] as [Post], S.[Name] as [Name_Shop]  from Workers as W" +
                  $" inner join Work as WW on W.[ID_Workers] = WW.[ID_Workers] inner join Post as P on WW.[ID_Post] = P.[ID_Post]" +
                  $" inner join Shop as S on WW.ID_Shop = S.ID_Shop Where P.Name = 'Работник' and W.Full_name = '{txt_Name.Text}'";
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_SeeWorkers_Load(object sender, EventArgs e)
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
    }
}
