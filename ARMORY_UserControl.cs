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
    public partial class ARMORY_UserControl : UserControl
    {
        private static ARMORY_UserControl _instance;

        public static ARMORY_UserControl Instance
        {
            get 
            {
                if(_instance == null)
                {
                    _instance = new ARMORY_UserControl();
                }
                return _instance;
            }
        }
        public ARMORY_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        private void g_code_ARMORY_Click(object sender, EventArgs e)
        {

        }

        private void GUN_ID_TAKE_ARMORY_Click(object sender, EventArgs e)
        {

        }




        //function for data grid view select all from armory REFRESH
        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("showallarmorydata",con);
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






        //add a new value in ARMORY
        private void ADD_ARMORY_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("armoryadd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@G_code", GUN_CODE_TAKE_textBox.Text);
            cmd.Parameters.AddWithValue("@Name", NAME_TAKE_textBox.Text);
            cmd.Parameters.AddWithValue("@PRC_ID", PRECINCT_ID_TAKE_textBox.Text);

            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("             <<<<<<Invalid Sql OPERATION>>>>>:   \n" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }






        private void ARMORY_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }





        //DELETE FROM ARMORY

        private void DELETE_ARMORY_button_Click(object sender, EventArgs e)
        {try
            {
                SqlCommand cmd = new SqlCommand("deletearmory_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@G_code", GUN_CODE_TAKE_textBox.Text);
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
        catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }






        

        //SEARCH FROM ARMORY USING G_CODE

        private void search_gun_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("armorysearch_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@G_code", GUN_CODE_SEARCH_TEXTBOX.Text);
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





        //CLEAN #FRESH #NEW #CLEAN #BRUNO MARS

        private void CLEAR_TEXT_BOX_button_Click(object sender, EventArgs e)
        {
            GUN_CODE_SEARCH_TEXTBOX.Text = "";
            GUN_CODE_TAKE_textBox.Text = "";
            NAME_TAKE_textBox.Text = "";
            PRECINCT_ID_TAKE_textBox.Text = "";
        }






        //UPDATE TO NEW VALUES
        private void UPDATE_ARMORY_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("armory_UPDATE_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@G_code", GUN_CODE_TAKE_textBox.Text);
            cmd.Parameters.AddWithValue("@Name", NAME_TAKE_textBox.Text);
            cmd.Parameters.AddWithValue("@PRC_ID", PRECINCT_ID_TAKE_textBox.Text);

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
