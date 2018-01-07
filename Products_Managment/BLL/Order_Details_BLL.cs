using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.BLL
{
    static class Order_Details_BLL
    {
        public static List<Order_Details_DATA> Select_ALL_Order_Details()
        {

            return Order_Details_DAL.Select_ALL_Order_Details();
        }
        public static Order_Details_DATA Select_Item_Order_Details(Order_Details_DATA Order_Details)
        {
            return Order_Details_DAL.Select_Item_Order_Details(Order_Details.Id);


        }

        public static void Insert_Order_Details(Order_Details_DATA Order_Details)
        {
            Order_Details_DAL.Insert_Order_Details(Order_Details);
        }
        public static void Upaate_Order_Details(Order_Details_DATA Order_Details)
        {
            Order_Details_DAL.Upaate_Order_Details(Order_Details);
        }
        public static void Delete_Order_Details(Order_Details_DATA Order_Details)
        {
            Order_Details_DAL.Delete_Order_Details(Order_Details);

        }
    }
}
