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
    static class Categories_DAL
    {
        public static List<Categories_DATA> Select_ALL_Categories()
        {
            List<Categories_DATA> Categories = new List<Categories_DATA>();
            DataTable table = DBL.get_DATA("CATEGORIES_select_ALL");
            foreach (DataRow item in table.Rows)
            {
                Categories_DATA Category = new Categories_DATA();

                Category.Id = Convert.ToInt16(item["ID_CATEGORIES"]);
                Category.Description = item["DESCRPTION_CATEGORIES"].ToString();
                Categories.Add(Category);
            }

            return Categories;

        }
     
        public static Categories_DATA Select_Item_Categories(int Id)
        {
            Categories_DATA Category=new Categories_DATA();

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CATEGORIES",Id));

            Category.Id =Convert.ToInt16( DBL.get_DATA_row("CATEGORIES_select", parameters)["ID_CATEGORIES"]);
            Category.Description = DBL.get_DATA_row("CATEGORIES_select", parameters)["DESCRPTION_CATEGORIES"].ToString();
            return Category;



        }

        public static void Insert_Categories(Categories_DATA Category)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("DESCRPTION_CATEGORIES", Category.Description));

            DBL.execute_query("CATEGORIES_insert", parameters);


        }
        public static void Upaate_Categories(Categories_DATA Category)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CATEGORIES", Category.Id));
            parameters.Add(new SqlParameter("DESCRPTION_CATEGORIES", Category.Description));

            DBL.execute_query("CATEGORIES_update", parameters);


        }
        public static void Delete_Categories(Categories_DATA Category)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CATEGORIES", Category.Id));

            DBL.execute_query("CATEGORIES_delete", parameters);
        }

    }
}
