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
    public partial class GuestsForm : Form
    {
        RoomClass room = new RoomClass();
        GuestsClass guest = new GuestsClass();
        public GuestsForm()
        {
            InitializeComponent();
        }
        private void GuestsForm_Load(object sender, EventArgs e)
        {
            getTable();

            roomType_cmBox.DataSource = room.getRoomType();
            roomType_cmBox.DisplayMember = "Label";
            roomType_cmBox.ValueMember = "CategoryID";

            int type = Convert.ToInt32(roomType_cmBox.SelectedValue.ToString());
            roomCode_cmBox.DataSource = guest.roomByType(type);
            roomCode_cmBox.DisplayMember = "RoomID";
            roomCode_cmBox.ValueMember = "RoomID";
        }
        private void roomType_cmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(roomType_cmBox.SelectedValue.ToString());
                roomCode_cmBox.DataSource = guest.roomByType(type);
                roomCode_cmBox.DisplayMember = "RoomID";
                roomCode_cmBox.ValueMember = "RoomID";
            }
            catch (Exception)
            {
                // Nothing
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_family.Clear();
            txt_phone.Clear();
            txt_city.Clear();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_name.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show(".لطفا فیلد‌های کد ملی , نام , شماره تماس را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(txt_id.Text.Length != 10)
                {
                    MessageBox.Show(".کد ملی شامل 10 رقم میباشد", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string id = txt_id.Text;
                        string fname = txt_name.Text;
                        string lname = txt_family.Text;
                        int RoomID = Convert.ToInt32(roomCode_cmBox.Text);
                        string phone = txt_phone.Text;
                        string city = txt_city.Text;

                        Boolean insertGuest = guest.insertGuest(id, fname, lname, RoomID, phone, city);
                        if (insertGuest)
                        {
                            MessageBox.Show(".اطلاعات مهمان جدید با موفقیت افزوده شد", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getTable();
                            guest.roomUpdate(RoomID);
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("!خطا\n.اطلاعات مهمان جدید افزوده نشد", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }  
        }
        private void getTable()
        {
            dataGridView_guest.DataSource = guest.getGuest();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_name.Text == "" || txt_phone.Text == "")
            {
                MessageBox.Show(".لطفا فیلد‌های کد ملی , نام , شماره تماس را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txt_id.Text.Length != 10)
                {
                    MessageBox.Show(".کد ملی شامل 10 رقم میباشد", "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string id = txt_id.Text;
                        string fname = txt_name.Text;
                        string lname = txt_family.Text;
                        int RoomID = Convert.ToInt32(roomCode_cmBox.Text);
                        string phone = txt_phone.Text;
                        string city = txt_city.Text;

                        Boolean editGuest = guest.editGuest(id, fname, lname, RoomID, phone, city);
                        if (editGuest)
                        {
                            MessageBox.Show(".اطلاعات مهمان با موفقیت بروزرسانی شد", "Update Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getTable();
                            btn_clear.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("!خطا\n.اطلاعات مهمان بروزرسانی نشد", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dataGridView_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView_guest.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView_guest.CurrentRow.Cells[1].Value.ToString();
            txt_family.Text = dataGridView_guest.CurrentRow.Cells[2].Value.ToString();
            roomCode_cmBox.Text = dataGridView_guest.CurrentRow.Cells[3].Value.ToString();
            txt_phone.Text = dataGridView_guest.CurrentRow.Cells[4].Value.ToString();
            txt_city.Text = dataGridView_guest.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show(".لطفا فیلد‌ کد ملی را تکمیل کنید", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string id = txt_id.Text;
                try
                {
                    Boolean deleteGuest = guest.removeGuest(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show(".اطلاعات مهمان با موفقیت از سامانه حذف شد", "Guest Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        btn_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("!خطا\n.حذف ناموفق بود", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
