using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
namespace Admin
{
    public partial class Subjectadd : Form

    {

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        String sql = "";

        public Subjectadd()
        {
            InitializeComponent();
        }
        private void Subjectadd_Load(object sender, EventArgs e)
        {
            isConnectedtodababase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
          
            String name = sub_name.Text, des= sub_desc.Text, unit = sub_unit.Text;
            
            cmd = new MySqlCommand("insert into subject_tbl values (' ', '"+ name + "', '"+ des +"', '" + unit + "')", conn);
            cmd.ExecuteNonQuery();
            
            

        }

        private void clear_Click(object sender, EventArgs e)
        {
 
            sub_unit.Text = "";
            sub_name.Text = "";
            sub_desc.Text = "";
        }


        //---------------------
        void isConnectedtodababase()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "server=localhost;uid=root;pwd=;database=cruddatabase";
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant connect to the database");
                this.Dispose();
            }
        }

  
    }
}
