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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\Database1.mdf;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Add_Person_Info_SP",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            int i;
            i= int.Parse(textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", i);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@State", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@Email_Id", textBox3.Text);
            int j;
            j = int.Parse(textBox4.Text);
            cmd.Parameters.AddWithValue("@Phone_No", j);
            cmd.Parameters.AddWithValue("@Password", textBox5.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falied" + ex);
            }
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    Form6 obj = new Form6();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
