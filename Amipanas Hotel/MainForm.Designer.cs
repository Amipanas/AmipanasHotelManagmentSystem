namespace Amipanas_Hotel
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_dashboard = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_slider = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rooms = new System.Windows.Forms.Button();
            this.btn_guest = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_main.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Controls.Add(this.panel_container);
            this.panel1.Controls.Add(this.panel_slider);
            this.panel1.Controls.Add(this.panel_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 758);
            this.panel1.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.label_exit);
            this.panel_header.Controls.Add(this.pictureBox2);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(190, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1112, 84);
            this.panel_header.TabIndex = 9;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Font = new System.Drawing.Font("B Koodak", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_exit.ForeColor = System.Drawing.Color.Khaki;
            this.label_exit.Location = new System.Drawing.Point(1065, 9);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(45, 49);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Amipanas_Hotel.Properties.Resources._5star;
            this.pictureBox2.Location = new System.Drawing.Point(6, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1125, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel_dashboard);
            this.panel_container.Location = new System.Drawing.Point(206, 90);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1087, 625);
            this.panel_container.TabIndex = 8;
            // 
            // panel_dashboard
            // 
            this.panel_dashboard.Controls.Add(this.pictureBox3);
            this.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dashboard.Location = new System.Drawing.Point(0, 0);
            this.panel_dashboard.Name = "panel_dashboard";
            this.panel_dashboard.Size = new System.Drawing.Size(1087, 625);
            this.panel_dashboard.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Amipanas_Hotel.Properties.Resources.banner;
            this.pictureBox3.Location = new System.Drawing.Point(3, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1081, 608);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel_slider
            // 
            this.panel_slider.BackColor = System.Drawing.Color.Khaki;
            this.panel_slider.Location = new System.Drawing.Point(190, 143);
            this.panel_slider.Name = "panel_slider";
            this.panel_slider.Size = new System.Drawing.Size(10, 140);
            this.panel_slider.TabIndex = 7;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.btn_logout);
            this.panel_main.Controls.Add(this.btn_rooms);
            this.panel_main.Controls.Add(this.btn_guest);
            this.panel_main.Controls.Add(this.btn_dashboard);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(190, 758);
            this.panel_main.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Black;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::Amipanas_Hotel.Properties.Resources.logout;
            this.btn_logout.Location = new System.Drawing.Point(0, 581);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_logout.Size = new System.Drawing.Size(185, 138);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = " خروج";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_rooms
            // 
            this.btn_rooms.BackColor = System.Drawing.Color.Black;
            this.btn_rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rooms.FlatAppearance.BorderSize = 0;
            this.btn_rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rooms.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_rooms.ForeColor = System.Drawing.Color.White;
            this.btn_rooms.Image = ((System.Drawing.Image)(resources.GetObject("btn_rooms.Image")));
            this.btn_rooms.Location = new System.Drawing.Point(0, 435);
            this.btn_rooms.Name = "btn_rooms";
            this.btn_rooms.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_rooms.Size = new System.Drawing.Size(185, 140);
            this.btn_rooms.TabIndex = 4;
            this.btn_rooms.Text = "اتاق‌ها";
            this.btn_rooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_rooms.UseVisualStyleBackColor = false;
            this.btn_rooms.Click += new System.EventHandler(this.btn_rooms_Click);
            // 
            // btn_guest
            // 
            this.btn_guest.BackColor = System.Drawing.Color.Black;
            this.btn_guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guest.FlatAppearance.BorderSize = 0;
            this.btn_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guest.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_guest.ForeColor = System.Drawing.Color.White;
            this.btn_guest.Image = global::Amipanas_Hotel.Properties.Resources.guest;
            this.btn_guest.Location = new System.Drawing.Point(0, 289);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_guest.Size = new System.Drawing.Size(185, 140);
            this.btn_guest.TabIndex = 2;
            this.btn_guest.Text = "مهمان‌ها";
            this.btn_guest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guest.UseVisualStyleBackColor = false;
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Black;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::Amipanas_Hotel.Properties.Resources.note;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 143);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(185, 140);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = " داشبورد";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 137);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(636, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "توسعه یافته توسط تیم آمیپاناس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "                     ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1302, 758);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " سامانه مدیریت هتل آمیپاناس";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_rooms;
        private System.Windows.Forms.Button btn_guest;
        private System.Windows.Forms.Panel panel_slider;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_dashboard;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}