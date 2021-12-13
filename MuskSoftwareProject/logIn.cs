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

namespace Muck
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           SqlConnection cn;
              cn = new SqlConnection(Properties.Settings.Default.Datab);
            cn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cn = new SqlConnection(Properties.Settings.Default.Datab);
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {
                
                cn.Open();
                var cmd = new SqlCommand("select * from LoginTable where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", cn);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GoToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registration = new register();
            registration.ShowDialog();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
