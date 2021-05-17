using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DELHI_POLICE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

     

        private string getUserName()
        {
            //gets data from database
            con.Open();
            string syntax = "SELECT value FROM systemTable where property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
            
        }

        private string getPassword()
        {
            //gets data from database
            con.Open();
            string syntax = "SELECT value FROM systemTable where property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string uname=getUserName(), upass=getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox3.Text;

            if(name.Equals(uname) && pass.Equals(upass) )
            {
                //login
                label3.Hide();
                appbody obj = new appbody();
                this.Hide();
                obj.Show();
                
            }
            else 
            {
                //dont login
                label3.Show();
            }
        }
    }
}
