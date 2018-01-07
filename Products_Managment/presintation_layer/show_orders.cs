using Products_Managment.BLL;
using Products_Managment.DAL;
using Products_Managment.DATA;
using Products_Managment.DATA_BASE_LAYER;
using Products_Managment.Report_view;
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
    public partial class show_orders : Form
    {
        public show_orders()
        {
            InitializeComponent();
        }

        private void show_orders_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("رقم الفاتورة");     
            table.Columns.Add("التاريخ");
            table.Columns.Add("Id_customer");
            table.Columns.Add("الاسم الاول");
            table.Columns.Add("الاسم الثاني");
            table.Columns.Add("ID_User");
            table.Columns.Add("قيمة الفاتورة");


            List<Orders_DATA> list_order = new List<Orders_DATA>();
            list_order = Orders_BLL.Select_ALL_Orders();
            
          
            foreach (var item in list_order)
            {
               // List<Order_Details_DATA> Order_Detail = new List<Order_Details_DATA>();
                item.Customer= Customer_BLL.Select_Item_Customers(item.Customer);

              //  Order_Detail = Order_Details_DAL.Select_ALL_Order_Details_By_Products_Id(item.Id);

                table.Rows.Add(item.Id,
                    item.Order_date,
                     item.Customer.ID,
                    item.Customer.First_Name,
                       item.Customer.Last_Name,
                   item.User_id,
                    item.Total_paied);




            }

            dataGridView1.DataSource = table;

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bill_2 bill = new bill_2();
            Orders_DATA Order = new Orders_DATA();
            Order.Id =Convert.ToInt16( dataGridView1.SelectedRows[0].Cells[0].Value);
            //Order.Order_date = DateTime.ParseExact(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
            Customer_DATA Customer = new Customer_DATA();
            Customer.ID = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[2].Value);

            Customer.First_Name =dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            Customer.Last_Name = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Order.User_id =Convert.ToInt16( dataGridView1.SelectedRows[0].Cells[5].Value);
            Order.Total_paied =Convert.ToDouble( dataGridView1.SelectedRows[0].Cells[6].Value);

            bill.Order = Order;
            bill.Order.Customer = Customer;
           
            bill.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("رقم الفاتورة");
            table.Columns.Add("التاريخ");
            table.Columns.Add("Id_customer");
            table.Columns.Add("الاسم الاول");
            table.Columns.Add("الاسم الثاني");
            table.Columns.Add("ID_User");
            table.Columns.Add("قيمة الفاتورة");


            List<Orders_DATA> list_order = new List<Orders_DATA>();
            list_order = Orders_BLL.Select_ALL_Orders();
            foreach (var item in list_order)
            {
                item.Customer = Customer_BLL.Select_Item_Customers(item.Customer);

            
            }

            list_order = list_order.Where(x =>
       (x.Customer.First_Name.Contains(search.Text) || search.Text == "")
        || (x.Customer.Last_Name.Contains(search.Text) || search.Text == "")
        || (x.Id.ToString().Contains(search.Text) || search.Text == "")

        || (search.Text.Contains(x.Customer.First_Name + " " + x.Customer.Last_Name))
         ).ToList();

            list_order = list_order.Where(x =>
              (x.Order_date.ToString().Contains(dateTimePicker1.Value.Date.ToString()))).ToList();




            foreach (var item in list_order)
            {
                List<Order_Details_DATA> Order_Detail = new List<Order_Details_DATA>();
                item.Customer = Customer_BLL.Select_Item_Customers(item.Customer);

                Order_Detail = Order_Details_DAL.Select_ALL_Order_Details_By_Products_Id(item.Id);

                table.Rows.Add(item.Id,
                    item.Order_date,
                     item.Customer.ID,
                    item.Customer.First_Name,
                       item.Customer.Last_Name,
                   item.User_id,
                    item.Total_paied);




            }

            dataGridView1.DataSource = table;

            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;





































            //foreach (var item in list)
            //{
            //    table.Rows.Add(item.ID, item.First_Name, item.Last_Name, item.Tel, item.Email, item.Image);
            //    count_ALL_items++;
            //}




        }
    }

}

