using Products_Managment.DATA;
using Products_Managment.DATA_BASE_LAYER;
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

   
    public partial class LOGIN : Form
    {
        Main_Form main_form;
        public LOGIN():this(null)
        {
            InitializeComponent();
        }
        public LOGIN(Main_Form _main)
        {
            main_form = _main;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Users> user_list = new List<Users>();
            DataTable table = DBL.get_DATA("Select_Users");
            foreach(DataRow item in table.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(),Convert.ToInt16( item["ID_User"]), item["type"].ToString()));
            }
            foreach(var item in user_list)
            {
                if(item.Name== textBox1.Text&&item.Password==textBox2.Text)
                {
                    Users user = new Users(item.Name,null, item.Id,item.Type);
                   
                    
                    main_form.User_name = user;
                    Program.main_form.Show();
                    Program.main_form.انشاءنسخةاحتياطيةToolStripMenuItem1.Enabled = true;
                    Program.main_form.استعادةنسخةمحفوظةToolStripMenuItem1.Enabled = true;

                    Program.main_form.العملاءToolStripMenuItem1.Enabled = true;

                    Program.main_form.المستخدمونToolStripMenuItem1.Enabled = true;

                    Program.main_form.المنتجاتToolStripMenuItem1.Enabled = true;

                    this.Close();
                   
                   

                }


            }

        }
    }
}
