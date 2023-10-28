using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Dashboard : Form
    {

        MySqlConnection conn;
        bool isBlock = false;
        bool isSearch = false;
        bool isSubject = false;
        string Block, Search, Subject;


        //===========================================

        private void databaseConnection()
        {
            try
            {
                string server = "server=localhost;";
                string uid = "uid=root;";
                string pass = "pass=;";
                string dbase = "database=cruddatabase";
                conn = new MySqlConnection(server + uid + pass + dbase);
                conn.Open();
                displayTableValue();
                displaySubjectValue();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't connect to database!", "Database Status");
            }

        }

        private void displayTableValue()
        {
            try
            {
                string selectColumn = "SELECT e.stud_id, e.lname, e.year, e.block, s.id, s.description FROM enrollment_tbl e, subject_tbl s";
                string condition = "WHERE e.sub_id = s.id";
                string query = selectColumn + " " + condition;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int total_student = 0;
                admin_table.Rows.Clear();


                MySqlDataReader dp = cmd.ExecuteReader();
                while (dp.Read())
                {
                    ++total_student;
                    admin_table.Rows.Add(dp[0].ToString(), dp[1].ToString(), dp[2].ToString(), dp[3].ToString(), dp[4].ToString(), dp[5].ToString());
                }
                overall_students.Text =  total_student.ToString() + " overall students" ;
                dp.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Wrong syntax!!");
            }
        }

        private void displaySubjectValue()
        {
            try
            {
                string query = "SELECT * FROM subject_tbl";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int total_subject = 0;

                sub_select.Items.Clear();
                sub_select.Items.Add("--Subjects--");
                sub_select.SelectedItem = "--Subjects--";
                block_select.SelectedItem = "--Blocks--";
                sub_select.Refresh();
                MySqlDataReader dp = cmd.ExecuteReader();
                while (dp.Read())
                {
                    ++total_subject;
                    sub_select.Items.Add(dp[1].ToString());
                }
       
                overall_subjects.Text = total_subject.ToString() + " overall subjects";
                dp.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Wrong syntax!!");
            }
        }

        private void displaySearchResult()
        {
            admin_table.Rows.Clear();
            try
            {
                string query = "SELECT e.stud_id, e.lname, e.year, e.block, s.id, s.description FROM enrollment_tbl e INNER JOIN subject_tbl s ON e.sub_id = s.id";
                string condition = "";

                if (isBlock && isSearch == false && isSubject == false)
                {
                    condition = "WHERE e.block LIKE '%" + Block + "%'";

                }
                else if (isSubject && isSearch == false && isBlock == false)
                {
                    condition = "WHERE s.description LIKE '%" + Subject + "%'";

                }
                else if (isSearch && isSubject == false && isBlock == false)
                {
                    condition = "WHERE e.stud_id LIKE '" + Search + "%' OR e.lname LIKE '" + Search + "%'";

                }
                else if (isSubject && isBlock && isSearch == false)
                {
                
                    condition = "WHERE e.block LIKE '%" + Block + "%' AND s.description LIKE '%" + Subject + "%'";

                }
                else if (isSearch && isSubject && isBlock ==false)
                {
                    condition = "WHERE e.stud_id LIKE '" + Search + "%' OR e.lname LIKE '" + Search + "%' AND s.description LIKE '%" + Subject + "%'";


                }
                else if (isSearch && isBlock && isSubject == false)
                {
                    condition = "WHERE e.stud_id LIKE '" + Search + "%' OR e.lname LIKE '" + Search + "%' AND e.block LIKE '%" + Block + "%'";

                }
                else if (isSearch && isSubject && isBlock)
                {
                    condition = "WHERE e.stud_id LIKE '" + Search + "%'  AND e.block LIKE '%" + Block + "%' AND  s.description LIKE '%" + Subject + "%'  OR  e.lname LIKE '" + Search + "%' AND e.block LIKE '%" + Block + "%' AND  s.description LIKE '%" + Subject + "%'";

                }
                else if (isSearch==false && isSubject==false && isBlock == false)
                {
                    query = "SELECT e.stud_id, e.lname, e.year, e.block, s.id, s.description FROM enrollment_tbl e, subject_tbl s";
                    condition = "WHERE e.sub_id = s.id";

                }
                else
                {
                    admin_table.Rows.Clear();
                }


                query = query + " " + condition;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dp = cmd.ExecuteReader();

                while (dp.Read())
                {
                    admin_table.Rows.Add(dp[0].ToString(), dp[1].ToString(), dp[2].ToString(), dp[3].ToString(), dp[4].ToString(), dp[5].ToString());
                }
                dp.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error syntax");
            }

        }
    

        //==========================================

        public Dashboard()
        {
            InitializeComponent();
            databaseConnection();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (block_select.SelectedIndex == 0)
            {
                isBlock = false;
                displaySearchResult();
            }
            else
            {
                isBlock = true;
                Block = block_select.Text;
                displaySearchResult();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            displaySearchResult();
        }

        private void sub_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sub_select.SelectedIndex == 0)
            {
                isSubject = false;
                displaySearchResult();
            }
            else
            {
                isSubject = true;
                Subject = sub_select.Text;
                displaySearchResult();
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {       
            if (searchbox.Text.Trim().Length == 0)
            {
                admin_table.Rows.Clear();
                isSearch = false;
                displaySearchResult();
            }
            else
            {
                isSearch = true;
                Search = searchbox.Text;
                displaySearchResult();
            }
         
        }

    }
}
