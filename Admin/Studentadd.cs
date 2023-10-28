using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Studentadd : Form
    {

        MySqlConnection conn;
        //---------------------------------------------//
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

        private void verifyInputs(string id, string block, string year, string lname, string fname)
        {

            lname = lname[0].ToString().ToUpper() + lname.Substring(1).ToLower();
            fname = fname[0].ToString().ToUpper() + fname.Substring(1).ToLower();

            if (!isNameOrganized(lname, fname))
            {
               DialogResult res = MessageBox.Show("Invalid name!", "Warning!");
               
            }
            else if (!isValidID(id))
            {
                DialogResult res = MessageBox.Show("Invalid ID!", "Warning!");

            }
            else if (!isDistinctID(id))
            {
                DialogResult res = MessageBox.Show(id+ " is already exist!", "Warning!");
                
            }
            else if (!isLettersOnly(block = block.ToUpper()))
            {
                DialogResult res = MessageBox.Show("Invalid Block", "Warning!");
                
            }
            else if (!isExistingYear(year))
            {
                DialogResult res = MessageBox.Show("This year level don't exist", "Warning!");
            }
            else if (!isExistingBlock(block))
            {
                DialogResult res = MessageBox.Show("This block don't exist", "Warning!");
            }
            else
            {
                InsertValue(id, block, year, lname, fname);
            }
        }


         public bool isDistinctID(string val)
        {
            val = val.ToString();
            val = val.ToUpper();

            string query = "SELECT id_no FROM student_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (val.Equals(rd[0].ToString()))
                {
                    rd.Close();
                    return false;
                }
            }
            rd.Close();
            return true;
        }
        bool isNameOrganized(string lname, string fname)
        {
            try
            {
                if ((isLettersOnly(lname) && isLettersOnly(fname)))
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        bool isExistingBlock(string val)
        {
            val = val.ToString();
            val = val.ToUpper();

            string query = "SELECT block FROM block_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (val.Equals(rd[0].ToString()))
                {
                    rd.Close();
                    return true;
                }
            }
            rd.Close();
            return false;


        }

        bool isExistingYear(string val)
        {
            val = val.ToString();
            val = val.ToUpper();

            string query = "SELECT year FROM year_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (val.Equals(rd[0].ToString()))
                {
                    rd.Close();
                    return true;
                }
            }
            rd.Close();
            return false;

        }


        bool isValidID(string val)
        {
            val = val.ToString();
            val = val.ToUpper();
            var regexItem = new Regex("^[0-9]{2}-UR-[0-9]{4}$");

            if (regexItem.IsMatch(val))
            {
                return true;
            }
            return false;
        }


        bool containsNumber(string val)
        {
            val = val.ToString();
            var regexItem = new Regex("^[0-9]*$");

            if (regexItem.IsMatch(val))
            {
                return true;
            }
            return false;
        }

        bool isLettersOnly(string val)
        {
            val = val.ToString();
            var regexItem = new Regex("^([a-zA-Z]|\\s)*?$");

            if (regexItem.IsMatch(val))
            {
                return true;
            }
            return false;
        }

        string generateId()
        {
            Random rnd = new Random();
            string val1 = DateTime.Now.ToString("M-d-yyyy");
            val1 = val1.Substring(val1.Length - 2);
            string val2 = "";
            while (val2.Length < 4)
            {
                val2 += rnd.Next(10).ToString();
            }
           
            string result = val1 + "-UR-" + val2;

            if (!isDistinctID(result))
            {
                generateId();
            }
            return result;
        }

        void InsertValue(string id, string block, string year, string lname, string fname)
        {
            try
            {
                string query = "INSERT INTO student_tbl (id_no, lname, fname, block, year) "
                         + "VALUES ('" + id + "', '" + lname + "', '" + fname + "','" + block + "','" + year + "')";

                DialogResult result = MessageBox.Show("You are adding "+ id +"\nConfirm action..","Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully..");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Adding Cancel..");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error data insertion!!", "Warning!");
            }
        }

        void showBlocks()
        {
            string query = "SELECT block FROM block_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            block_CB.Items.Clear();
            block_CB.Items.Add("--Blocks--");
            while (rd.Read())
            {
                block_CB.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        void showYears()
        {
            string query = "SELECT year FROM year_tbl";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            year_CB.Items.Clear();
            year_CB.Items.Add("--Year--");
            while (rd.Read())
            {
                year_CB.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        //--------------------------------------------//
        public Studentadd()
        {
            InitializeComponent();
        }

        private void Studentadd_Load(object sender, EventArgs e)
        {
            databaseConnection();
            showYears();
            showBlocks();   
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id_TB.Text = generateId();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            verifyInputs(id_TB.Text, block_CB.Text, year_CB.Text, lname_TB.Text, fname_TB.Text);
        }

        private void year_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void year_CB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void block_CB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void id_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
