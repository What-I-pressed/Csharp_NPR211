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
using Microsoft.Extensions.Configuration;

namespace WinFormsApp1.Options
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appSetting.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            TxtServerHost.Text = configuration.GetConnectionString("host");
            txtUserName.Text = configuration.GetConnectionString("user");
            txtUserPassword.Text = configuration.GetConnectionString("password");
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SavingButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = TxtServerHost.Text;
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;
            string conStr = $"Data Source={host};User ID={name};Password={password};MultipleActiveResultSets=true;";
            try
            {
                var con = new SqlConnection(conStr);
                con.Open();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured " + ex.Message);
            }
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtServerHost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
