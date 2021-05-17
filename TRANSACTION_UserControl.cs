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
    public partial class TRANSACTION_UserControl : UserControl
    {
        private static TRANSACTION_UserControl _instance;

        public static TRANSACTION_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TRANSACTION_UserControl();
                }
                return _instance;
            }
        }
        public TRANSACTION_UserControl()
        {
            InitializeComponent();
        }

        public string g_code_issued, officer_issued_to ;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;


        
        //search whether OFFICER has firearm
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string syntax = "SELECT Gun_Assigned FROM OFFICER where DP_ID='" + take_officer_id.Text + "'";
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                gun_issued.Text = g_code_issued = dr[0].ToString();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }



        //search whether FIREARM is issued to an officer
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string syntax = "SELECT Assigned_to FROM ARMORY where G_code='" + take_g_code.Text + "'";
                cmd = new SqlCommand(syntax, con);
                dr = cmd.ExecuteReader();
                dr.Read();
                issued_to_officer.Text = officer_issued_to = dr[0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }








        //***********issueing of FIREARM to OFFICER
        private void issue_button_Click(object sender, EventArgs e)
        {
            //check if Firearm is issued to an OFFICER
            button2.PerformClick();
            if(officer_issued_to!="")
            {
                //some one is already issued the firearm
                MessageBox.Show("FIREARM already issued to OFFICER ID-\n" + officer_issued_to);
                return;
            }


            //check if OFFICER already has Firearm
            button1.PerformClick();
            if(g_code_issued != "")
            {
                //OFFICER HAS FIREARM issued to him
                MessageBox.Show("OFFICER already issued a firearm ID-\n" + gun_issued);
                return;
            }



            //IF U HAVE REACHED HERE U R CLEAR NO ONE IS ISSUED THE FIREARM AND THE OFFICER DOESENT HAS A FIREARM
            //*************SO LETS GIVE THIS MAN A GUN*********************//
            try
            {
                //its a simple first update the assigned_to column on ARMORY with whats in the text box
                //gonna make a stored procedure
                SqlCommand cmd = new SqlCommand("transaction_update_in_ARMORY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@G_code", take_g_code.Text);
                cmd.Parameters.AddWithValue("@Assigned_to", take_officer_id.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();


                //now update Gun_Assigned column in OFFICER table
                //making a stored procedure again

                cmd = new SqlCommand("transaction_update_in_OFFICER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DP_ID", take_officer_id.Text);
                cmd.Parameters.AddWithValue("@Gun_Assigned", take_g_code.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();




                //inserting values in transaction table
                cmd = new SqlCommand("Transaction_table_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Assigned_to", take_officer_id.Text);
                cmd.Parameters.AddWithValue("@G_ID", take_g_code.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();


                //ICING ON THE CAKE
                button1.PerformClick();
                button2.PerformClick();
                MessageBox.Show("SUCESSFULLY ISSUED");
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }






        //********RETURNING OF FIREARM
        private void return_button_Click(object sender, EventArgs e)
        {
            //check if Firearm is issued to an OFFICER
            button2.PerformClick();
            button1.PerformClick();
            if (take_g_code.Text != gun_issued.Text)
            {
                //THE firearm isnt issued
                MessageBox.Show("FIREARM Isn't ISSUED");
                return;
            }




            //IF U HAVE REACHED HERE U R CLEAR that THE FIREARM IS ISSUED TO OFFICER
            //*************SO LETS TAKE IT BACK*********************//
            try
            {
                //its a simple first update the assigned_to column on ARMORY with null
                //gonna make a stored procedure
                SqlCommand cmd = new SqlCommand("transaction_update_in_ARMORY", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@G_code", take_g_code.Text);
                cmd.Parameters.AddWithValue("@Assigned_to", (object)DBNull.Value);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();


                //now update Gun_Assigned column in OFFICER table to NULL
                //making a stored procedure again

                cmd = new SqlCommand("transaction_update_in_OFFICER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DP_ID", take_officer_id.Text);
                cmd.Parameters.AddWithValue("@Gun_Assigned", (object)DBNull.Value);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();

                // deleting from transaction
                cmd = new SqlCommand("Transaction_table_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Assigned_to", take_officer_id.Text);
                cmd.Parameters.AddWithValue("@G_ID", take_g_code.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();

                //ICING ON THE CAKE
                button1.PerformClick();
                button2.PerformClick();
                MessageBox.Show("SUCESSFULLY RETURNED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }






        //clear#CLEAN#FRESH
        private void CLEAR_BUTTON_Click(object sender, EventArgs e)
        {
            gun_issued.Text = "";
            issued_to_officer.Text = "";
            take_g_code.Text = "";
            take_officer_id.Text = "";
        }

        private void showlog_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("show_LOG_DATA", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void TRANSACTION_UserControl_Load(object sender, EventArgs e)
        {
            gun_issued.Text = "";
            issued_to_officer.Text = "";
        }
    }
}
