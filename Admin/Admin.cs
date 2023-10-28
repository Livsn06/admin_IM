using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Admin : Form
    {
        Dashboard dash = new Dashboard();
        Enrollment enrolled = new Enrollment();
       
        //============ MY BUILT-IN METHODS =================

        private void changePanel(Form selectedform, string title)
        {
            main_label.Text = title; // <------------ set the label of new container
            selectedform.TopLevel = false; // <-------- required to be false
            mainpanel.Controls.Clear(); // <-------- remove the existing panel        
            mainpanel.Controls.Add(selectedform); // <-------- add the new form  
            selectedform.Dock = DockStyle.Fill; // <-------- fill the whole space of parent container
            mainpanel.BringToFront(); // <-------- bring into the front  
            selectedform.Show(); // <-------- show form into the panel
        }

        private void databaseConnection(){
            try
            {
                string server = "server=localhost;";
                string uid = "uid=root;";
                string pass = "pass=;";
                string dbase = "database=cruddatabase;";
                MySqlConnection conn = new MySqlConnection(server + uid + pass + dbase);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't connect to database!", "Database Status");
                this.Close();
            }
            MessageBox.Show("Database connected..", "Database Status");

        }

        //=====================================================

        public Admin()
        {
            InitializeComponent();
        }
    
        private void Admin_Load(object sender, EventArgs e)
        {
            databaseConnection();
            changePanel(dash, "Dashboard");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dashboard.BackColor = Color.Teal;
            dash_icon.BackColor = Color.Teal;
            dash_icon.ForeColor = Color.Teal;
        }

        private void Admin_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            changePanel(dash, "Dashboard");
        }

        private void dashboard_MouseLeave(object sender, EventArgs e)
        {
            dashboard.BackColor= Color.DarkSlateGray;
            dash_icon.BackColor= Color.DarkSlateGray;
            dash_icon.ForeColor= Color.DarkSlateGray;
        }

        private void dash_icon_Click(object sender, EventArgs e)
        {

        }

        private void subjects_Click(object sender, EventArgs e)
        {
            
        }

        private void subjects_MouseHover(object sender, EventArgs e)
        {
            subjects.BackColor = Color.Teal;
            sub_icon.BackColor = Color.Teal;
            sub_icon.ForeColor = Color.Teal;
        }

        private void subjects_MouseLeave(object sender, EventArgs e)
        {
            subjects.BackColor = Color.DarkSlateGray;
            sub_icon.BackColor = Color.DarkSlateGray;
            sub_icon.ForeColor = Color.DarkSlateGray;
        }

        private void enrollments_Click(object sender, EventArgs e)
        {
            changePanel(enrolled, "Enrollment");
        }

        private void enrollments_MouseHover(object sender, EventArgs e)
        {
            enrollments.BackColor = Color.Teal;
            enrol_icon.BackColor = Color.Teal;
            enrol_icon.ForeColor = Color.Teal;

        }

        private void enrollments_MouseLeave(object sender, EventArgs e)
        {
            enrollments.BackColor = Color.DarkSlateGray;
            enrol_icon.BackColor = Color.DarkSlateGray;
            enrol_icon.ForeColor = Color.DarkSlateGray;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
 
        }

        private void panel1_Move(object sender, EventArgs e)
        {
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            profile_menu.BringToFront();
            profile_menu.Show();
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }


        private void profile_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            profile_menu.BringToFront();
            profile_menu.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            profile_menu.SendToBack();
            profile_menu.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Student stud = new Student();

            changePanel(stud, "Student");
        }

        private void student_MouseHover(object sender, EventArgs e)
        {
            student.BackColor = Color.Teal;
            student_icon.BackColor = Color.Teal;
            student_icon.ForeColor = Color.Teal;

        }

        private void student_MouseLeave(object sender, EventArgs e)
        {
            student.BackColor = Color.DarkSlateGray;
            student_icon.BackColor = Color.DarkSlateGray;
            student_icon.ForeColor = Color.DarkSlateGray;
        }
    }
}
