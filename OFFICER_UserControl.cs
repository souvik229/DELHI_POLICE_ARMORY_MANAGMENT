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
    public partial class OFFICER_UserControl : UserControl
    {
        private static OFFICER_UserControl _instance;

        public static OFFICER_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OFFICER_UserControl();
                }
                return _instance;
            }
        }
        public OFFICER_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        //function for data grid view select all from armory REFRESH
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showallOFFICERdata", con);
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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void OFFICER_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }




        //ADD A NEW TUPPEL IN OFFICER
        private void ADD_ARMORY_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("OFFICERadd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DP_ID", DP_ID_TAKETEXTBOX.Text);
            cmd.Parameters.AddWithValue("@PRC_ID", PRECINCT_ID_TAKE_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Name", NAME_TAKE_DP_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Batch", BATCH_TAKE_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Phone", PHONE_TAKE_TEXTBOX.Text);

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
            refresh_DataGridView();
        }








        //DELETE FROM OFFICER
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteOFFICER_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DP_ID", DP_ID_TAKETEXTBOX.Text);
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
                refresh_DataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }









        //SEARCH WITH DP_ID
        private void search_gun_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("OFFICERsearch_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DP_ID", DP_SEARCH_TEXTBOX.Text);
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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }









        //CLEAR //CLEAN  #PURE #24K GOLD
        private void button3_Click(object sender, EventArgs e)
        {
            DP_SEARCH_TEXTBOX.Text = "";
            DP_ID_TAKETEXTBOX.Text = "";
            PRECINCT_ID_TAKE_TEXTBOX.Text = "";
            NAME_TAKE_DP_TEXTBOX.Text = "";
            BATCH_TAKE_TEXTBOX.Text = "";
            PHONE_TAKE_TEXTBOX.Text = "";
        }







        //UPDATE TO NEW VALUES
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("OFFICER_UPDATE_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DP_ID", DP_ID_TAKETEXTBOX.Text);
            cmd.Parameters.AddWithValue("@PRC_ID", PRECINCT_ID_TAKE_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Name", NAME_TAKE_DP_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Batch", BATCH_TAKE_TEXTBOX.Text);
            cmd.Parameters.AddWithValue("@Phone", PHONE_TAKE_TEXTBOX.Text);

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
            refresh_DataGridView();
        }
    }
}
