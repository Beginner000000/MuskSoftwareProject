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
using MuskSoftwareApplication;

namespace MuskSoftwareProject
{
    public partial class ReportPage : Form
    {
        private string connectionString;

        public ReportPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.ShowDialog();
            this.Hide();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\jabed\OneDrive\Documents\University\Software Engineering\MuskSoftwareProject - master\MuskSoftwareProject\DB1.mdf";Integrated Security=True";
            SqlConnection conn;
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.DB1);
            connectionString = sqlConnection;
            conn = new SqlConnection(connectionString);
            conn.Open();

            conn.Close();
        }
    }
}
