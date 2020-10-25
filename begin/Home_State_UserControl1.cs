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
    public partial class Home_State_UserControl1 : UserControl
    {
        public Home_State_UserControl1()
        {
            InitializeComponent();
        }

        private void Home_State_UserControl1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private static Home_State_UserControl1 _instance;
        public static Home_State_UserControl1 _Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Home_State_UserControl1();
                }
                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pt_id;
            pt_id = textBox1.Text;
            int i;
            i = int.Parse(pt_id);
            con.Open();
            string syntax = "SELECT State from person_info where Pt_id = @Pt_id";
            cmd = new SqlCommand(syntax, con);
            cmd.Parameters.AddWithValue("@Pt_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            label1.Text = dr.GetValue(0).ToString();
            string y;
            y = dr.GetValue(0).ToString();
            con.Close();

            
            con.Open();
            string syntax1 = "select COUNT(result_info.Re_id) from result_info ,person_info where person_info.Pt_id = result_info.Re_id AND result_info.Re_Status = 'Positive' AND person_info.State = @State";
            SqlCommand cmd1;
            SqlDataReader dr1;
            cmd1 = new SqlCommand(syntax1, con);
            cmd1.Parameters.AddWithValue("@State", y);
            dr1 = cmd1.ExecuteReader();
            dr1.Read();
            int no = dr1.GetInt32(0);
            solidGauge1.Value = no;
            label4.Text = no.ToString();

        }

    }
}
