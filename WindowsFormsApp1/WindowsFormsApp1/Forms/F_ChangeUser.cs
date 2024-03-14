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
    public partial class F_ChangeUser : ClassLibraryPattern.FPattern
    {
        string StrConn = ConnectDB.conn;
        int Id_User;
        public F_ChangeUser(int idUser)
        {
            Id_User = idUser;
            InitializeComponent();
        }
        public void Sql_Show()
        {
            string sql = $"Select W.[ID_Workers], [Login], [Password], [Full_Name], [Passport], P.[Name] as [Post], S.[Name] as [Name_Shop]  from Workers as W" +
               $" inner join Work as WW on W.[ID_Workers] = WW.[ID_Workers] inner join Post as P on WW.[ID_Post] = P.[ID_Post]" +
               $" inner join Shop as S on WW.ID_Shop = S.ID_Shop";
            using (SqlConnection connection = new SqlConnection(StrConn))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void bt_Change_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text != "" && Full_Name.Text != "" && Passport.Text != "" && txt_Id.Text != "")
            {
                string sql1 = $"select ID_Workers from Workers where ID_Workers = '{txt_Id.Text}'";
                string sql2 = $"select ID_Shop from Shop where Name = '{filial.Text}'";
                string sql3 = $"select ID_Post from Post where Name = '{Post.Text}'";
                using (SqlConnection conn = new SqlConnection(StrConn))
                {
                    conn.Open();    
                    SqlCommand command3 = new SqlCommand(sql2, conn);
                    var id_shop = command3.ExecuteScalar();
                    SqlCommand command4 = new SqlCommand(sql3, conn);
                    var id_post = command4.ExecuteScalar();
                    string sql = $"update Workers set [Login] = '{Login.Text}', [Password]= '{Password.Text}', [Full_Name] = '{Full_Name.Text}', [Passport] = '{Passport.Text}' where ID_Workers = {txt_Id.Text}";
                    SqlCommand command5 = new SqlCommand(sql, conn);
                    command5.ExecuteNonQuery();
                    string sql7 = $"update Work set [ID_Shop]= '{id_shop}', [ID_Post] = '{id_post}' where ID_Work = {txt_Id.Text}";
                    SqlCommand command7 = new SqlCommand(sql7, conn);
                    command7.ExecuteNonQuery();
                    SqlCommand command6 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{Id_User}','User Changed')", conn);
                    command6.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Пользователь изменен успешно");
                    Close();
                    F_ChangeUser f_ChangeUser = new F_ChangeUser(Id_User);
                    f_ChangeUser.ShowDialog();
                }
            } else {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void F_ChangeUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.allData.Shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "allData.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.allData.Post);
            Sql_Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

