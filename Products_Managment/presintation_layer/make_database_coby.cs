using Products_Managment.DATA_BASE_LAYER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.presintation_layer
{
    public partial class restor_database_coby : Form
    {
        public restor_database_coby()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text+ @"\product_DB" + DateTime.Now.ToShortDateString() +
               "_"+ DateTime.Now.ToLongTimeString();
            string query = "Make_database_backup"  ;
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("file_name", filename + ".bak"));
         
            DBL.execute_query(query, parameters);
            MessageBox.Show("تم عمل نسخة احتياطية");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
