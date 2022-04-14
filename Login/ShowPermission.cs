using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class ShowPermission : Form
    {
        public ShowPermission()
        {
            InitializeComponent();
            lbUsername.Text = Globals.username;
            DB dB = new DB();

            dB.OpenConnection();
            
            MySqlCommand cmd = new MySqlCommand("select a.aid, g.gid, g.pid, p.pname " +
                "from account a, grpermission g, permission p " +
                "where a.gid = g.gid and p.pid=g.pid and a.aid = @user;", dB.GetConnection());

            cmd.Parameters.AddWithValue("@user", Globals.aid);
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
            int i = 0;
            while (reader.Read())
            {
                lbGroup.Text = "G" + reader["gid"].ToString();
                Label lb = new Label();
                lb.Text = reader["pid"].ToString() + " " + reader["pname"].ToString();
                lb.Location = new Point(lbGrPermission.Location.X + i * 100, lbGrPermission.Location.Y);
                lb.ForeColor = Color.Green;
                lb.Font = new Font("Arial", 12);
                i++;
                this.Controls.Add(lb);
            }
            dB.CloseConnection();
            dB.OpenConnection();
            cmd = new MySqlCommand("select * from decentralization d, permission p where d.pid = p.pid and aid = @user;", dB.GetConnection());

            cmd.Parameters.AddWithValue("@user", Globals.aid);

            reader = cmd.ExecuteReader();
            
            i = 0;
            while (reader.Read())
            {
                Label lb = new Label();
                lb.Text = reader["pid"].ToString() + " " + reader["pname"].ToString();
                lb.Location = new Point(lbInvidual.Location.X + i * 100, lbInvidual.Location.Y);
                lb.ForeColor = Color.Green;
                lb.Font = new Font("Arial", 12);
                i++;
                this.Controls.Add(lb);
            }
            dB.CloseConnection();
        }

    }
}
