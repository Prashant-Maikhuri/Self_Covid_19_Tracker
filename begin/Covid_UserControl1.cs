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
    public partial class Covid_UserControl1 : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;


        private static Covid_UserControl1 _instance;
        public static Covid_UserControl1 _Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Covid_UserControl1();
                }
                return _instance;
            }
        }
       
        public Covid_UserControl1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Covid_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pt_id;
            pt_id = textBox1.Text;
            int i;
            i = int.Parse(pt_id);
            con.Open();
            string syntax = "SELECT Name,Age,Gender,State,Email_Id,Phone_No from person_info where Pt_id = @Pt_id";
            cmd = new SqlCommand(syntax, con);
            cmd.Parameters.AddWithValue("@Pt_id", i);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                label1.Text = dr.GetValue(0).ToString();
                label2.Text = dr.GetInt32(1).ToString();
                label4.Text = dr.GetValue(2).ToString();
                label6.Text = dr.GetValue(3).ToString();
                label8.Text = dr.GetValue(4).ToString();
                label10.Text = dr.GetInt32(5).ToString();
            }
            con.Close();


        }
    }
}

