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
    public partial class RoomsForm : Form
    {
        RoomClass room = new RoomClass();
        public RoomsForm()
        {
            InitializeComponent();
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            roomType_cmBox.DataSource = room.getRoomType();
            roomType_cmBox.DisplayMember = "Label";
            roomType_cmBox.ValueMember = "CategoryID";

            getRoomList();
        }





        // ADD BUTTON
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show(".لطفا همه‌ی فیلد‌ها را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int no = Convert.ToInt32(txt_id.Text);
                int type = Convert.ToInt32(roomType_cmBox.SelectedValue.ToString());
                string ph = txt_phone.Text;
                string status = free_rdButton.Checked ? "خالی" : "پر";

                try
                {
                    if (room.addRoom(no, type, ph, status))
                    {
                        MessageBox.Show(".اتاق جدید با موفقیت افزوده شد", "Room Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        btn_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("!خطا\n.اطلاعات اتاق جدید افزوده نشد", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }





        // CLEAR BUTTON
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_phone.Clear();
            roomType_cmBox.SelectedIndex = 0;
        }

        private void getRoomList()
        {
            dataGridView_rooms.DataSource = room.getRoomList();
        }





        // UPDATE BUTTON
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show(".لطفا فیلد‌ کد اتاق را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int no = Convert.ToInt32(txt_id.Text);
                int type = Convert.ToInt32(roomType_cmBox.SelectedValue.ToString());
                string ph = txt_phone.Text;
                string status = free_rdButton.Checked ? "خالی" : "پر";

                try
                {

                    if (room.editRoom(no, type, ph, status))
                    {
                        MessageBox.Show(".اطلاعات اتاق با موفقیت بروزرسانی شد", "Room Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        btn_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("!خطا\n.بروزرسانی ناموفق بود", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }





        // DATA SHOW
        private void dataGridView_rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView_rooms.CurrentRow.Cells[0].Value.ToString();
            roomType_cmBox.SelectedValue = dataGridView_rooms.CurrentRow.Cells[1].Value.ToString();
            txt_phone.Text = dataGridView_rooms.CurrentRow.Cells[2].Value.ToString();
            string rButton = dataGridView_rooms.CurrentRow.Cells[3].Value.ToString();

            if (rButton.Equals("خالی"))
            {
                free_rdButton.Checked = true;
            }
            else
            {
                full_rdButton.Checked = true;
            }
        }
        




        // DELETE BUTTON
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show(".لطفا فیلد‌ کد اتاق را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string no = txt_id.Text;
                try
                {
                    Boolean deleteRoom = room.removeRoom(no);
                    if (deleteRoom)
                    {
                        MessageBox.Show(".اطلاعات اتاق با موفقیت از سامانه حذف شد", "Room Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        btn_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("!خطا\n.حذف ناموفق بود", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
