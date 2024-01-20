namespace Amipanas_Hotel
{
    partial class RoomsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.status_gpBox = new System.Windows.Forms.GroupBox();
            this.free_rdButton = new System.Windows.Forms.RadioButton();
            this.full_rdButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_rooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.roomType_cmBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.status_gpBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 145);
            this.panel1.TabIndex = 17;
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
            this.btn_clear.Location = new System.Drawing.Point(816, 3);
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
            this.btn_delete.Location = new System.Drawing.Point(544, 2);
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
            this.btn_update.Location = new System.Drawing.Point(272, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_update.Size = new System.Drawing.Size(266, 140);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "بروزرسانی";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::Amipanas_Hotel.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(0, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_add.Size = new System.Drawing.Size(266, 140);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "افزودن اتاق";
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // status_gpBox
            // 
            this.status_gpBox.Controls.Add(this.free_rdButton);
            this.status_gpBox.Controls.Add(this.full_rdButton);
            this.status_gpBox.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.status_gpBox.ForeColor = System.Drawing.Color.Khaki;
            this.status_gpBox.Location = new System.Drawing.Point(3, 6);
            this.status_gpBox.Name = "status_gpBox";
            this.status_gpBox.Size = new System.Drawing.Size(339, 81);
            this.status_gpBox.TabIndex = 19;
            this.status_gpBox.TabStop = false;
            this.status_gpBox.Text = " وضعیت ";
            // 
            // free_rdButton
            // 
            this.free_rdButton.AutoSize = true;
            this.free_rdButton.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.free_rdButton.ForeColor = System.Drawing.Color.Khaki;
            this.free_rdButton.Location = new System.Drawing.Point(115, 28);
            this.free_rdButton.Name = "free_rdButton";
            this.free_rdButton.Size = new System.Drawing.Size(74, 43);
            this.free_rdButton.TabIndex = 0;
            this.free_rdButton.TabStop = true;
            this.free_rdButton.Text = "خالی";
            this.free_rdButton.UseVisualStyleBackColor = true;
            // 
            // full_rdButton
            // 
            this.full_rdButton.AutoSize = true;
            this.full_rdButton.Font = new System.Drawing.Font("B Koodak", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.full_rdButton.ForeColor = System.Drawing.Color.Khaki;
            this.full_rdButton.Location = new System.Drawing.Point(249, 28);
            this.full_rdButton.Name = "full_rdButton";
            this.full_rdButton.Size = new System.Drawing.Size(56, 43);
            this.full_rdButton.TabIndex = 19;
            this.full_rdButton.TabStop = true;
            this.full_rdButton.Text = "پر";
            this.full_rdButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(7, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "کد اتاق";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Koodak", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 38);
            this.label4.TabIndex = 14;
            this.label4.Text = "شماره تماس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Koodak", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "نوع اتاق";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Koodak", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(452, -9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 57);
            this.label3.TabIndex = 19;
            this.label3.Text = "مدیریت اتاق‌ها";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 76);
            this.panel2.TabIndex = 20;
            // 
            // dataGridView_rooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_rooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rooms.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView_rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_rooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_rooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_rooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_rooms.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_rooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_rooms.EnableHeadersVisualStyles = false;
            this.dataGridView_rooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_rooms.Location = new System.Drawing.Point(0, 100);
            this.dataGridView_rooms.Name = "dataGridView_rooms";
            this.dataGridView_rooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_rooms.RowHeadersVisible = false;
            this.dataGridView_rooms.RowHeadersWidth = 51;
            this.dataGridView_rooms.RowTemplate.Height = 24;
            this.dataGridView_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_rooms.Size = new System.Drawing.Size(722, 361);
            this.dataGridView_rooms.TabIndex = 21;
            this.dataGridView_rooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_rooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_rooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_rooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_rooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_rooms.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView_rooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_rooms.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_rooms.ThemeStyle.ReadOnly = false;
            this.dataGridView_rooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_rooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_rooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_rooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_rooms.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_rooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_rooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_rooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_rooms_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_phone);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Controls.Add(this.roomType_cmBox);
            this.panel3.Controls.Add(this.status_gpBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(728, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 401);
            this.panel3.TabIndex = 22;
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
            this.txt_phone.Location = new System.Drawing.Point(127, 110);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(215, 36);
            this.txt_phone.TabIndex = 23;
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
            this.txt_id.Location = new System.Drawing.Point(127, 300);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(215, 36);
            this.txt_id.TabIndex = 23;
            // 
            // roomType_cmBox
            // 
            this.roomType_cmBox.BackColor = System.Drawing.Color.Transparent;
            this.roomType_cmBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomType_cmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomType_cmBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_cmBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomType_cmBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roomType_cmBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomType_cmBox.ItemHeight = 30;
            this.roomType_cmBox.Location = new System.Drawing.Point(127, 205);
            this.roomType_cmBox.Name = "roomType_cmBox";
            this.roomType_cmBox.Size = new System.Drawing.Size(215, 36);
            this.roomType_cmBox.TabIndex = 20;
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1082, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView_rooms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomsForm";
            this.Text = " اتاق‌ها";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.status_gpBox.ResumeLayout(false);
            this.status_gpBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rooms)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox status_gpBox;
        private System.Windows.Forms.RadioButton free_rdButton;
        private System.Windows.Forms.RadioButton full_rdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_rooms;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox roomType_cmBox;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
    }
}