using Products_Managment.BLL;
using Products_Managment.DAL;
using Products_Managment.DATA;
using Products_Managment.Report_view;
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
    public partial class Form_orders : Form
    {

        Users user_name;
        Customer_DATA customer;
        Products_DATA product;
        DataTable table = new DataTable();
        internal Customer_DATA Customer
        {
            get
            {
                return customer;
                
            }

            set
            {
                customer = value;
                id.Text = customer.ID.ToString();
                name.Text = customer.First_Name;
                lastname.Text = customer.Last_Name;
                phone.Text = customer.Tel;
                email.Text = customer.Email;
                MemoryStream ms = new MemoryStream((byte[])customer.Image);
                pictureBox1.Image = Image.FromStream(ms);

            }
        }

        internal Products_DATA Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;

                product_id.Text = product.Id.ToString() ;
                product_name.Text = product.Label_product.ToString();
                product_price.Text = product.Price.ToString();
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

        public Form_orders():this(null)
        {
           
      


            InitializeComponent();
        }

        public Form_orders(Users _user_name)
        {
            User_name = _user_name;




            InitializeComponent();
        }




        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_orders_Load(object sender, EventArgs e)
        {
            textBox3.Text = User_name.Name;
            DataTable table = new DataTable();
            List<Products_DATA> list = Products_DAL.Select_ALL_Product();
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
           




            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersWidth = 77;
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 75;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 75;
            dataGridView1.Columns[5].Width = 75;
            dataGridView1.Columns[6].Width = 143;
            dataGridView1.ColumnHeadersVisible = false;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_select_customer select_cutomer = new Form_select_customer(this);
            this.Hide();
            select_cutomer.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form_Select_products form = new Form_Select_products(this);
            form.ShowDialog();
        }

        private void product_quantety_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (product_quantety.Text != "")

                {
                    if (Convert.ToInt16(product_quantety.Text) <= Convert.ToInt16(product.Qte_in_product))
                    {
                        product_total_price.Text = (Convert.ToDouble(product_quantety.Text) * Convert.ToDouble(product_price.Text)).ToString();

                    }


                    else if (Convert.ToInt16(product_quantety.Text) > Convert.ToInt16(product.Qte_in_product))
                    {

                        MessageBox.Show("product_quantety is not enuogh");

                        List<char> str = new List<char>();
                        int x = 0;
                        foreach (char s in product_quantety.Text)
                        {
                            str.Add(s);
                            x++;

                        }


                        str.RemoveAt(x - 1);
                        string m = "";
                        foreach (var item in str)
                        {
                            m += item.ToString();
                        }

                        product_quantety.Text = m;

                    }
                }
                else
                {
                    product_quantety.Text = "";
                    product_total_price.Text = "";
                }
            }
            catch { }
            
        }

        private void product_discount_TextChanged(object sender, EventArgs e)
        {
            if (product_total_price.Text !=""&& product_discount.Text!=""&& product_total_price.Text!="")
            {
                double discount = Convert.ToDouble( Convert.ToDouble(product_discount.Text)/100);
                double total = Convert.ToDouble(product_total_price.Text);
                product_total.Text = (total - (total * discount)).ToString();

            }
            else {
                product_total.Text = "";
            }

        }

        private void product_total_price_TextChanged(object sender, EventArgs e)
        {
            if (product_total_price.Text != "" && product_discount.Text != "" && product_total_price.Text != "")
            {
                double discount = Convert.ToDouble(Convert.ToDouble(product_discount.Text) / 100);
                double total = Convert.ToDouble(product_total_price.Text);
                product_total.Text = (total - (total * discount)).ToString();

            }
            else
            {
                product_total.Text = "";
            }

        }

        private void product_quantety_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            
        }

        private void product_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void product_discount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_word_Click(this, new EventArgs());
            }





        }

        private void search_word_Click(Form_orders form_orders, EventArgs eventArgs)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToInt16(item.Cells[0].Value) == Convert.ToInt16(product_id.Text))
                {
                    MessageBox.Show("that producted has been added befor");
                    return;
                }


            }

            DataRow row = table.NewRow();
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Columns.Add("");
            table.Rows.Add(product_id.Text, product_name.Text, product_price.Text, product_quantety.Text, product_total_price.Text, product_discount.Text, product_total.Text);
            dataGridView1.DataSource = table;
            double total = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                total += Convert.ToDouble(item.Cells[6].Value);



            }
            total_value.Text = total.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            product_id.Text = row.Cells[0].Value.ToString();
                product_name.Text = row.Cells[1].Value.ToString();
            product_price.Text = row.Cells[2].Value.ToString();
            product_quantety.Text = row.Cells[3].Value.ToString();
            product_total_price.Text = row.Cells[4].Value.ToString();
            product_discount.Text = row.Cells[5].Value.ToString();
            product_total.Text = row.Cells[6].Value.ToString();
            total_value.Text = (Convert.ToDouble(total_value.Text) - Convert.ToDouble(product_total.Text)).ToString();
            dataGridView1.Rows.Remove(row);
            

        }

        private void حذفالسطرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);

        }

        private void حذفالسطرToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(row);
            total_value.Text = (Convert.ToDouble(total_value.Text) - Convert.ToDouble(product_total.Text)).ToString();


        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
            dataGridView1.DataSource = table;
            total_value.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Orders_DATA order = new Orders_DATA();
            order.User_id = user_name.Id;
            order.Order_date =Convert.ToDateTime( dateTimePicker1.Text);
            Customer_DATA customer = new Customer_DATA();
            customer.ID =Convert.ToInt16( id.Text);
            order.Customer = customer;
            order.Total_paied = Convert.ToDouble(total_value.Text);
            Orders_BLL.Insert_Orders(order) ;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                Products_DATA product = new Products_DATA();
                product.Id = Convert.ToInt16(row.Cells[0].Value);
                Orders_DATA orders = new Orders_DATA();
                orders = Orders_BLL.Select_ALL_Orders().Last();
                Order_Details_DATA order_details = new Order_Details_DATA();
                order_details.Quantity = Convert.ToInt16(row.Cells[3].Value);
                order_details.Total_price = Convert.ToDouble(row.Cells[4].Value);
                order_details.Discount = Convert.ToDouble(row.Cells[5].Value);
                order_details.Total_price_after_discount = Convert.ToDouble(row.Cells[6].Value);
                order_details.Order = orders;
                order_details.Product = product;
                Order_Details_BLL.Insert_Order_Details(order_details);

            }


                id.Text = "";
                name.Text = "";
                lastname.Text = "";
                phone.Text = "";
                email.Text = "";
                textBox2.Text = "";
                product_id.Text = "";
                product_name.Text = "";
                product_price.Text = "";
                product_quantety.Text = "";
                product_total_price.Text = "";
                product_discount.Text = "";
                product_total.Text = "";
                total_value.Text = "";
                pictureBox1.Image = null;
                button2.Enabled = true;
                button3.Enabled = false;
                table.Clear();
                dataGridView1.DataSource = table;
            }

        

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
            id.Text = "";
            name.Text = "";
            lastname.Text = "";
            phone.Text = "";
            email.Text = "";
            textBox2.Text = "";
            product_id.Text = "";
            product_name.Text = "";
            product_price.Text = "";
            product_quantety.Text = "";
            product_total_price.Text = "";
            product_discount.Text = "";
            product_total.Text = "";
            total_value.Text = "";
            pictureBox1.Image = null;
            table.Clear();
            dataGridView1.DataSource = table;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bills form = new bills();
            form.ShowDialog();


        }
    }
    }
