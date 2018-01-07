using Products_Managment.BLL;
using Products_Managment.DATA;
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
    public partial class Form_select_customer : Form
    {
        Form_orders form_orders;

        public Form_orders Form_orders
        {
            
            get
            {
                return form_orders;
            }

            set
            {
                form_orders = value;
                
            }
            
        }

        public Form_select_customer():this(null)
        {
            InitializeComponent();
        }


        public Form_select_customer(Form_orders _Form_orders)
        {

            Form_orders = _Form_orders;
            InitializeComponent();
        }


        private void Form_select_customer_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Customer_DATA Customer = new Customer_DATA();
        Customer.ID = Convert.ToInt16(row.Cells[0].Value);
         Customer.First_Name = row.Cells[1].Value.ToString();
           Customer.Last_Name = row.Cells[2].Value.ToString();
            Customer.Tel = row.Cells[3].Value.ToString();
           Customer.Email = row.Cells[4].Value.ToString();
           Customer.Image = (byte[])row.Cells[5].Value;
            Form_orders.Customer = Customer;
            Form_orders.Show();
            this.Close();
           

        }
    }
}
