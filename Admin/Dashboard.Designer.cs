namespace Admin
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.admin_table = new System.Windows.Forms.DataGridView();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dash_subid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dash_enrolled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_btn = new FontAwesome.Sharp.IconButton();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.overall_students = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.overall_subjects = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sub_select = new System.Windows.Forms.ComboBox();
            this.block_select = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_table
            // 
            this.admin_table.AllowUserToAddRows = false;
            this.admin_table.AllowUserToDeleteRows = false;
            this.admin_table.BackgroundColor = System.Drawing.Color.White;
            this.admin_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.admin_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stud_id,
            this.stud_lastname,
            this.stud_year,
            this.block,
            this.dash_subid,
            this.dash_enrolled});
            this.admin_table.EnableHeadersVisualStyles = false;
            this.admin_table.Location = new System.Drawing.Point(41, 331);
            this.admin_table.MultiSelect = false;
            this.admin_table.Name = "admin_table";
            this.admin_table.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.admin_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.admin_table.RowHeadersVisible = false;
            this.admin_table.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            this.admin_table.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.admin_table.RowTemplate.Height = 28;
            this.admin_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.admin_table.Size = new System.Drawing.Size(890, 342);
            this.admin_table.TabIndex = 14;
            // 
            // stud_id
            // 
            this.stud_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stud_id.FillWeight = 6F;
            this.stud_id.Frozen = true;
            this.stud_id.HeaderText = "ID";
            this.stud_id.MinimumWidth = 6;
            this.stud_id.Name = "stud_id";
            this.stud_id.ReadOnly = true;
            this.stud_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stud_id.Width = 129;
            // 
            // stud_lastname
            // 
            this.stud_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stud_lastname.FillWeight = 15F;
            this.stud_lastname.Frozen = true;
            this.stud_lastname.HeaderText = "Lastname";
            this.stud_lastname.MinimumWidth = 15;
            this.stud_lastname.Name = "stud_lastname";
            this.stud_lastname.ReadOnly = true;
            this.stud_lastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stud_lastname.Width = 197;
            // 
            // stud_year
            // 
            this.stud_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stud_year.FillWeight = 5F;
            this.stud_year.Frozen = true;
            this.stud_year.HeaderText = "Year";
            this.stud_year.MinimumWidth = 8;
            this.stud_year.Name = "stud_year";
            this.stud_year.ReadOnly = true;
            this.stud_year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stud_year.Width = 87;
            // 
            // block
            // 
            this.block.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.block.FillWeight = 5F;
            this.block.HeaderText = "Block";
            this.block.MinimumWidth = 8;
            this.block.Name = "block";
            this.block.ReadOnly = true;
            // 
            // dash_subid
            // 
            this.dash_subid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dash_subid.FillWeight = 8F;
            this.dash_subid.HeaderText = "Subject ID";
            this.dash_subid.MinimumWidth = 8;
            this.dash_subid.Name = "dash_subid";
            this.dash_subid.ReadOnly = true;
            this.dash_subid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dash_enrolled
            // 
            this.dash_enrolled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dash_enrolled.FillWeight = 11F;
            this.dash_enrolled.HeaderText = "Subject Name";
            this.dash_enrolled.MinimumWidth = 11;
            this.dash_enrolled.Name = "dash_enrolled";
            this.dash_enrolled.ReadOnly = true;
            this.dash_enrolled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.ForeColor = System.Drawing.Color.Transparent;
            this.search_btn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.search_btn.IconColor = System.Drawing.Color.White;
            this.search_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.search_btn.IconSize = 20;
            this.search_btn.Location = new System.Drawing.Point(258, 23);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(51, 35);
            this.search_btn.TabIndex = 16;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(2, 24);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(250, 48);
            this.searchbox.TabIndex = 15;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.overall_students);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(41, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 191);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(183, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "0 Recently added";
            // 
            // overall_students
            // 
            this.overall_students.AutoSize = true;
            this.overall_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overall_students.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.overall_students.Location = new System.Drawing.Point(183, 87);
            this.overall_students.Name = "overall_students";
            this.overall_students.Size = new System.Drawing.Size(158, 22);
            this.overall_students.TabIndex = 2;
            this.overall_students.Text = "0 Overall Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. of Students Enrolled";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.overall_subjects);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(498, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 186);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(187, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "0 Recently added";
            // 
            // overall_subjects
            // 
            this.overall_subjects.AutoSize = true;
            this.overall_subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overall_subjects.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.overall_subjects.Location = new System.Drawing.Point(187, 87);
            this.overall_subjects.Name = "overall_subjects";
            this.overall_subjects.Size = new System.Drawing.Size(156, 22);
            this.overall_subjects.TabIndex = 2;
            this.overall_subjects.Text = "0 Overall Subjects";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(17, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "No. of Subjects";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.sub_select);
            this.panel3.Controls.Add(this.block_select);
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Controls.Add(this.searchbox);
            this.panel3.Location = new System.Drawing.Point(41, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 449);
            this.panel3.TabIndex = 19;
            // 
            // sub_select
            // 
            this.sub_select.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sub_select.DropDownHeight = 100;
            this.sub_select.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_select.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sub_select.FormattingEnabled = true;
            this.sub_select.IntegralHeight = false;
            this.sub_select.Location = new System.Drawing.Point(382, 25);
            this.sub_select.Name = "sub_select";
            this.sub_select.Size = new System.Drawing.Size(387, 48);
            this.sub_select.Sorted = true;
            this.sub_select.TabIndex = 1;
            this.sub_select.Text = "Subjects";
            this.sub_select.SelectedIndexChanged += new System.EventHandler(this.sub_select_SelectedIndexChanged);
            // 
            // block_select
            // 
            this.block_select.BackColor = System.Drawing.SystemColors.HighlightText;
            this.block_select.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_select.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.block_select.FormattingEnabled = true;
            this.block_select.Items.AddRange(new object[] {
            "--Blocks--",
            "A",
            "B",
            "C",
            "D"});
            this.block_select.Location = new System.Drawing.Point(775, 25);
            this.block_select.Name = "block_select";
            this.block_select.Size = new System.Drawing.Size(111, 48);
            this.block_select.TabIndex = 0;
            this.block_select.Text = "--Blocks--";
            this.block_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.admin_table);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton search_btn;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label overall_subjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label overall_students;
        public System.Windows.Forms.DataGridView admin_table;
        public System.Windows.Forms.ComboBox block_select;
        public System.Windows.Forms.ComboBox sub_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn block;
        private System.Windows.Forms.DataGridViewTextBoxColumn dash_subid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dash_enrolled;
    }
}