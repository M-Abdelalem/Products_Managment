using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
    class Category_Product
    {
        int id;
        string description;
        List<Products_DATA> products;
        string label_product;
        string qte_in_product;
        string price;
        byte[] image;
        int category_FK;
        Categories_DATA category;
        List<Order_Details_DATA> orders_daitels;
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

        public string Label_product
        {
            get
            {
                return label_product;
            }

            set
            {
                label_product = value;
            }
        }

        public string Qte_in_product
        {
            get
            {
                return qte_in_product;
            }

            set
            {
                qte_in_product = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public byte[] Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        internal List<Order_Details_DATA> Orders_daitels
        {
            get
            {
                return orders_daitels = Order_Details_DAL.Select_ALL_Order_Details_By_Products_Id(id);
            }

            set
            {
                orders_daitels = value;
            }
        }

        internal Categories_DATA Category
        {

            get
            {
                if (category != null)
                {
                    category = Categories_DAL.Select_Item_Categories(category.Id);
                }
                return category;
            }

            set
            {
                category = value;
            }
        }



      

        

        public string Description
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }

        internal List<Products_DATA> Products
        {
            get
            {
                return products = Products_DAL.Select_ALL_products_By_Category_Id(id);
            }

            set
            {
                products = value;
            }
        }

        public int Category_FK
        {
            get
            {
                return category_FK;
            }

            set
            {
                category_FK = value;
            }
        }

 
    }
    }
