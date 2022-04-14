using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("Select * From account " +
               "Where username = @user AND password = @pass", dB.GetConnection());

            cmd.Parameters.AddWithValue("@user", txbUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txbPassword.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Globals.aid = (int) dt.Rows[0][0];
                Globals.username = txbUsername.Text;
                ShowPermission nf = new ShowPermission();
                nf.Show();
            }
            else
            {
                MessageBox.Show("Unsuccessfully!", "Failed", MessageBoxButtons.OK);
            }
        }
    }
}
