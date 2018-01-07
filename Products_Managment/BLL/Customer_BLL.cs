using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.BLL
{
    static class Customer_BLL
    {
        public static List<Customer_DATA> Select_ALL_Customers()
        {
            return Customer_DAL.Select_ALL_Customers();
        }
        public static Customer_DATA Select_Item_Customers(Customer_DATA Customers)
        {


            return Customer_DAL.Select_Item_Customers(Customers.ID);

        }

        public static void Insert_Customers(Customer_DATA Customers)
        {
            Customer_DAL.Insert_Customers(Customers);
        }
        public static void Update_Customers(Customer_DATA Customers)
        {
            Customer_DAL.Update_Customers(Customers);



        }
        public static void Delete_Customers(Customer_DATA Customers)
        {
            Customer_DAL.Delete_Customers(Customers);


        }

    }
}
