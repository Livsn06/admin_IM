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
            this.enrollment_table = new System.Windows.Forms.DataGridView();
            this.enrollment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.enrollment_table)).BeginInit();
            this.SuspendLayout();
            // 
            // enrollment_table
            // 
            this.enrollment_table.AllowUserToAddRows = false;
            this.enrollment_table.AllowUserToDeleteRows = false;
            this.enrollment_table.BackgroundColor = System.Drawing.Color.White;
            this.enrollment_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enrollment_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.enrollment_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrollment_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrollment_id,
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
            this.enrollment_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.enrollment_table.EnableHeadersVisualStyles = false;
            this.enrollment_table.Location = new System.Drawing.Point(14, 105);
            this.enrollment_table.MultiSelect = false;
            this.enrollment_table.Name = "enrollment_table";
            this.enrollment_table.ReadOnly = true;
            this.enrollment_table.RowHeadersVisible = false;
            this.enrollment_table.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            this.enrollment_table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.enrollment_table.RowTemplate.Height = 28;
            this.enrollment_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enrollment_table.Size = new System.Drawing.Size(949, 342);
            this.enrollment_table.TabIndex = 14;
            this.enrollment_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enrollment_table_CellContentClick);
            // 
            // enrollment_id
            // 
            this.enrollment_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enrollment_id.FillWeight = 5F;
            this.enrollment_id.HeaderText = "id";
            this.enrollment_id.MinimumWidth = 8;
            this.enrollment_id.Name = "enrollment_id";
            this.enrollment_id.ReadOnly = true;
            this.enrollment_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.enrollment_id.Visible = false;
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
            this.delete.Location = new System.Drawing.Point(693, 470);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 43);
            this.delete.TabIndex = 20;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(828, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 43);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.Transparent;
            this.add.Location = new System.Drawing.Point(169, 40);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 38);
            this.add.TabIndex = 18;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Students";
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
            this.iconButton1.Location = new System.Drawing.Point(900, 45);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 35);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(644, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 48);
            this.textBox1.TabIndex = 15;
            // 
            // Student
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.enrollment_table);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.enrollment_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView enrollment_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_block;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_year;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}