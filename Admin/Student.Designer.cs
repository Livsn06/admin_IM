namespace Admin
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.student_table = new System.Windows.Forms.DataGridView();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.search = new System.Windows.Forms.TextBox();
            this.set_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.student_table)).BeginInit();
            this.SuspendLayout();
            // 
            // student_table
            // 
            this.student_table.AllowUserToAddRows = false;
            this.student_table.AllowUserToDeleteRows = false;
            this.student_table.BackgroundColor = System.Drawing.Color.White;
            this.student_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.student_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.student_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stud_id,
            this.stud_lastname,
            this.stud_firstname,
            this.stud_block,
            this.stud_year});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.student_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.student_table.EnableHeadersVisualStyles = false;
            this.student_table.Location = new System.Drawing.Point(14, 90);
            this.student_table.MultiSelect = false;
            this.student_table.Name = "student_table";
            this.student_table.ReadOnly = true;
            this.student_table.RowHeadersVisible = false;
            this.student_table.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.student_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.student_table.RowTemplate.Height = 28;
            this.student_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.student_table.Size = new System.Drawing.Size(949, 355);
            this.student_table.TabIndex = 14;
            this.student_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_table_CellClick);
            this.student_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_table_CellContentClick);
            this.student_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.student_table_CellMouseClick);
            // 
            // stud_id
            // 
            this.stud_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_id.FillWeight = 15F;
            this.stud_id.HeaderText = "Student ID";
            this.stud_id.MinimumWidth = 15;
            this.stud_id.Name = "stud_id";
            this.stud_id.ReadOnly = true;
            this.stud_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_lastname
            // 
            this.stud_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_lastname.FillWeight = 25F;
            this.stud_lastname.HeaderText = "Lastname";
            this.stud_lastname.MinimumWidth = 25;
            this.stud_lastname.Name = "stud_lastname";
            this.stud_lastname.ReadOnly = true;
            this.stud_lastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_firstname
            // 
            this.stud_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_firstname.FillWeight = 25F;
            this.stud_firstname.HeaderText = "Firstname";
            this.stud_firstname.MinimumWidth = 25;
            this.stud_firstname.Name = "stud_firstname";
            this.stud_firstname.ReadOnly = true;
            this.stud_firstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_block
            // 
            this.stud_block.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_block.FillWeight = 10F;
            this.stud_block.HeaderText = "Block";
            this.stud_block.MinimumWidth = 10;
            this.stud_block.Name = "stud_block";
            this.stud_block.ReadOnly = true;
            // 
            // stud_year
            // 
            this.stud_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_year.FillWeight = 10F;
            this.stud_year.HeaderText = "Year";
            this.stud_year.MinimumWidth = 10;
            this.stud_year.Name = "stud_year";
            this.stud_year.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Firebrick;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(699, 461);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 43);
            this.delete.TabIndex = 20;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(14, 41);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(120, 35);
            this.edit.TabIndex = 19;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.Transparent;
            this.add.Location = new System.Drawing.Point(838, 461);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 44);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(900, 37);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 35);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.search.Location = new System.Drawing.Point(644, 38);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(250, 48);
            this.search.TabIndex = 15;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // set_CB
            // 
            this.set_CB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.set_CB.DropDownHeight = 100;
            this.set_CB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_CB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.set_CB.FormattingEnabled = true;
            this.set_CB.IntegralHeight = false;
            this.set_CB.Items.AddRange(new object[] {
            "Id",
            "Firstname",
            "Lastname",
            "Block",
            "Year"});
            this.set_CB.Location = new System.Drawing.Point(501, 39);
            this.set_CB.MaxDropDownItems = 10;
            this.set_CB.Name = "set_CB";
            this.set_CB.Size = new System.Drawing.Size(137, 46);
            this.set_CB.TabIndex = 21;
            this.set_CB.Text = "--Set--";
            this.set_CB.SelectedIndexChanged += new System.EventHandler(this.set_CB_SelectedIndexChanged);
            // 
            // Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.set_CB);
            this.Controls.Add(this.student_table);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView student_table;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_block;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_year;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.ComboBox set_CB;
    }
}