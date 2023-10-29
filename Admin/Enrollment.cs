using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Enrollment : Form
    {
        string settedcb = "";
        MySqlConnection conn;
        string selectedId = "0", selectedstudid, selectedyear, selectedsubid, selecteddesc;
        //============ MY BUILT-IN METHODS =================
        private void databaseConnection()
        {
            try
            {
                string server = "server=localhost;";
                string uid = "uid=root;";
                string pass = "pass=;";
                string dbase = "database=cruddatabase;";
                conn = new MySqlConnection(server + uid + pass + dbase);
                conn.Open();
            }catch (Exception e)
            {
                MessageBox.Show("Error enrollment form DB connection: " + e.Message.ToString());
            }

        }

        private void displayEnrollmentTable()
        {
            string query = "SELECT enrollment_id, stud_id, stud_year, sub_id, sub_taken FROM enrollment_tbl";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enrollment_table.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
        }


        void deleteValue(string id, string subname)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to drop this student?\n\nID: " + selectedstudid + "\nSubject Taken: " + subname + "", "Notice!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string query = "DELETE FROM enrollment_tbl WHERE enrollment_id =" + id + "";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " on deleteValue function -> Student form");
                displayEnrollmentTable();
            }

            displayEnrollmentTable();
            selectedId = "0";

        }


        private void displaySearchResult()
        {
            enrollment_table.Rows.Clear();
            try
            {
                string query = "SELECT enrollment_id, stud_id, stud_year, sub_id, sub_taken FROM enrollment_tbl";
                string condition = "";

                if (settedcb == "Student Id" || settedcb == "--Set--")
                {
                    condition = "WHERE stud_id LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Subject Id")
                {
                    condition = "WHERE sub_id LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Year")
                {
                    condition = "WHERE stud_year LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Description")
                {
                    condition = "WHERE sub_taken LIKE '" + search.Text.ToString() + "%'";
                }


                query = query + " " + condition;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dp = cmd.ExecuteReader();

                while (dp.Read())
                {
                    enrollment_table.Rows.Add(dp[0].ToString(), dp[1].ToString(), dp[2].ToString(), dp[3].ToString(), dp[4].ToString());
                }
                dp.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error syntax: " + e.Message);
            }

        }


        //=====================================================



        public Enrollment()
        {
            InitializeComponent();
   
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            databaseConnection();
            displayEnrollmentTable();
            set_CB.Text = "--Set--";
            search.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedId == "0")
            {
                MessageBox.Show("Select student to delete..", "Notice");
            }
            else
            {
                deleteValue(selectedId, selecteddesc);

            }
            displayEnrollmentTable();
            displaySearchResult();
     
        }

        
        private void enrollment_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = enrollment_table.SelectedCells[0].Value.ToString();
            selectedstudid = enrollment_table.SelectedCells[1].Value.ToString();
            selectedyear = enrollment_table.SelectedCells[2].Value.ToString();
            selectedsubid = enrollment_table.SelectedCells[3].Value.ToString();
            selecteddesc = enrollment_table.SelectedCells[4].Value.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void set_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            settedcb = set_CB.Text;
            displaySearchResult();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            displaySearchResult();
        }
    }
}
