using Products_Managment.DATA;
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
    public partial class users_managmet : Form
    {
        int count;
        int count_all = 0;
        BindingManagerBase bmb;
        public users_managmet()
        {
            InitializeComponent();
        }

        private void users_managmet_Load(object sender, EventArgs e)
        {
            Users user = new Users();
            List<Users> users = new List<Users>();

            users.Add(new Users { Type = "admin" });
            users.Add(new Users { Type = "user" });
            type.DataSource = users;
            type.ValueMember = "Type";
            type.DisplayMember = "Type";

            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"]), item["type"].ToString()));
            }

            DataTable table = new DataTable();

            table.Columns.Add("المعرف");
            table.Columns.Add("الاسم");
            table.Columns.Add("الباسورد");
            table.Columns.Add("النوع");
            foreach (var item in user_list)
            {
                table.Rows.Add(item.Id, item.Name, item.Password, item.Type);

                count_all++;
            }

                dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            dataGridView1.Columns[0].Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            Users user = new Users();

            user.Name = name.Text.ToString();
            user.Password = password.Text.ToString();
            user.Type = type.SelectedValue.ToString();


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("Name", user.Name));
            parameters.Add(new SqlParameter("Password", user.Password));
            parameters.Add(new SqlParameter("type", user.Type));
            DBL.execute_query("user_insert", parameters);




            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"]), item["type"].ToString()));
            }

            DataTable table = new DataTable();

            table.Columns.Add("المعرف");
            table.Columns.Add("الاسم");
            table.Columns.Add("الباسورد");
            table.Columns.Add("النوع");
            foreach (var item in user_list)
            {
                table.Rows.Add(item.Id, item.Name, item.Password, item.Type);

                count_all++;
            }

            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            dataGridView1.Columns[0].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users user = new Users();
          

            user.Id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);

            user.Name = name.Text.ToString();
            user.Password = password.Text.ToString();
            user.Type = type.SelectedValue.ToString();

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_User", user.Id));
            parameters.Add(new SqlParameter("Name", user.Name));
            parameters.Add(new SqlParameter("Password", user.Password));
            parameters.Add(new SqlParameter("type", user.Type));
            DBL.execute_query("user_update", parameters);


            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"]), item["type"].ToString()));
            }

            DataTable table = new DataTable();

            table.Columns.Add("المعرف");
            table.Columns.Add("الاسم");
            table.Columns.Add("الباسورد");
            table.Columns.Add("النوع");
            foreach (var item in user_list)
            {
                table.Rows.Add(item.Id, item.Name, item.Password, item.Type);

                count_all++;
            }

            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            dataGridView1.Columns[0].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Users user = new Users();

            user.Id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value);
      


            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_User", user.Id));
       
            DBL.execute_query("user_delete", parameters);





            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"]), item["type"].ToString()));
            }

            DataTable table = new DataTable();

            table.Columns.Add("المعرف");
            table.Columns.Add("الاسم");
            table.Columns.Add("الباسورد");
            table.Columns.Add("النوع");
            foreach (var item in user_list)
            {
                table.Rows.Add(item.Id, item.Name, item.Password, item.Type);

                count_all++;
            }

            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                type.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
