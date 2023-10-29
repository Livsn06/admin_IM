using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Student : Form
    {
        MySqlConnection conn;
        string settedcb = "";
        string selectedId = "0", selectedlname, selectedyear, selectedblock, selectedfname;
        //------------------------------------------------------//

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

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }

        
        void showStudents()
        {
            string query = "SELECT id_no, lname, fname, block, year FROM student_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            student_table.Rows.Clear();

            while(dr.Read()){
                student_table.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            selectedId = "0";
            student_table.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            student_table.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }


        void deleteValue(string id, string name)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to remove this student?\n\nID: " + id + "\nNAME: " + name + "", "Notice!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string query = "DELETE FROM student_tbl WHERE id_no='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " on deleteValue function -> Student form");
                showStudents();
            }
            
            showStudents();

        }



        void updatePassValue()
        {
           Studentedit edit = new Studentedit();

            edit.sameID = selectedId;
            edit.sameLNAME = selectedlname;
            edit.sameFNAME = selectedfname;
            edit.sameBLOCK = selectedblock;
            edit.sameYEAR = selectedyear;

            edit.canEditId = false;
            edit.clear.Enabled = false;
            edit.clear.BackColor = Color.Gray;
            edit.clear.ForeColor = Color.White;
            edit.ShowDialog();

        }


        private void displaySearchResult()
        {
            student_table.Rows.Clear();
            try
            {
                string query = "SELECT id_no, lname, fname, block, year FROM student_tbl";
                string condition = "";

                if (settedcb == "Id" || settedcb == "--Set--")
                {
                    condition = "WHERE id_no LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Firstname")
                {
                    condition = "WHERE fname LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Lastname")
                {
                    condition = "WHERE lname LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Block")
                {
                    condition = "WHERE block LIKE '" + search.Text.ToString() + "%'";
                }
                if (settedcb == "Year")
                {
                    condition = "WHERE year LIKE '" + search.Text.ToString() + "%'";
                }

                query = query + " " + condition;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dp = cmd.ExecuteReader();

                while (dp.Read())
                {
                    student_table.Rows.Add(dp[0].ToString(), dp[1].ToString(), dp[2].ToString(), dp[3].ToString(), dp[4].ToString());
                }
                dp.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error syntax: " + e.Message);
            }

        }


        //-------------------------------------------------------//

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            databaseConnection();
            showStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studentadd studentadd = new Studentadd();
            studentadd.title.Text = "Add Student";
            studentadd.add.Visible = true;

            studentadd.id_TB.ReadOnly = false;
            studentadd.generate.Visible = true;

            studentadd.add.BringToFront();
            studentadd.ShowDialog();

            showStudents();
            displaySearchResult();

        }


  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            displaySearchResult();
        }
        
        private void set_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            settedcb = set_CB.Text;
            displaySearchResult();
        }

        private void student_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void student_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = student_table.SelectedCells[0].Value.ToString();
            selectedlname = student_table.SelectedCells[1].Value.ToString();
            selectedfname = student_table.SelectedCells[2].Value.ToString();
            selectedblock = student_table.SelectedCells[3].Value.ToString();
            selectedyear = student_table.SelectedCells[4].Value.ToString();

            
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (selectedId == "0")
            {
                MessageBox.Show("Select student to delete..", "Notice");
            }
            else
            {
                string name = selectedfname + " " + selectedlname;
                deleteValue(selectedId, name);

            }

            showStudents();
            displaySearchResult();
        }
     
        

        private void edit_Click(object sender, EventArgs e)
        {

            if (selectedId == "0")
            {
                MessageBox.Show("Select student to update..","Notice");
            }
            else
            {
                updatePassValue();

            }
            
            showStudents();
            displaySearchResult();
        }

        private void student_table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            student_table.RowsDefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            student_table.RowsDefaultCellStyle.SelectionForeColor = Color.Teal;
        }
    }
}
