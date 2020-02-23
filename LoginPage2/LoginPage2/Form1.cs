using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.OleDb;

namespace LoginPage2
{
    public partial class Form1 : Form
    {
        public object ConfigurationManager { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        public string  conStr="Data Source=LAPTOP-APSNT4R9\\ADMIN;Initial Catalog=LoginPage;Integrated Security=True";
        
        private void button1_Click(object sender, EventArgs e)
        {

            string a1 = textBox1.Text;
            string a2 = textBox2.Text;
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string que = "insert into login(id, pass) values ('"+a1+"','"+a2+"')";
                SqlCommand cmd = new SqlCommand(que,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Establish");
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
       

}
