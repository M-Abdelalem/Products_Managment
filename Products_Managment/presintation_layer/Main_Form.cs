using Products_Managment.DATA;
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
    public partial class Main_Form : Form
    {

        Users user_name;


        public ToolStripMenuItem انشاءنسخةاحتياطيةToolStripMenuItem1
        {
            get
            {
                return انشاءنسخةاحتياطيةToolStripMenuItem;
            }

            set
            {
                انشاءنسخةاحتياطيةToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem استعادةنسخةمحفوظةToolStripMenuItem1
        {
            get
            {
                return استعادةنسخةمحفوظةToolStripMenuItem;
            }

            set
            {
                استعادةنسخةمحفوظةToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem المنتجاتToolStripMenuItem1
        {
            get
            {
                return المنتجاتToolStripMenuItem;
            }

            set
            {
                المنتجاتToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem العملاءToolStripMenuItem1
        {
            get
            {
                return العملاءToolStripMenuItem;
            }

            set
            {
                العملاءToolStripMenuItem = value;
            }
        }

        public ToolStripMenuItem المستخدمونToolStripMenuItem1
        {
            get
            {
                return المستخدمونToolStripMenuItem;
            }

            set
            {
                المستخدمونToolStripMenuItem = value;
            }
        }

        internal Users User_name
        {
            get
            {
                return user_name;
            }

            set
            {
                user_name = value;
            }
        }

        public Main_Form()
        {
            InitializeComponent();
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           if(Properties.Settings.Default.if_first_time ==true)
            {
                try
                {
                    string connection_string = @"Data Source=" + Properties.Settings.Default.servername + ";Integrated Security=True;";

                    string commend = @"CREATE DATABASE product_DB   
    ON(FILENAME = '" + Properties.Settings.Default.user_name + @"\product_DB.mdf'),  
    (FILENAME =  '" + Properties.Settings.Default.user_name + @"\product_DB_log.ldf')
    FOR ATTACH;";

                    SqlConnection con = new SqlConnection(connection_string);

                    SqlCommand com = new SqlCommand(commend, con);



                    con.Open();

                    com.ExecuteNonQuery();
                    con.Close();
                    Properties.Settings.Default.if_first_time = false;
                    Properties.Settings.Default.Save();
                }
                catch { }
            }


        }
        

        private void تسجيلدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN(this);
            login.ShowDialog();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.main_form.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = false;
            Program.main_form.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = false;

            Program.main_form.العملاءToolStripMenuItem1.Enabled = false;

            Program.main_form.المستخدمونToolStripMenuItem1.Enabled = false;

            Program.main_form.المنتجاتToolStripMenuItem1.Enabled = false;
        }

        private void اضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ADD_Product add_Product = new Form_ADD_Product();
            add_Product.ShowDialog();
        }

        private void ادارةمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Products products = new Form_Products();
            products.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Category category_form = new Form_Category();
            category_form.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Customer form = new Form_Customer();
            form.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form_orders form = new Form_orders(User_name);
            form.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restor_database_coby coby = new restor_database_coby();

            coby.Show();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restor_database restor = new restor_database();

            restor.Show();
        }

        private void اعداداتالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            server_sitting sitting = new server_sitting();

            sitting.ShowDialog();

        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show_orders show = new show_orders();
            show.Show();
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_name.Type == "admin     ")
            {
                users_managmet form = new users_managmet();
                form.ShowDialog();
            }
        }
    }
}
