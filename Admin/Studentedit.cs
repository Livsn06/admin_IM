using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Admin
{
    public partial class Studentedit : Form
    {
        MySqlConnection conn;

       public string sameID = "", sameLNAME="", sameFNAME="", sameYEAR="", sameBLOCK="";
        public bool canEditId = true;
       
        //---------------------------------------------------------//

         void databaseConnection()
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

        private void selectedRowValue(string id)
        {
            
            string query = "SELECT id_no, lname, fname, block, year FROM student_tbl WHERE id_no='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                id_TB.Text = rd[0].ToString();
                lname_TB.Text = rd[1].ToString();
                fname_TB.Text = rd[2].ToString();
                block_CB.Text = rd[3].ToString();
                year_CB.Text = rd[4].ToString();
            }
            rd.Close();
            if (!canEditId)
            {
                generate.Text = "Edit";
                id_TB.ForeColor = Color.Orange;
                id_TB.ReadOnly = true;
                id_TB.Text = sameID;
                generate.ForeColor = Color.White;
                generate.BackColor = Color.Firebrick;
            }
        }


        private void verifyInputs(string id, string block, string year, string lname, string fname)
        {
            try
            {

                fname = organizeName(fname);
                lname = organizeName(lname);
                if (!isNameOrganized(lname, fname))
                {
                    DialogResult res = MessageBox.Show("Invalid name!", "Warning!");

                }
                else if (!isValidID(id))
                {
                    DialogResult res = MessageBox.Show("Invalid ID!", "Warning!");

                }
                else if (!isSameID() && !isDistinctID(id))
                {

                   DialogResult res = MessageBox.Show(id + " is already exist!", "Warning!");


                }
                else if (!isLettersOnly(block = block.ToUpper()))
                {
                    DialogResult res = MessageBox.Show("Invalid Block", "Warning!");

                }
                else if (!isExistingYear(year))
                {
                    DialogResult res = MessageBox.Show("Year level "+ year +" don't exist", "Warning!");
                    year_CB.Text = sameYEAR;
                }
                else if (!isExistingBlock(block))
                {
                    DialogResult res = MessageBox.Show("Block "+ block +" don't exist!", "Warning!");
                    block_CB.Text = sameBLOCK;
                }
                else
                {
                    updateValue(id, block, year, lname, fname);
                }
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Form contains Empty values..", "Warning");
            }
        }

        bool isSameID()
        {

            try
            {

                if (sameID == id_TB.Text) { 
                    id_TB.ForeColor = Color.Orange;
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
        bool isDistinctID(string val)
        {
  
            val = val.ToString();
            val = val.ToUpper();
     
            string query2 = "SELECT id_no FROM student_tbl";
            try
            {

                MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                MySqlDataReader rd2 = cmd2.ExecuteReader();

                while (rd2.Read())
                {
                    if (val.Equals(rd2[0].ToString()))
                    {
                        rd2.Close();
                        return false;
                    }

                }
                rd2.Close();


                return true;

            } catch (Exception e ) {

                MessageBox.Show(e.Message);
                return false;
            }

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

        string organizeName(string val)
        {
            val = val.ToLower();
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            while (val.Contains("  "))
            {
                val = val.Replace("  ", " ");
            }
            val = ti.ToTitleCase(val);
            val = val.Trim();

            return val;
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


        bool isNumber(string val)
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

        void updateValue(string id, string block, string year, string lname, string fname)
        {

            try
            {

                string query = "UPDATE student_tbl"
                                + " SET id_no='" + id + "', lname='" + lname + "', fname='" + fname + "', block='" + block + "', year='" + year + "'"+
                                " WHERE id_no='"+sameID+"'";
                 

                DialogResult result = MessageBox.Show("Update " + id + "\nConfirm action..", "Confirmation", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully..");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update cancel..");
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
                rd[0].ToString().Trim();
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
                rd[0].ToString().Trim();
                year_CB.Items.Add(rd[0].ToString());
            }
            rd.Close();
        }

        //-----------------------------------------------------------//


        public Studentedit()
        {
            InitializeComponent();

        }

        private void Studentedit_Load(object sender, EventArgs e)
        {
            databaseConnection();
            showYears();
            showBlocks();
            selectedRowValue(sameID);


        }

        private void generate_Click(object sender, EventArgs e)
        {
     
            if (canEditId)
            {

                id_TB.Text = generateId();
                canEditId = true;

            }
            else {
               DialogResult rs = MessageBox.Show("Do you want to edit the ID?","Warning!", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.Abort)
                {
                    canEditId = false;
                }
                else if (rs == DialogResult.OK)
                {
                    canEditId = true;
                    generate.Text = "Generate";
                    generate.BackColor = Color.DarkSlateGray;
                    generate.ForeColor = Color.White;
                    clear.Enabled = true;
                    clear.BackColor = Color.Firebrick;
                    clear.ForeColor = Color.White;
                    id_TB.ReadOnly = false;
                }
                else
                {
                    canEditId = false;
                }

            }
           

        }

        private void id_TB_TextChanged(object sender, EventArgs e)
        {
            
            if (canEditId)
            {
                if (isSameID())
                {
                    id_TB.ForeColor = Color.Orange;
                }
                else if (!isDistinctID(id_TB.Text))
                {
                    id_TB.ForeColor = Color.Red;
                }
                else
                {
                    id_TB.ForeColor = Color.Green;
                }
            }

        }

        private void year_CB_TextChanged(object sender, EventArgs e)
        {
         
            if (!isNumber(year_CB.Text))
            {
                year_CB.Text = "--Year--";
            }
           
        }

        private void block_CB_TextChanged(object sender, EventArgs e)
        {
            block_CB.Text = block_CB.Text.ToUpper()[block_CB.Text.Length-1].ToString();
        }

        private void year_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            verifyInputs(id_TB.Text, block_CB.Text, year_CB.Text, lname_TB.Text, fname_TB.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            id_TB.Text = "";
            lname_TB.Text = "";
            fname_TB.Text = "";
            block_CB.Text = "--Block--";
            year_CB.Text = "--Year--";
        }

        private void id_TB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {
            id_TB.Text = sameID;
            lname_TB.Text = sameLNAME;
            fname_TB.Text = sameFNAME;
            block_CB.Text = sameBLOCK;
            year_CB.Text = sameYEAR;
        }
    }
}
