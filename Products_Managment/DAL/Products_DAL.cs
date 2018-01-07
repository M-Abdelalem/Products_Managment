using Products_Managment.DATA;
using Products_Managment.DATA_BASE_LAYER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DAL
{
    static class Products_DAL
    {
        public static List<Products_DATA> Select_ALL_Product()
        {
            List<Products_DATA> Products = new List<Products_DATA>();
            
            DataTable table = DBL.get_DATA("PRODUCT_select_All");
            foreach (DataRow item in table.Rows)
            {
                Products_DATA Product = new Products_DATA();
                Product.Id = Convert.ToInt16(item["ID_PRODUCT"]);
               Product.Image =(byte[]) item["IMAGE_PRODUCT"];
                Product.Label_product = item["LABEL_PRODUCT"].ToString();
                Product.Price = item["QTE_IN_PRODUCT"].ToString();
                Product.Qte_in_product = item["PRICE"].ToString();
                Categories_DATA c = new Categories_DATA();
          
                    c.Id= Convert.ToInt16(item["ID_CATEGORIES"]);
                Product.Category = c;
                Products.Add(Product);
            }
            return Products;
        }

      
              public static List<Products_DATA> Select_ALL_products_By_Category_Id(int Category_Id)
        {
            List<Products_DATA> Products = new List<Products_DATA>();
           
            DataTable table = DBL.get_DATA("PRODUCT_select_All");
            foreach (DataRow item in table.Rows)
            {
                Products_DATA Product = new Products_DATA();
                Product.Id = Convert.ToInt16(item["ID_PRODUCT"]);
                Product.Image = (byte[])item["IMAGE_PRODUCT"];
                Product.Label_product = item["LABEL_PRODUCT"].ToString();
                Product.Price = item["QTE_IN_PRODUCT"].ToString();
                Product.Qte_in_product = item["PRICE"].ToString();
                Categories_DATA cate = new Categories_DATA();
                cate.Id= Convert.ToInt16(item["ID_CATEGORIES"]);
                Product.Category = cate;


                Products.Add(Product);
            }
            Products = Products.Where(x => x.Category.Id == Category_Id).ToList();
            return Products;
        }

        public static Products_DATA Select_Item_Product( int Id)
        {
            Products_DATA Products = new Products_DATA();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_PRODUCT", Id));
          



            Products.Id =(int) DBL.get_DATA_row("PRODUCT_select", parameters)[0];
            Products.Label_product = DBL.get_DATA_row("PRODUCT_select", parameters)[1].ToString();
            Products.Price = DBL.get_DATA_row("PRODUCT_select", parameters)[2].ToString();
            Products.Qte_in_product = DBL.get_DATA_row("PRODUCT_select", parameters)[3].ToString();
        
            return Products;



        }

        public static void Insert_Product(Products_DATA Products)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
           parameters.Add(new SqlParameter("IMAGE_PRODUCT", Products.Image));
            parameters.Add(new SqlParameter("LABEL_PRODUCT", Products.Label_product));
            parameters.Add(new SqlParameter("QTE_IN_PRODUCT", Products.Price));
            parameters.Add(new SqlParameter("PRICE", Products.Qte_in_product));
            parameters.Add(new SqlParameter("ID_CATEGORIES", Products.Category.Id));


            DBL.execute_query("PRODUCT_insert", parameters);
        }
        public static void Update_Product(Products_DATA Products)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_PRODUCT", Products.Id));
            parameters.Add(new SqlParameter("IMAGE_PRODUCT", Products.Image));

            parameters.Add(new SqlParameter("LABEL_PRODUCT", Products.Label_product));


            parameters.Add(new SqlParameter("QTE_IN_PRODUCT", Products.Price));
            parameters.Add(new SqlParameter("PRICE", Products.Qte_in_product));
            parameters.Add(new SqlParameter("ID_CATEGORIES", Products.Category.Id));

            DBL.execute_query("PRODUCT_update", parameters);


        }
        public static void Delete_Product(Products_DATA Products)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ID_PRODUCT", Products.Id));

            DBL.execute_query("PRODUCT_delete", parameters);
        }
    }
}
