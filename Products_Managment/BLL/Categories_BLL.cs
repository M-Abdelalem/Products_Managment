using Products_Managment.DAL;
using Products_Managment.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.BLL
{
 static   class Categories_BLL
    {
        public static List<Categories_DATA> Select_ALL_Categories()
        {

            return DAL.Categories_DAL.Select_ALL_Categories();

        }
        public static Categories_DATA Select_Item_Categories(Categories_DATA Category)
        {


            return DAL.Categories_DAL.Select_Item_Categories(Category.Id);


        }

        public static void Insert_Categories(Categories_DATA Category)
        {

            Categories_DAL.Insert_Categories(Category);

        }
        public static void Upaate_Categories(Categories_DATA Category)
        {
            Categories_DAL.Upaate_Categories(Category);


        }
        public static void Delete_Categories(Categories_DATA Category)
        {
            Categories_DAL.Delete_Categories(Category);

        }

    }
}
