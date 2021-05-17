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
    public partial class SETTING_UserControl : UserControl
    {
        private static SETTING_UserControl _instance;

        public static SETTING_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SETTING_UserControl();
                }
                return _instance;
            }
        }
        public SETTING_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");




        //CHANGE USRENAME
        private void CHANGE_USERNAME_BUTTON_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("UPDATE_SYSTEM_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@property", "UserName");
            cmd.Parameters.AddWithValue("@value", USERNAME_IN_textbox.Text);
           
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("SYSTEM USERNAME CHANGED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
            }
            con.Close();
            USERNAME_IN_textbox.Text = "";
        }





        //CHANGE PASSWORD
        private void CHANGE_PASSWORD_BUTTON_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE_SYSTEM_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@property", "Password");
            cmd.Parameters.AddWithValue("@value", PASSWORD_IN_textbox.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("SYSTEM PASSWORD CHANGED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
            }
            con.Close();
            PASSWORD_IN_textbox.Text = "";
        }

        private void SETTING_UserControl_Load(object sender, EventArgs e)
        {
            USERNAME_IN_textbox.Text = "";
            PASSWORD_IN_textbox.Text = "";
        }
    }
}
