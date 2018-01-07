using Products_Managment.BLL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Managment.presintation_layer
{
    public partial class Form_Customer : Form
    {
        int count;
        int count_ALL_items;
        BindingManagerBase bmb;
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
         
            Customer_DATA castumer = new Customer_DATA();
            castumer.First_Name = name.Text;
            castumer.Last_Name = surname.Text;
            castumer.Tel = phone.Text;
            castumer.Email = email.Text;
            MemoryStream memory = new MemoryStream();
            image.Image.Save(memory, image.Image.RawFormat);
            byte[] byte_image = memory.ToArray();
            castumer.Image = byte_image;
            Customer_BLL.Insert_Customers(castumer);
          

            List<Customer_DATA> customer = new List<Customer_DATA>();
            customer = Customer_BLL.Select_ALL_Customers();
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("last name");
            table.Columns.Add("phone");
            table.Columns.Add("email");
            table.Columns.Add("image", typeof(byte[]));

            foreach (var item in customer)
            {
                table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);

            }


            dataGridView1.DataSource = table;
            dataGridView1.Columns[5].Visible = false;
           
  
            add.Enabled = false;
            add_new.Enabled = true;
            bmb = BindingContext[table];
            bmb.Position = count_ALL_items;

        }

        private void image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "صور|*.png;*.jpg;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(open.FileName);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            List<Customer_DATA> customer = new List<Customer_DATA>();
            customer = Customer_BLL.Select_ALL_Customers();
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("last name");
            table.Columns.Add("phone");
            table.Columns.Add("email");
            table.Columns.Add("image",typeof(byte[]));
           
            foreach (var item in customer)
            {
                table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);
                count_ALL_items++;
            }

            bmb = BindingContext[table];
            dataGridView1.DataSource = table;
            dataGridView1.Columns[5].Visible = false;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            image.Image = null;
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                name.Text = row.Cells[1].Value.ToString();
                surname.Text = row.Cells[2].Value.ToString();
                email.Text = row.Cells[4].Value.ToString();
                phone.Text = row.Cells[3].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])row.Cells[5].Value);
                image.Image = Image.FromStream(ms);
                count = dataGridView1.SelectedRows[0].Index;
            }
            catch {


             
                


            }
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            add.Enabled = true;
            name.Text = "";
            surname.Text = "";
            email.Text = "";
            phone.Text ="" ;
            image.Image = null;
            add_new.Enabled = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            int current_count;
            current_count = count;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Customer_DATA castumer = new Customer_DATA();
            castumer.ID= Convert.ToInt16(row.Cells[0].Value);
            castumer.First_Name = name.Text;
            castumer.Last_Name = surname.Text;
            castumer.Tel = phone.Text;
            castumer.Email = email.Text;
            MemoryStream memory = new MemoryStream();
            image.Image.Save(memory, image.Image.RawFormat);
            byte[] byte_image = memory.ToArray();
            castumer.Image = byte_image;
            Customer_BLL.Update_Customers(castumer);



            List<Customer_DATA> customer = new List<Customer_DATA>();
            customer = Customer_BLL.Select_ALL_Customers();
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("last name");
            table.Columns.Add("phone");
            table.Columns.Add("email");
            table.Columns.Add("image", typeof(byte[]));

            foreach (var item in customer)
            {
                table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);

            }


            dataGridView1.DataSource = table;
            dataGridView1.Columns[5].Visible = false;
            bmb = BindingContext[table];
            bmb.Position = current_count;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Customer_DATA castumer = new Customer_DATA();
            castumer.ID = Convert.ToInt16(row.Cells[0].Value);
        
            Customer_BLL.Delete_Customers(castumer);



            List<Customer_DATA> customer = new List<Customer_DATA>();
            customer = Customer_BLL.Select_ALL_Customers();
            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("last name");
            table.Columns.Add("phone");
            table.Columns.Add("email");
            table.Columns.Add("image", typeof(byte[]));

            foreach (var item in customer)
            {
                table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);

            }


            dataGridView1.DataSource = table;
            dataGridView1.Columns[5].Visible = false;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_word_Click(object sender, EventArgs e)
        {
          
            List<Customer_DATA> list=new List<Customer_DATA>();
            
                list = Customer_BLL.Select_ALL_Customers().Where
                (x =>
               (x.First_Name.Contains(search.Text) || search.Text == "")
                || (x.Last_Name.Contains(search.Text) || search.Text == "")
                || (x.Tel.Contains(search.Text) || search.Text == "")
                || (x.Email.Contains(search.Text) || search.Text == "")
                || (search.Text.Contains(x.First_Name+" "+x.Last_Name))
                 ).ToList();




            DataTable table = new DataTable();
            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("last name");
            table.Columns.Add("phone");
            table.Columns.Add("email");
            table.Columns.Add("image", typeof(byte[]));

            foreach (var item in list)
            {
                table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);
                count_ALL_items++;
            }

            bmb = BindingContext[table];
            dataGridView1.DataSource = table;
            dataGridView1.Columns[5].Visible = false;







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

        private void search_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

      



        }



        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_word_Click(this, new EventArgs());
            }
        }
    }
}
