namespace Admin
{
    partial class Studentedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentedit));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.id_TB = new System.Windows.Forms.MaskedTextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lname_TB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_TB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.year_CB = new System.Windows.Forms.ComboBox();
            this.block_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.undo = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.id_TB);
            this.panel3.Controls.Add(this.generate);
            this.panel3.Location = new System.Drawing.Point(22, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 88);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(8, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id_TB
            // 
            this.id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_TB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id_TB.Location = new System.Drawing.Point(8, 31);
            this.id_TB.Mask = "99-UR-9999";
            this.id_TB.Name = "id_TB";
            this.id_TB.Size = new System.Drawing.Size(176, 41);
            this.id_TB.TabIndex = 13;
            this.id_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_TB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.id_TB_MaskInputRejected);
            this.id_TB.TextChanged += new System.EventHandler(this.id_TB_TextChanged);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.ForeColor = System.Drawing.Color.White;
            this.generate.Location = new System.Drawing.Point(190, 31);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(92, 31);
            this.generate.TabIndex = 12;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lastname";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lname_TB
            // 
            this.lname_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_TB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lname_TB.Location = new System.Drawing.Point(3, 37);
            this.lname_TB.Name = "lname_TB";
            this.lname_TB.Size = new System.Drawing.Size(378, 41);
            this.lname_TB.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.fname_TB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(19, 201);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(382, 84);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firstname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fname_TB
            // 
            this.fname_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_TB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fname_TB.Location = new System.Drawing.Point(3, 37);
            this.fname_TB.Name = "fname_TB";
            this.fname_TB.Size = new System.Drawing.Size(378, 41);
            this.fname_TB.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label6);
            this.flowLayoutPanel4.Controls.Add(this.lname_TB);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(20, 281);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(382, 84);
            this.flowLayoutPanel4.TabIndex = 16;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(305, 383);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(95, 32);
            this.edit.TabIndex = 10;
            this.edit.Text = "Save";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.add_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year / Block";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // year_CB
            // 
            this.year_CB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.year_CB.DropDownHeight = 100;
            this.year_CB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_CB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.year_CB.FormattingEnabled = true;
            this.year_CB.IntegralHeight = false;
            this.year_CB.Location = new System.Drawing.Point(3, 37);
            this.year_CB.MaxDropDownItems = 10;
            this.year_CB.Name = "year_CB";
            this.year_CB.Size = new System.Drawing.Size(111, 46);
            this.year_CB.Sorted = true;
            this.year_CB.TabIndex = 17;
            this.year_CB.Text = "--Year--";
            this.year_CB.SelectedIndexChanged += new System.EventHandler(this.year_CB_SelectedIndexChanged);
            this.year_CB.TextChanged += new System.EventHandler(this.year_CB_TextChanged);
            // 
            // block_CB
            // 
            this.block_CB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.block_CB.DropDownHeight = 100;
            this.block_CB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_CB.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.block_CB.FormattingEnabled = true;
            this.block_CB.IntegralHeight = false;
            this.block_CB.Location = new System.Drawing.Point(120, 37);
            this.block_CB.MaxDropDownItems = 10;
            this.block_CB.Name = "block_CB";
            this.block_CB.Size = new System.Drawing.Size(111, 46);
            this.block_CB.Sorted = true;
            this.block_CB.TabIndex = 18;
            this.block_CB.Text = "--Block--";
            this.block_CB.TextChanged += new System.EventHandler(this.block_CB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(294, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "*student form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.undo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel4);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.edit);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 438);
            this.panel2.TabIndex = 9;
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.ForeColor = System.Drawing.Color.White;
            this.undo.Location = new System.Drawing.Point(200, 383);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(95, 32);
            this.undo.TabIndex = 17;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.year_CB);
            this.flowLayoutPanel3.Controls.Add(this.block_CB);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(22, 116);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(383, 88);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Firebrick;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(19, 383);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 32);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(92, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(279, 34);
            this.title.TabIndex = 14;
            this.title.Text = "Update Student";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 114);
            this.panel1.TabIndex = 8;
            // 
            // Studentedit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(451, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Studentedit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Info";
            this.Load += new System.EventHandler(this.Studentedit_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox id_TB;
        public System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox lname_TB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox fname_TB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        public System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox year_CB;
        public System.Windows.Forms.ComboBox block_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button undo;
        public System.Windows.Forms.Button clear;
    }
}