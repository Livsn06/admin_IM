namespace Admin
{
    partial class Enrollment
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.drop = new System.Windows.Forms.Button();
            this.enrollment_table = new System.Windows.Forms.DataGridView();
            this.enrollment_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stud_block = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.enrollment_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enroll Student";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(154, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enroll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(644, 47);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(250, 48);
            this.search.TabIndex = 8;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
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
            this.iconButton1.Location = new System.Drawing.Point(900, 46);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(51, 35);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(828, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // drop
            // 
            this.drop.BackColor = System.Drawing.Color.Firebrick;
            this.drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drop.ForeColor = System.Drawing.Color.White;
            this.drop.Location = new System.Drawing.Point(693, 471);
            this.drop.Name = "drop";
            this.drop.Size = new System.Drawing.Size(120, 43);
            this.drop.TabIndex = 13;
            this.drop.Text = "Drop";
            this.drop.UseVisualStyleBackColor = false;
            this.drop.Click += new System.EventHandler(this.button3_Click);
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
            this.stud_block});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.enrollment_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.enrollment_table.EnableHeadersVisualStyles = false;
            this.enrollment_table.Location = new System.Drawing.Point(14, 106);
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
            this.enrollment_table.TabIndex = 7;
            this.enrollment_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enrollment_table_CellClick);
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
            this.stud_id.FillWeight = 10F;
            this.stud_id.HeaderText = "Student ID";
            this.stud_id.MinimumWidth = 10;
            this.stud_id.Name = "stud_id";
            this.stud_id.ReadOnly = true;
            this.stud_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_lastname
            // 
            this.stud_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_lastname.FillWeight = 8F;
            this.stud_lastname.HeaderText = "Year";
            this.stud_lastname.MinimumWidth = 8;
            this.stud_lastname.Name = "stud_lastname";
            this.stud_lastname.ReadOnly = true;
            this.stud_lastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_firstname
            // 
            this.stud_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_firstname.FillWeight = 10F;
            this.stud_firstname.HeaderText = "Subject ID";
            this.stud_firstname.MinimumWidth = 10;
            this.stud_firstname.Name = "stud_firstname";
            this.stud_firstname.ReadOnly = true;
            this.stud_firstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stud_block
            // 
            this.stud_block.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stud_block.FillWeight = 15F;
            this.stud_block.HeaderText = "Subject taken";
            this.stud_block.MinimumWidth = 15;
            this.stud_block.Name = "stud_block";
            this.stud_block.ReadOnly = true;
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
            "--Set--",
            "Student Id",
            "Subject Id",
            "Year",
            "Description"});
            this.set_CB.Location = new System.Drawing.Point(441, 49);
            this.set_CB.MaxDropDownItems = 10;
            this.set_CB.Name = "set_CB";
            this.set_CB.Size = new System.Drawing.Size(200, 46);
            this.set_CB.TabIndex = 22;
            this.set_CB.Text = "--Set--";
            this.set_CB.SelectedIndexChanged += new System.EventHandler(this.set_CB_SelectedIndexChanged);
            // 
            // Enrollment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 532);
            this.Controls.Add(this.set_CB);
            this.Controls.Add(this.enrollment_table);
            this.Controls.Add(this.drop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Enrollment";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrollment_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button drop;
        public System.Windows.Forms.DataGridView enrollment_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollment_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stud_block;
        public System.Windows.Forms.ComboBox set_CB;
    }
}