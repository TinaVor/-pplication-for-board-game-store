using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class F_Admin : ClassLibraryPattern.FPattern
    {
        public int idUser;
        public string loginUser;
        public F_Admin(string login, int id_user)
        {
            idUser = id_user;
            loginUser = login;
            InitializeComponent();
        }

        private void F_Admin_Load(object sender, EventArgs e)
        {
            lb_login.Text = loginUser;
        }

        private void bt_Catalog_Click(object sender, EventArgs e)
        {
            F_GamesCatalog gamesCatalog = new F_GamesCatalog(idUser);
            gamesCatalog.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_history_Click(object sender, EventArgs e)
        {
            F_History F_history = new F_History();
            F_history.ShowDialog();
        }

        private void bt_ChangeUser_Click(object sender, EventArgs e)
        {
            F_ChangeUser f_ChangeUser = new F_ChangeUser(idUser);
            f_ChangeUser.ShowDialog();
        }
    }
}
