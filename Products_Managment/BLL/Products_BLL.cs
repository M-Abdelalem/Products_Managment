using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.BLL
{
    static class Products_BLL
    {
        public static List<Products_DATA> Select_ALL_Product()
        {
            return Products_DAL.Select_ALL_Product();
        }
        public static Products_DATA Select_Item_Product(Products_DATA Products)
        {


            return Products_DAL.Select_Item_Product(Products.Id);
        }

        public static void Insert_Product(Products_DATA Products)
        {
             Products_DAL.Insert_Product(Products);

        }
        public static void Update_Product(Products_DATA Products)
        {
            Products_DAL.Update_Product(Products);


        }
        public static void Delete_Product(Products_DATA Products)
        {
            Products_DAL.Delete_Product(Products);

        }
    }
}
