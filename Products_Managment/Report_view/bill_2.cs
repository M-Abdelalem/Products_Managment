using Products_Managment.BLL;
using Products_Managment.DAL;
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
    public partial class bill_2 : Form
    {
        Orders_DATA order;
        public bill_2()
        {
            InitializeComponent();
        }

        internal Orders_DATA Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        private void bill_2_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("first_Name");
            table.Columns.Add("last_Name");
            table.Columns.Add("tel");
            table.Columns.Add("email");
            table.Columns.Add("order_date");
            table.Columns.Add("user_name");


            



            List<Order_Details_DATA> Order_Detail = new List<Order_Details_DATA>();
            Order.Customer = Customer_BLL.Select_Item_Customers(Order.Customer);

            Order_Detail = Order_Details_DAL.Select_ALL_Order_Details_By_Order_Id(Order.Id);
            class_bills bill = new class_bills();

            Users user = new Users();


            List<Users> user_list = new List<Users>();
            DataTable tables = DBL.get_DATA("Select_Users");
            foreach (DataRow item in tables.Rows)
            {
                user_list.Add(new Users(item["Name"].ToString(), item["Password"].ToString(), Convert.ToInt16(item["ID_User"])));
            }



           
            user.Id = Order.User_id;
            user = user_list.Single(x => x.Id == user.Id);





            bill.Id = Order.Id;
            bill.First_Name = Order.Customer.First_Name;
            bill.Last_Name = Order.Customer.Last_Name;
            bill.Tel = Order.Customer.Tel;
            bill.Email = Order.Customer.Email;
            bill.Order_date = Order.Order_date;
            bill.User_name = user.Name;

            table.Rows.Add(
               bill.Id,
             bill.First_Name,
              bill.Last_Name,
              bill.Tel,
              bill.Email,
              bill.Order_date,
              user.Name
                  );





            DataTable details_table = new DataTable();

            details_table.Columns.Add("quantity");
            details_table.Columns.Add("total_price");
            details_table.Columns.Add("discount");
            details_table.Columns.Add("total_price_after_discount");
            details_table.Columns.Add("label_product");
            details_table.Columns.Add("price");

            List<Order_Details_DATA> list_order_details = new List<Order_Details_DATA>();
            list_order_details = Order_Details_BLL.Select_ALL_Order_Details();

            list_order_details = Order_Details_BLL.Select_ALL_Order_Details().Where(x => x.Order.Id == bill.Id).ToList();


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
            s.SetDataSource(table);
            crystalReportViewer1.ReportSource = s;


           




        }
    }
}
