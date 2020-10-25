using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace begin
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if(! panel2.Controls.Contains(Covid_UserControl1._Instance))
            {
             panel2.Controls.Add(Covid_UserControl1._Instance);
             Covid_UserControl1._Instance.Dock = DockStyle.Fill;
             Covid_UserControl1._Instance.BringToFront();
            }
            else
            {
               Covid_UserControl1._Instance.BringToFront();
            }
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (! panel2.Controls.Contains(ResultDisplay_UserControl1._Instance))
            {
                panel2.Controls.Add(ResultDisplay_UserControl1._Instance);
                ResultDisplay_UserControl1._Instance.Dock = DockStyle.Fill;
                ResultDisplay_UserControl1._Instance.BringToFront();
            }
            else
            {
                ResultDisplay_UserControl1._Instance.BringToFront();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Home_State_UserControl1._Instance))
            {
                panel2.Controls.Add(Home_State_UserControl1._Instance);
                Home_State_UserControl1._Instance.Dock = DockStyle.Fill;
                Home_State_UserControl1._Instance.BringToFront();
            }
            else
            {
                Home_State_UserControl1._Instance.BringToFront();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!panel2.Controls.Contains(Country_Cases_UserControl1._Instance))
            {
                panel2.Controls.Add(Country_Cases_UserControl1._Instance);
                Country_Cases_UserControl1._Instance.Dock = DockStyle.Fill;
                Country_Cases_UserControl1._Instance.BringToFront();
            }
            else
            {
                Country_Cases_UserControl1._Instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!panel2.Controls.Contains(developer_UserControl1._Instance))
            {
                panel2.Controls.Add(developer_UserControl1._Instance);
                developer_UserControl1._Instance.Dock = DockStyle.Fill;
                developer_UserControl1._Instance.BringToFront();
            }
            else
            {
                developer_UserControl1._Instance.BringToFront();
            }

        }
    }
}
