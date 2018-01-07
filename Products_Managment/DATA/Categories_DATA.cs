using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
  public  class Categories_DATA
    {
        int id;
        string description;
        List<Products_DATA> products;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        internal List<Products_DATA> Products
        {
            get
            {
                return products= Products_DAL.Select_ALL_products_By_Category_Id(id);
            }

            set
            {
                products = value;
            }
        }
    }
}
