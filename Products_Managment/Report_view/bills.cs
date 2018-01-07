using Products_Managment.BLL;
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

namespace Products_Managment.Report_view
{
    public partial class bills : Form
    {
        public bills()
        {
            InitializeComponent();
        }

        private void bills_Load(object sender, EventArgs e)
        {
   

            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("first_Name");
            table.Columns.Add("last_Name");
            table.Columns.Add("tel");
            table.Columns.Add("email");
            table.Columns.Add("order_date");
            table.Columns.Add("user_name");

            DataTable details_table = new DataTable();
            
            details_table.Columns.Add("quantity");
            details_table.Columns.Add("total_price");
            details_table.Columns.Add("discount");
            details_table.Columns.Add("total_price_after_discount");
            details_table.Columns.Add("label_product");
            details_table.Columns.Add("price");
        







            Order_Details_DATA order_details = new Order_Details_DATA();
            order_details.Order = new Orders_DATA();
            order_details.Order.Customer = new Customer_DATA();
            order_details = Order_Details_BLL.Select_ALL_Order_Details().Last();
            Customer_DATA customer = new Customer_DATA();


            List<Orders_DATA> order = new List<Orders_DATA>();
            order = Orders_BLL.Select_ALL_Orders();
           
            foreach(var item in order)
            {
               if( order_details.Order.Id == item.Id)
                {
                    order_details.Order.Customer = Customer_BLL.Select_Item_Customers (item.Customer);
                }
            }

            List<Order_Details_DATA> list_order_details = new List<Order_Details_DATA>();
            list_order_details = Order_Details_BLL.Select_ALL_Order_Details();

            list_order_details =  Order_Details_BLL.Select_ALL_Order_Details().Where(x=>x.Order.Id ==order_details.Order.Id).ToList();

            Users user = new Users();


            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"])));
            }




            user.Id = order_details.Order.User_id;
            user = user_list.Single(x=>x.Id== user.Id);


            table.Rows.Add(
                order_details.Order.Id,
               order_details.Order.Customer.First_Name,
               order_details.Order.Customer.Last_Name,
               order_details.Order.Customer.Tel,
               order_details.Order.Customer.Email,
               order_details.Order.Order_date,
               user.Name
                   );
            foreach (var item in list_order_details)
            {

                details_table.Rows.Add(
                   item.Quantity,
                   item.Total_price,
                   item.Discount,
                   item.Total_price_after_discount,
                   item.Product.Label_product,
                   item.Product.Price
                   );
            }

            CrystalReport_bill s = new CrystalReport_bill();
            

          
            s.Subreports[0].SetDataSource(details_table);
            s.Subreports[0].AfterFormatPage += Bills_AfterFormatPage;
            s.SetDataSource(table);
            crystalReportViewer1.ReportSource = s;
        }

        private void Bills_AfterFormatPage(CrystalDecisions.CrystalReports.Engine.FormatPageEventArgs e)
        {
         
        }

        private void bills_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
