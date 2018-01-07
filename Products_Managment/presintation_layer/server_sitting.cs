using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.presintation_layer
{
    public partial class server_sitting : Form
    {
        public server_sitting()
        {
       
           
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.servername = servername.Text;
            Properties.Settings.Default.database = databasename.Text;
            Properties.Settings.Default.name = name.Text;
            Properties.Settings.Default.password = password.Text;
            Properties.Settings.Default.user_name = user_name.Text;
            Properties.Settings.Default.if_first_time = true;
            Properties.Settings.Default.mode = sql.Checked==true? sql.Text:sql_authontication.Text;
            Properties.Settings.Default.Save();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void server_sitting_Load(object sender, EventArgs e)
        {
            servername.Text = Properties.Settings.Default.servername;
            databasename.Text = Properties.Settings.Default.database;
            name.Text = Properties.Settings.Default.name;
            password.Text = Properties.Settings.Default.password;

            user_name.Text= Properties.Settings.Default.user_name ;

            if (Properties.Settings.Default.mode == "sql")
            {
                sql.Checked = true;
                name.Enabled = false;
                password.Enabled = false;
            }
            else
            {

                sql_authontication.Checked = true;
                name.Enabled = true;
                password.Enabled = true;
                name.Text = Properties.Settings.Default.name;
                password.Text = Properties.Settings.Default.password;
            }
        }

        private void sql_authontication_CheckedChanged(object sender, EventArgs e)
        {
            name.Enabled = true;
            password.Enabled = true;
            name.Text = Properties.Settings.Default.name;
            password.Text = Properties.Settings.Default.password;
        }

        private void sql_CheckedChanged(object sender, EventArgs e)
        {
            name.Enabled = false;
            password.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
