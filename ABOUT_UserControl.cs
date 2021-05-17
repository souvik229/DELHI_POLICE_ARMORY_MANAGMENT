using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELHI_POLICE
{
    public partial class ABOUT_UserControl : UserControl
    {
        private static ABOUT_UserControl _instance;

        public static ABOUT_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ABOUT_UserControl();
                }
                return _instance;
            }
        }
        public ABOUT_UserControl()
        {
            InitializeComponent();
        }
    }
}
