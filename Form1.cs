using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "hospital")
            {
                if(txtPass.Text == "userone")
                {
                    new MHRS().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error! Please enter the correct information");
                }
            }
            else
            {
                MessageBox.Show("Error! Please enter the correct information");

            }

        }
    }
}
