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

namespace begin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        

        // getting the username
        private int getPt_id()
        {
            // fetch the data from the database
            con.Open();
            String syntax = "SELECT Pt_id FROM person_info where Pt_id=@Pt_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            cmd.Parameters.AddWithValue("@Pt_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            int temp = dr.GetInt32(0);
            con.Close();
            return temp;
        }

        //getting the password
        private string getPassword()
        {
            //fetch the data from the database
            con.Open();
            string syntax = "SELECT Password from person_info where Pt_id = @Pt_id";
            cmd = new SqlCommand(syntax, con);
            int i;
            i = int.Parse(textBox1.Text);
            cmd.Parameters.AddWithValue("@Pt_id", i);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr.GetValue(0).ToString();
            con.Close();
            return temp;

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            int Pt_id,  dr_Pt_id;
            string dr_Password , Password;
            dr_Pt_id = getPt_id();
            dr_Password = getPassword();
            Pt_id = int.Parse(textBox1.Text);
            Password = textBox2.Text;
            SqlCommand cmd1 = new SqlCommand("Update_No_of_Days_for_Recovery_SP", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Result_id", dr_Pt_id);
            if ( (dr_Pt_id == Pt_id) && (dr_Password == Password))
            {
                SqlCommand cmd2 = new SqlCommand("Update_Result_Status_after_Recovery_SP", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Re_id", dr_Pt_id);
                con.Open();
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    Form7 obj1 = new Form7();
                    this.Hide();
                    obj1.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falied" + ex);
                }
                con.Close();


            }

            else
            {
                MessageBox.Show("Invalid LOGIN!!!");
            }   


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
