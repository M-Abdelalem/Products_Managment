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
    static class Order_Details_DAL
    {
        public static List<Order_Details_DATA> Select_ALL_Order_Details()
        {
            List<Order_Details_DATA> Order_Details = new List<Order_Details_DATA>();
          
            DataTable table = DBL.get_DATA("ORDERS_DETAIAS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Order_Details_DATA Order_Detail = new Order_Details_DATA();
                Order_Detail.Id = Convert.ToInt16(item["ID_ORDERS_DETAIAS"]);
                Order_Detail.Quantity = Convert.ToInt16(item["QUANTITY"]);
                Order_Detail.Total_price = Convert.ToDouble(item["TOTAL_PRICE"]);
                Order_Detail.Total_price_after_discount = Convert.ToDouble(item["TOTAL_PRICE_with_discount"]);
                Order_Detail.Discount = Convert.ToDouble(item["DISCOUNT"]);
                Orders_DATA order = new Orders_DATA();
                Products_DATA product = new Products_DATA();
                Order_Detail.Order = order;
                Order_Detail.Product = product;
                order.Id= Convert.ToInt16(item["ID_ORDER"]);
                order= Orders_DAL.Select_Item_Orders(order.Id);
                Order_Detail.Order = order;
             
                product.Id= Convert.ToInt16(item["ID_PRODUCT"]);
                Order_Detail.Product.Id = product.Id;
             Order_Details.Add(Order_Detail);
            }

            return Order_Details;

        }
        public static List<Order_Details_DATA> Select_ALL_Order_Details_By_Order_Id(int Order_Id)
        {
            List<Order_Details_DATA> Order_Details = new List<Order_Details_DATA>();
            Order_Details_DATA Order_Detail = new Order_Details_DATA();
            DataTable table = DBL.get_DATA("ORDERS_DETAIAS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Order_Detail.Id = Convert.ToInt16(item["ID_ORDERS_DETAIAS"]);
                Order_Detail.Quantity = Convert.ToInt16(item["QUANTITY"]);
                Orders_DATA Order = new Orders_DATA();


                Order.Id = Convert.ToInt16(item["ID_ORDER"]);

                Products_DATA Product = new Products_DATA();
                Product.Id = Convert.ToInt16(item["ID_PRODUCT"]);

                Order_Detail.Order = Order;
                      Order_Detail.Product = Product;
                Order_Details.Add(Order_Detail);
            }
            Order_Details = Order_Details.Where(x => x.Order.Id == Order_Id).ToList();
            return Order_Details;

        }
        public static List<Order_Details_DATA> Select_ALL_Order_Details_By_Products_Id(int Products_Id)
        {
            List<Order_Details_DATA> Order_Details = new List<Order_Details_DATA>();
            Order_Details_DATA Order_Detail = new Order_Details_DATA();
            DataTable table = DBL.get_DATA("ORDERS_DETAIAS_select_All");
            foreach (DataRow item in table.Rows)
            {
                Order_Detail.Id = Convert.ToInt16(item["ID_ORDERS_DETAIAS"]);
                Order_Detail.Quantity = Convert.ToInt16(item["QUANTITY"]);
                Orders_DATA order = new Orders_DATA();
                order.Id= Convert.ToInt16(item["ID_ORDER"]);
                Order_Detail.Order = order;
                Products_DATA pro = new Products_DATA();
                pro.Id = Convert.ToInt16(item["ID_PRODUCT"]);
                Order_Detail.Product = pro;
                Order_Details.Add(Order_Detail);
            }
            Order_Details = Order_Details.Where(x => x.Product.Id == Products_Id).ToList();
            return Order_Details;

        }


        public static Order_Details_DATA Select_Item_Order_Details( int Id)
        {
            Order_Details_DATA Order_Details=new Order_Details_DATA();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDERS_DETAIAS", Id));

           // Order_Details = (Order_Details_DATA)DBL.get_DATA_row("ORDERS_DETAIAS_select", parameters);
            return Order_Details;



        }

        public static void Insert_Order_Details(Order_Details_DATA Order_Details)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("QUANTITY", Order_Details.Quantity));
            Orders_DATA oreder = new Orders_DATA();
            
                parameters.Add(new SqlParameter("ID_ORDER", Order_Details.Order.Id));

            parameters.Add(new SqlParameter("ID_PRODUCT", Order_Details.Product.Id));
            parameters.Add(new SqlParameter("PRICE", Order_Details.Product.Price));
            parameters.Add(new SqlParameter("DISCOUNT", Order_Details.Discount));
            parameters.Add(new SqlParameter("TOTAL_PRICE", Order_Details.Total_price));
            parameters.Add(new SqlParameter("TOTAL_PRICE_with_discount", Order_Details.Total_price_after_discount));

            

            DBL.execute_query("ORDERS_DETAIAS_insert", parameters);


        }
        public static void Upaate_Order_Details(Order_Details_DATA Order_Details)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDERS_DETAIAS", Order_Details.Id));
            parameters.Add(new SqlParameter("QUANTITY", Order_Details.Quantity));
            parameters.Add(new SqlParameter("ID_ORDER", Order_Details.Order.Id));

            parameters.Add(new SqlParameter("ID_PRODUCT", Order_Details.Product.Id));
            DBL.execute_query("ORDERS_DETAIAS_update", parameters);


        }
        public static void Delete_Order_Details(Order_Details_DATA Order_Details)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_ORDERS_DETAIAS", Order_Details.Id));

            DBL.execute_query("ORDERS_DETAIAS_delete", parameters);
        }

    }
}
