using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Amipanas_Hotel
{
    public partial class login_form : Form
    {
        DbConnection connect = new DbConnection();
        public login_form()
        {
            InitializeComponent();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            // closing application
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim().Equals("") || txt_pass.Text == "")
            {
                MessageBox.Show(".برای ورود به سامانه نام کاربری و رمز عبور خود را وارد نمایید", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectQuery = "SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass";
                MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txt_user.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_pass.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                // cheching the username and password exist
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show(".نام کاربری یا رمز عبور اشتباه است", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
