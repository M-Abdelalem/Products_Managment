using Products_Managment.DATA;
using Products_Managment.DATA_BASE_LAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DAL
{
    static class Orders_DAL
    {
        public static List<Orders_DATA> Select_ALL_Orders()
        {
            List<Orders_DATA> Orders = new List<Orders_DATA>();
            DataTable table = DBL.get_DATA("ORDERS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Orders_DATA Order = new Orders_DATA();

                Order.Id = Convert.ToInt16(item["ID_ORDER"]);
                Order.Order_date =(DateTime) item["DATE_ORDERS"];
                Customer_DATA customer = new Customer_DATA();
                customer.ID = Convert.ToInt16(item["ID_CUSTOMER"]);
                Order.Customer = customer;
                Order.Total_paied = Convert.ToDouble(item["Total_paied"]);
                Order.User_id =Convert.ToInt16( item["ID_User"]);



                Orders.Add(Order);
            }

            return Orders;

        }
        public static List<Orders_DATA> Select_ALL_Orders_By_Customer_Id(int Customer_Id)
        {
            List<Orders_DATA> Orders = new List<Orders_DATA>();
            Orders_DATA Order = new Orders_DATA();
            DataTable table = DBL.get_DATA("ORDERS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Order.Id = Convert.ToInt16(item["ID_ORDER"]);
                Order.Order_date = (DateTime)item["DATE_ORDERS"];
                Customer_DATA customer = new Customer_DATA();
                customer.ID= Convert.ToInt16(item["ID_CUSTOMER"]);
                Order.Customer = customer;
                Order.Total_paied = Convert.ToDouble(item["Total_paied"]);

                Orders.Add(Order);
            }
         
            Orders = Orders.Where(x => x.Customer.ID == Customer_Id).ToList();
            return Orders;

        }
        public static List<Orders_DATA> Select_ALL_Orders_By_Categories_Id(int Categories_Id)
        {
            List<Orders_DATA> Orders = new List<Orders_DATA>();
            Orders_DATA Order = new Orders_DATA();
            DataTable table = DBL.get_DATA("ORDERS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Order.Id = Convert.ToInt16(item["ID_ORDER"]);
                Order.Order_date = (DateTime)item["DATE_ORDERS"];
                Order.Customer.ID = Convert.ToInt16(item["ID_CUSTOMER"]);
                Order.Total_paied = Convert.ToDouble(item["Total_paied"]);
                Orders.Add(Order);
            }

            return Orders;

        }

    

        public static Orders_DATA Select_Item_Orders(int Id)
        {
            Orders_DATA Orders=new Orders_DATA();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDER", Id));

            Orders.Id = Convert.ToInt16( DBL.get_DATA_row("ORDERS_select", parameters)[0]);
            Orders.Order_date =(DateTime) DBL.get_DATA_row("ORDERS_select", parameters)[1];
            Customer_DATA customer = new Customer_DATA();
            customer.ID = Convert.ToInt16(DBL.get_DATA_row("ORDERS_select", parameters)[2]);

            Orders.Customer = customer;
            Orders.User_id =Convert.ToInt16( DBL.get_DATA_row("ORDERS_select", parameters)[3]);
            Orders.Total_paied = Convert.ToDouble(DBL.get_DATA_row("ORDERS_select", parameters)[4]);
            Orders.Customer = new Customer_DATA();
            return Orders;



        }

        public static void Insert_Orders(Orders_DATA Orders)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("DATE_ORDERS", Orders.Order_date));
        

            parameters.Add(new SqlParameter("ID_CUSTOMER", Orders.Customer.ID));
            parameters.Add(new SqlParameter("ID_User", Orders.User_id));
            parameters.Add(new SqlParameter("Total_paied", Orders.Total_paied));
            DBL.execute_query("ORDERS_insert", parameters);


        }
        public static void Upaate_Orders(Orders_DATA Orders)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDER", Orders.Id));
            parameters.Add(new SqlParameter("DATE_ORDERS", Orders.Order_date));
            parameters.Add(new SqlParameter("ID_CUSTOMER", Orders.Customer.ID));
            parameters.Add(new SqlParameter("Total_paied", Orders.Total_paied));


            DBL.execute_query("ORDERS_update", parameters);


        }
        public static void Delete_Orders(Orders_DATA Orders)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDER", Orders.Id));

            DBL.execute_query("ORDERS_delete", parameters);
        }

    }
}
