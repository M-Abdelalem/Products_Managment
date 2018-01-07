using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.BLL
{
    static class Orders_BLL
    {
        public static List<Orders_DATA> Select_ALL_Orders()
        {
            
            return Orders_DAL.Select_ALL_Orders();

        }
        public static Orders_DATA Select_Item_Categories(Orders_DATA Orders)
        {
            return Orders_DAL.Select_Item_Orders(Orders.Id);
        }

        public static void Insert_Orders(Orders_DATA Orders)
        {
            Orders_DAL.Insert_Orders(Orders);


        }
        public static void Upaate_Orders(Orders_DATA Orders)
        {
            Orders_DAL.Upaate_Orders(Orders);

        }
        public static void Delete_Orders(Orders_DATA Orders)
        {
            Orders_DAL.Delete_Orders(Orders);
        }
    }
}
