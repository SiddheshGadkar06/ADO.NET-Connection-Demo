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

namespace adopractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Connect()
        {
            try
            {
                string co = "server=localhost; uid=root; pwd=SIDDHESH; Initial Catalog = sid; Integrated Security = SSPI";
                MySqlConnection conn = new MySqlConnection(co);
                conn.Open();
                string sql = "SELECT * FROM school";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Name " + reader["name"] + ", his roll no is " + reader["id"]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
        }


    }
}
