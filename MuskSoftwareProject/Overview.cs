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

namespace MuskSoftwareApplication
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tee\Documents\SiteInspectionDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Overview_Load(object sender, EventArgs e)
        {
         
        }
    }
}
