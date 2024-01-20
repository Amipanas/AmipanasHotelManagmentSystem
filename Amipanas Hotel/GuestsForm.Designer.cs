namespace Amipanas_Hotel
{
    partial class GuestsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView_guest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roomType_cmBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.roomCode_cmBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_city = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_family = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 76);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Koodak", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(454, -7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 57);
            this.label6.TabIndex = 1;
            this.label6.Text = "مدیریت مهمانان";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(17, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "کد ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = "شماره تماس";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(17, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "شهر";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 145);
            this.panel1.TabIndex = 16;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Black;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.Location = new System.Drawing.Point(817, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_clear.Size = new System.Drawing.Size(266, 140);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "   پاکسازی";
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(545, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_delete.Size = new System.Drawing.Size(266, 140);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "حذف";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = global::Amipanas_Hotel.Properties.Resources.update;
            this.btn_update.Location = new System.Drawing.Point(273, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_update.Size = new System.Drawing.Size(266, 140);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "بروزرسانی";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Black;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = global::Amipanas_Hotel.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_save.Size = new System.Drawing.Size(265, 140);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "ذخیره";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView_guest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_guest.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_guest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_guest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_guest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_guest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_guest.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_guest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_guest.EnableHeadersVisualStyles = false;
            this.dataGridView_guest.GridColor = System.Drawing.Color.Black;
            this.dataGridView_guest.Location = new System.Drawing.Point(1, 82);
            this.dataGridView_guest.Name = "dataGridView_guest";
            this.dataGridView_guest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_guest.RowHeadersVisible = false;
            this.dataGridView_guest.RowHeadersWidth = 51;
            this.dataGridView_guest.RowTemplate.Height = 24;
            this.dataGridView_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_guest.Size = new System.Drawing.Size(793, 389);
            this.dataGridView_guest.TabIndex = 27;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView_guest.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_guest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_guest.ThemeStyle.ReadOnly = false;
            this.dataGridView_guest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_guest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_guest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_guest.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_guest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_guest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_guest_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.roomType_cmBox);
            this.panel3.Controls.Add(this.roomCode_cmBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_city);
            this.panel3.Controls.Add(this.txt_phone);
            this.panel3.Controls.Add(this.txt_family);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(800, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 401);
            this.panel3.TabIndex = 27;
            // 
            // roomType_cmBox
            // 
            this.roomType_cmBox.BackColor = System.Drawing.Color.Transparent;
            this.roomType_cmBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType_cmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType_cmBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_cmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_cmBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomType_cmBox.ForeColor = System.Drawing.Color.Black;
            this.roomType_cmBox.ItemHeight = 30;
            this.roomType_cmBox.Location = new System.Drawing.Point(130, 336);
            this.roomType_cmBox.Name = "roomType_cmBox";
            this.roomType_cmBox.Size = new System.Drawing.Size(144, 36);
            this.roomType_cmBox.TabIndex = 28;
            this.roomType_cmBox.SelectedIndexChanged += new System.EventHandler(this.roomType_cmBox_SelectedIndexChanged);
            // 
            // roomCode_cmBox
            // 
            this.roomCode_cmBox.BackColor = System.Drawing.Color.Transparent;
            this.roomCode_cmBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomCode_cmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomCode_cmBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomCode_cmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomCode_cmBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomCode_cmBox.ForeColor = System.Drawing.Color.Black;
            this.roomCode_cmBox.ItemHeight = 30;
            this.roomCode_cmBox.Location = new System.Drawing.Point(130, 171);
            this.roomCode_cmBox.Name = "roomCode_cmBox";
            this.roomCode_cmBox.Size = new System.Drawing.Size(144, 36);
            this.roomCode_cmBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(17, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 34);
            this.label8.TabIndex = 30;
            this.label8.Text = "نوع اتاق";
            // 
            // txt_city
            // 
            this.txt_city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_city.DefaultText = "";
            this.txt_city.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_city.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_city.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_city.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_city.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_city.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_city.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_city.Location = new System.Drawing.Point(130, 281);
            this.txt_city.Name = "txt_city";
            this.txt_city.PasswordChar = '\0';
            this.txt_city.PlaceholderText = "";
            this.txt_city.SelectedText = "";
            this.txt_city.Size = new System.Drawing.Size(144, 36);
            this.txt_city.TabIndex = 25;
            // 
            // txt_phone
            // 
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(130, 226);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(144, 36);
            this.txt_phone.TabIndex = 24;
            // 
            // txt_family
            // 
            this.txt_family.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_family.DefaultText = "";
            this.txt_family.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_family.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_family.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_family.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_family.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_family.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_family.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_family.Location = new System.Drawing.Point(130, 116);
            this.txt_family.Name = "txt_family";
            this.txt_family.PasswordChar = '\0';
            this.txt_family.PlaceholderText = "";
            this.txt_family.SelectedText = "";
            this.txt_family.Size = new System.Drawing.Size(144, 36);
            this.txt_family.TabIndex = 22;
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(130, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(144, 36);
            this.txt_name.TabIndex = 21;
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(130, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(144, 36);
            this.txt_id.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(17, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 34);
            this.label7.TabIndex = 28;
            this.label7.Text = "کد اتاق";
            // 
            // GuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1082, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView_guest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " پذیرش مهمانان";
            this.Load += new System.EventHandler(this.GuestsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_guest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_family;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_city;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox roomType_cmBox;
        private Guna.UI2.WinForms.Guna2ComboBox roomCode_cmBox;
    }
}