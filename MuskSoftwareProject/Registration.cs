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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Opening Connection to Database//
        private void register_Load(object sender, EventArgs e)
        {
           var cn = new SqlConnection(Properties.Settings.Default.Datab);
            cn.Open();
        }
        //Button for Returning to log in screen//
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            logIn login = new logIn();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    var cn = new SqlConnection(Properties.Settings.Default.Datab);
                    cn.Open(); 
                    var cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                   var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("This username already exist please use another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable (username , password) values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The account has been created . proceed to login page.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("The passwords are not the same please enter again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
