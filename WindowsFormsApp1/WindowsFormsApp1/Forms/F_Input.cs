using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Input : ClassLibraryPattern.FPattern
    {
        string StrConn = ConnectDB.conn;
        public Input() {
            InitializeComponent();
        }

        private void bt_Input_Click(object sender, EventArgs e) {
            if (Login.Text != "" && Password.Text != "") {
                string sql1 = $"select Login from Workers where Login = '{Login.Text}' and Password = '{Password.Text}'";
                string sql2 = $"select ID_Workers from Workers where Login = '{Login.Text}' and Password = '{Password.Text}'";
                string sql3 = $"select ID_Post from Work where ID_Workers = (select ID_Workers from Workers where Login = '{Login.Text}' and Password = '{Password.Text}')";
                string sql5 = $"select ID_Workers from Workers where Login = '{Login.Text}'";
                using (SqlConnection conn = new SqlConnection(StrConn)) {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql3, conn);
                    SqlCommand command2 = new SqlCommand(sql1, conn);
                    SqlCommand command3 = new SqlCommand(sql2, conn);
                    SqlCommand command5 = new SqlCommand(sql5, conn);
                    var id = command3.ExecuteScalar();
                    if (id == null) { 
                        MessageBox.Show("Введен неправльный логин/пароль");
                        return;
                    } else {
                        var id_user = (Int32)command5.ExecuteScalar();
                        int post = (Int32)command.ExecuteScalar();
                        string name = (string)command2.ExecuteScalar();
                        SqlCommand command4 = new SqlCommand($"insert into History values ('{DateTime.Now}', '{id}','Open Programm')", conn);
                        command4.ExecuteNonQuery();
                        switch (post) {
                            case 1:
                                Hide();
                                F_Admin admin = new F_Admin(name, id_user);
                                admin.Closed += (s, args) => this.Close();
                                admin.ShowDialog();
                                break;
                            case 2:
                                Hide();
                                F_Director director = new F_Director(name, id_user);
                                director.Closed += (s, args) => this.Close();
                                director.ShowDialog();
                                break;
                            case 3:
                                Hide();
                                F_Worker worker = new F_Worker(name, id_user);
                                worker.Closed += (s, args) => this.Close();
                                worker.ShowDialog();
                                break;
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Заполните все поля!");
            }
        }
    
        private void bt_Regictration_Click(object sender, EventArgs e)
        {
            F_Regictration fcalc = new F_Regictration();
            fcalc.ShowDialog();
        }

   
    }
}

