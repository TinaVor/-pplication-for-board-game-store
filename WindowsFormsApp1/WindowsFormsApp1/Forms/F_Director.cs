﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class F_Director : ClassLibraryPattern.FPattern
    {
        public string loginUser;
        int Id_User;
        public F_Director(string login, int id_user)
        {
            Id_User = id_user;
            loginUser = login; 
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_See_Click(object sender, EventArgs e)
        {
            F_ShowGames f_ShowGames = new F_ShowGames(loginUser);
            f_ShowGames.Show();
        }

        private void bt_buy_Click(object sender, EventArgs e)
        {
            F_BuyGames f_BuyGames = new F_BuyGames(loginUser, Id_User);
            f_BuyGames.Show();
        }

        private void F_Director_Load(object sender, EventArgs e)
        {
            lb_login.Text = loginUser;
        }

        private void bt_SeeWorkers_Click(object sender, EventArgs e)
        {
            F_SeeWorkers f_SeeWorkers = new F_SeeWorkers(loginUser, Id_User);
            f_SeeWorkers.Show();
        }
    }
}
