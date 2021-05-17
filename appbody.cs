using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DELHI_POLICE
{
    public partial class appbody : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public appbody()
        {
            InitializeComponent();
        }

        private void closeappbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeappbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logoffappbutton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void titlebarapp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(! controlpanel.Controls.Contains(ARMORY_UserControl.Instance))
            {
                controlpanel.Controls.Add(ARMORY_UserControl.Instance);
                ARMORY_UserControl.Instance.Dock = DockStyle.Fill;
                ARMORY_UserControl.Instance.BringToFront();
            }
            else
            {
                ARMORY_UserControl.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(OFFICER_UserControl.Instance))
            {
                controlpanel.Controls.Add(OFFICER_UserControl.Instance);
                OFFICER_UserControl.Instance.Dock = DockStyle.Fill;
                OFFICER_UserControl.Instance.BringToFront();
            }
            else
            {
                OFFICER_UserControl.Instance.BringToFront();
            }
        }

        

        private void transaction_button_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(TRANSACTION_UserControl.Instance))
            {
                controlpanel.Controls.Add(TRANSACTION_UserControl.Instance);
                TRANSACTION_UserControl.Instance.Dock = DockStyle.Fill;
                TRANSACTION_UserControl.Instance.BringToFront();
            }
            else
            {
                TRANSACTION_UserControl.Instance.BringToFront();
            }
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(SETTING_UserControl.Instance))
            {
                controlpanel.Controls.Add(SETTING_UserControl.Instance);
                SETTING_UserControl.Instance.Dock = DockStyle.Fill;
                SETTING_UserControl.Instance.BringToFront();
            }
            else
            {
                SETTING_UserControl.Instance.BringToFront();
            }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            if (!controlpanel.Controls.Contains(ABOUT_UserControl.Instance))
            {
                controlpanel.Controls.Add(ABOUT_UserControl.Instance);
                ABOUT_UserControl.Instance.Dock = DockStyle.Fill;
                ABOUT_UserControl.Instance.BringToFront();
            }
            else
            {
                ABOUT_UserControl.Instance.BringToFront();
            }
        }
    }
}
