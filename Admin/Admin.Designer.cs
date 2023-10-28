namespace Admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enrol_icon = new FontAwesome.Sharp.IconButton();
            this.enrollments = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub_icon = new FontAwesome.Sharp.IconButton();
            this.subjects = new System.Windows.Forms.Label();
            this.dash_icon = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.profile_menu = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.student_icon = new FontAwesome.Sharp.IconButton();
            this.student = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.profile_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.student_icon);
            this.panel1.Controls.Add(this.student);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.enrol_icon);
            this.panel1.Controls.Add(this.enrollments);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sub_icon);
            this.panel1.Controls.Add(this.subjects);
            this.panel1.Controls.Add(this.dash_icon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 638);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bradley Hand ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(30, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "@ 2023 LivSN, All Right Reserve";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // enrol_icon
            // 
            this.enrol_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrol_icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.enrol_icon.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.enrol_icon.IconColor = System.Drawing.Color.White;
            this.enrol_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.enrol_icon.IconSize = 40;
            this.enrol_icon.Location = new System.Drawing.Point(36, 479);
            this.enrol_icon.Name = "enrol_icon";
            this.enrol_icon.Size = new System.Drawing.Size(37, 35);
            this.enrol_icon.TabIndex = 13;
            this.enrol_icon.UseVisualStyleBackColor = true;
            // 
            // enrollments
            // 
            this.enrollments.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollments.ForeColor = System.Drawing.Color.White;
            this.enrollments.Location = new System.Drawing.Point(-7, 454);
            this.enrollments.Name = "enrollments";
            this.enrollments.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.enrollments.Size = new System.Drawing.Size(320, 83);
            this.enrollments.TabIndex = 12;
            this.enrollments.Text = " Enrollment           〉";
            this.enrollments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enrollments.Click += new System.EventHandler(this.enrollments_Click);
            this.enrollments.MouseLeave += new System.EventHandler(this.enrollments_MouseLeave);
            this.enrollments.MouseHover += new System.EventHandler(this.enrollments_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(31, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "NAVIGATIONS";
            // 
            // sub_icon
            // 
            this.sub_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub_icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sub_icon.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.sub_icon.IconColor = System.Drawing.Color.White;
            this.sub_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_icon.IconSize = 40;
            this.sub_icon.Location = new System.Drawing.Point(34, 389);
            this.sub_icon.Name = "sub_icon";
            this.sub_icon.Size = new System.Drawing.Size(37, 35);
            this.sub_icon.TabIndex = 10;
            this.sub_icon.UseVisualStyleBackColor = true;
            // 
            // subjects
            // 
            this.subjects.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects.ForeColor = System.Drawing.Color.White;
            this.subjects.Location = new System.Drawing.Point(-2, 365);
            this.subjects.Name = "subjects";
            this.subjects.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.subjects.Size = new System.Drawing.Size(320, 83);
            this.subjects.TabIndex = 9;
            this.subjects.Text = "Subjects               〉";
            this.subjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjects.Click += new System.EventHandler(this.subjects_Click);
            this.subjects.MouseLeave += new System.EventHandler(this.subjects_MouseLeave);
            this.subjects.MouseHover += new System.EventHandler(this.subjects_MouseHover);
            // 
            // dash_icon
            // 
            this.dash_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dash_icon.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.dash_icon.IconColor = System.Drawing.Color.White;
            this.dash_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dash_icon.IconSize = 40;
            this.dash_icon.Location = new System.Drawing.Point(37, 158);
            this.dash_icon.Name = "dash_icon";
            this.dash_icon.Size = new System.Drawing.Size(37, 35);
            this.dash_icon.TabIndex = 7;
            this.dash_icon.UseVisualStyleBackColor = true;
            this.dash_icon.Click += new System.EventHandler(this.dash_icon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(103, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "AdminQR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 134);
            this.label4.TabIndex = 6;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.Location = new System.Drawing.Point(0, 137);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(311, 80);
            this.dashboard.TabIndex = 5;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Click += new System.EventHandler(this.label2_Click);
            this.dashboard.MouseLeave += new System.EventHandler(this.dashboard_MouseLeave);
            this.dashboard.MouseHover += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 218);
            this.label3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.main_label);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(305, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 74);
            this.panel2.TabIndex = 2;
            // 
            // main_label
            // 
            this.main_label.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.main_label.Location = new System.Drawing.Point(25, 28);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(210, 30);
            this.main_label.TabIndex = 16;
            this.main_label.Text = "Dashboard";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(919, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconButton1.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(847, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 37);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainpanel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainpanel.Location = new System.Drawing.Point(322, 90);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(978, 532);
            this.mainpanel.TabIndex = 3;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // profile_menu
            // 
            this.profile_menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.profile_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profile_menu.Controls.Add(this.textBox2);
            this.profile_menu.Controls.Add(this.textBox1);
            this.profile_menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profile_menu.Location = new System.Drawing.Point(1159, 63);
            this.profile_menu.Name = "profile_menu";
            this.profile_menu.Size = new System.Drawing.Size(138, 157);
            this.profile_menu.TabIndex = 0;
            this.profile_menu.Visible = false;
            this.profile_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.profile_menu_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(4, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Log out";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(4, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Update Profile";
            // 
            // student_icon
            // 
            this.student_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.student_icon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.student_icon.IconColor = System.Drawing.Color.White;
            this.student_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.student_icon.IconSize = 40;
            this.student_icon.Location = new System.Drawing.Point(35, 299);
            this.student_icon.Name = "student_icon";
            this.student_icon.Size = new System.Drawing.Size(37, 35);
            this.student_icon.TabIndex = 16;
            this.student_icon.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(-1, 275);
            this.student.Name = "student";
            this.student.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.student.Size = new System.Drawing.Size(320, 83);
            this.student.TabIndex = 15;
            this.student.Text = "Students              〉";
            this.student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student.Click += new System.EventHandler(this.student_Click);
            this.student.MouseLeave += new System.EventHandler(this.student_MouseLeave);
            this.student.MouseHover += new System.EventHandler(this.student_MouseHover);
            // 
            // Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1314, 634);
            this.Controls.Add(this.profile_menu);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseHover += new System.EventHandler(this.Admin_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.profile_menu.ResumeLayout(false);
            this.profile_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dashboard;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton dash_icon;
        private FontAwesome.Sharp.IconButton sub_icon;
        private System.Windows.Forms.Label subjects;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton enrol_icon;
        private System.Windows.Forms.Label enrollments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel profile_menu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label main_label;
        private FontAwesome.Sharp.IconButton student_icon;
        private System.Windows.Forms.Label student;
    }
}

