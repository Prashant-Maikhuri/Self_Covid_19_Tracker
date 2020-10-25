using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace begin
{
    public partial class Country_Cases_UserControl1 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Country_Cases_UserControl1()
        {
            InitializeComponent();
        }
        private static Country_Cases_UserControl1 _instance;
        public static Country_Cases_UserControl1 _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Country_Cases_UserControl1();
                }
                return _instance;
            }
        }

        private void Country_Cases_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string syntax = "SELECT Count(Re_Status) from result_info where Re_Status = 'Positive' ";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            int no;
            no = dr.GetInt32(0);
            label1.Text = no.ToString();
            solidGauge1.Value = no;
        }
    }
}
