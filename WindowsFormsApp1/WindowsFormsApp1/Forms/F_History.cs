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
    public partial class F_History : ClassLibraryPattern.FPattern
    {
        string StrConn = ConnectDB.conn;
        public F_History()
        {
            InitializeComponent();
        }

        private void F_History_Load(object sender, EventArgs e)
        {
            string sql = $"Select H.ID_History, H.[Date], W.Full_Name, H.[Event] from History as H inner join Workers as W on H.ID_Workers = W.ID_Workers"; 
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
    }
}
