using Products_Managment.BLL;
using Products_Managment.DATA;
using Products_Managment.Report_view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Products_Managment.presintation_layer
{
    public partial class Form_Category : Form
    {
        int count;
        int count_ALL_items;

        public Form_Category()
        {
            InitializeComponent();
        }
        BindingManagerBase bmb;

        private void button10_Click(object sender, EventArgs e)
        {
            Categories_DATA category = new Categories_DATA();
            DataGridViewRow selected_row = dataGridView1.SelectedRows[0];
            category.Id = Convert.ToInt16(selected_row.Cells[0].Value.ToString());
            category.Description = selected_row.Cells[2].Value.ToString();
            Form_item_category item = new Form_item_category(category);
            this.Hide();
            item.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            List<Categories_DATA> category = new List<Categories_DATA>();
            category = Categories_BLL.Select_ALL_Categories();

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("number");
            table.Columns.Add("description");
            int number = 1;
            foreach (var item in category)
            {
               
                table.Rows.Add(item.Id, number, item.Description);
                number++;
                count_ALL_items++;
            }


            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            dataGridView1.Columns[0].Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            { 
                
                DataGridViewRow selected_row = dataGridView1.SelectedRows[0];
                category_name.Text = selected_row.Cells[2].Value.ToString();
               
              count = dataGridView1.SelectedRows[0].Index;
              
            }
            catch { }
        }

        private void next_Click(object sender, EventArgs e)
        {
            count = ++count;
            bmb.Position = count;
            count = bmb.Position;
        }

        private void past_Click(object sender, EventArgs e)
        {
            count = --count;
            bmb.Position = count;
            count = bmb.Position;

        }

        private void first_Click(object sender, EventArgs e)
        {
            count = 0;
            bmb.Position = count;
            count = bmb.Position;
        }

        private void last_Click(object sender, EventArgs e)
        {
            bmb.Position = count_ALL_items;


        }

        private void Add_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            category_name.Text = "";
            save.Enabled = true;
            Add.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            save.Enabled = false;
            Add.Enabled = true;
            Categories_DATA category = new Categories_DATA();
            category.Description = category_name.Text;
            Categories_BLL.Insert_Categories(category);


            List<Categories_DATA> list_category = new List<Categories_DATA>();
            list_category = Categories_BLL.Select_ALL_Categories();

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("number");
            table.Columns.Add("description");
            int number = 1;
            foreach (var item in list_category)
            {
                table.Rows.Add(item.Id, number, item.Description);
                number++;
                count_ALL_items++;
            }


            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            bmb.Position = count_ALL_items;
            dataGridView1.Columns[0].Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Categories_DATA category = new Categories_DATA();
            DataGridViewRow selected_row = dataGridView1.SelectedRows[0];
            category.Id =Convert.ToInt16( selected_row.Cells[0].Value.ToString());
            Categories_BLL.Delete_Categories(category);



            List<Categories_DATA> list_category = new List<Categories_DATA>();
            list_category = Categories_BLL.Select_ALL_Categories();

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("number");
            table.Columns.Add("description");
            int number = 1;
            foreach (var item in list_category)
            {
                table.Rows.Add(item.Id, number, item.Description);
                number++;
                count_ALL_items++;
            }


            dataGridView1.DataSource = table;
            bmb = BindingContext[table];

            dataGridView1.Columns[0].Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int current_count;

            Categories_DATA category = new Categories_DATA();
            DataGridViewRow selected_row = dataGridView1.SelectedRows[0];
            category.Id = Convert.ToInt16(selected_row.Cells[0].Value.ToString());
            category.Description = category_name.Text;
            Categories_BLL.Upaate_Categories(category);
            current_count = count;


            List<Categories_DATA> list_category = new List<Categories_DATA>();
            list_category = Categories_BLL.Select_ALL_Categories();

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("number");
            table.Columns.Add("description");
            int number = 1;
            foreach (var item in list_category)
            {
                table.Rows.Add(item.Id, number, item.Description);
                number++;
                count_ALL_items++;
            }


            dataGridView1.DataSource = table;
            bmb = BindingContext[table];
            bmb.Position = current_count;
            dataGridView1.Columns[0].Visible = false;
        }

        private void print_category_Click(object sender, EventArgs e)
        {
            Form_category_list form = new Form_category_list();
            form.ShowDialog();

            this.Hide();

         


        }
    }
}
