using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace begin
{
    public partial class developer_UserControl1 : UserControl
    {
        public developer_UserControl1()
        {
            InitializeComponent();
        }

        private void developer_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private static developer_UserControl1 _instance;
        public static developer_UserControl1 _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new developer_UserControl1();
                }
                return _instance;
            }
        }
    }
}
