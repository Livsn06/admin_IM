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

        MySqlConnection conn;
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
                displayEnrollmentTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

        }

        private void displayEnrollmentTable()
        {
            string query = "SELECT enrollment_id, stud_id, lname, fname, block, year FROM enrollment_tbl";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enrollment_table.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
        }


        public void deleteSelectedRow(string id)
        {
            string query = "DELETE FROM enrollment_tbl WHERE enrollment_id =" + id + "";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            enrollment_table.Refresh();
        }



        //=====================================================



        public Enrollment()
        {
            InitializeComponent();
   
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            databaseConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void enrollment_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = enrollment_table.SelectedCells[0].Value.ToString();
            deleteSelectedRow(id);
        }
    }
}
