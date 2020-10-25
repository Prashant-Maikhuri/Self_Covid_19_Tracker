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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Symptom_Info_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            cmd.Parameters.AddWithValue("@Phone_Number", i);
            cmd.Parameters.AddWithValue("@Date_of_Symptoms",dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Cough", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@Cold", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@Headache", comboBox3.SelectedItem);
            cmd.Parameters.AddWithValue("@Fever", comboBox4.SelectedItem);
            cmd.Parameters.AddWithValue("@Short_Breathness", comboBox5.SelectedItem);
            cmd.Parameters.AddWithValue("@Fatigue", comboBox6.SelectedItem);
            cmd.Parameters.AddWithValue("@Sore_Throat", comboBox7.SelectedItem);
            cmd.Parameters.AddWithValue("@Vomiting", comboBox8.SelectedItem);
            cmd.Parameters.AddWithValue("@Diarrhea", comboBox9.SelectedItem);
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Update_Symptom_Phone_No_SP", con);
            cmd1.CommandType = CommandType.StoredProcedure; 
            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Success");
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falied" + ex);
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form5 obj = new Form5();
            this.Hide();
            obj.Show();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (flag==1)
            {
                // this is for the normal result table
                con.Open();
                SqlCommand cmd = new SqlCommand("Result_Start_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string s;
                s = "Null";
                int p;
                p = 0;
                cmd.Parameters.AddWithValue("@Re_Status", s);
                cmd.Parameters.AddWithValue("@Date_of_Result", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@No_of_Days_for_Recovery", p);
                con.Close();

                //updating the result in the result info table
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Update_Result_Info_SP", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                con.Close();

               
                
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    Form4 obj = new Form4();
                    this.Hide();
                    obj.Show();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falied" + ex);
                }
                con.Close();

            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
