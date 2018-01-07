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
    public partial class restor_database : Form
    {
        public restor_database()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

         string   connection_string = "Data Source=MOHAMED-PC;Initial Catalog=product_DB;Integrated Security=True;";
            string filename = textBox1.Text;

            SqlConnection con = new SqlConnection(connection_string);
            SqlCommand com = new SqlCommand("ALTER database product_DB set offline with rollback immediate ;restore database product_DB from Disk ='"+ filename+"'"+ "WITH REPLACE", con);
           

      
            con.Open();

            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("استعادةالنسخنةاحتياطية");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
