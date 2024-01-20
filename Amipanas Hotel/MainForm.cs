using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amipanas_Hotel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            panel_slider.Height = btn_dashboard.Height;
            panel_slider.Top = btn_dashboard.Top;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(panel_dashboard);
        }
        private void btn_guest_Click(object sender, EventArgs e)
        {
            panel_slider.Height = btn_guest.Height;
            panel_slider.Top = btn_guest.Top;
            panel_container.Controls.Clear();
            GuestsForm gue = new GuestsForm();
            gue.TopLevel = false;
            gue.Dock = DockStyle.Fill;
            gue.FormBorderStyle = FormBorderStyle.None;
            panel_container.Controls.Add(gue);
            gue.Show();
        }
        private void btn_reciption_Click(object sender, EventArgs e){}

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            panel_slider.Height = btn_rooms.Height;
            panel_slider.Top = btn_rooms.Top;
            panel_container.Controls.Clear();
            RoomsForm room = new RoomsForm();
            room.TopLevel = false;
            room.Dock = DockStyle.Fill;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_container.Controls.Add(room);
            room.Show();
        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }
        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Khaki;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginF = new login_form();
            loginF.Show();
        }
    }
}
