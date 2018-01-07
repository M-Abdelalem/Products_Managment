using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Products_Managment.DATA
{
     class Products_DATA
    {



        int id;
        string label_product;
        string qte_in_product;
        string price;
        byte[] image;
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
                return orders_daitels= Order_Details_DAL.Select_ALL_Order_Details_By_Products_Id(id);
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
    }
}
