using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
    class Order_Details_DATA
    {
        int id;
        int quantity;
        Orders_DATA order;
        Products_DATA product;
        double total_price;
        double discount;
        double total_price_after_discount;


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

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

  

        internal Products_DATA Product
        {
            get
            {
                if (product != null)
                {
                    return  Products_DAL.Select_Item_Product(product.Id);
                }
                return product;
            }

            set
            {
                product = value;
            }
        }

        public double Total_price
        {
            get
            {
                return total_price;
            }

            set
            {
                total_price = value;
            }
        }

        public double Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public double Total_price_after_discount
        {
            get
            {
                return total_price_after_discount;
            }

            set
            {
                total_price_after_discount = value;
            }
        }

        internal Orders_DATA Order
        {

            get 
           {
                if (order != null)
               {

                    return order;


              }
         return order;
           }

            set
            {
                order = value;
            }
        }
    }
}
