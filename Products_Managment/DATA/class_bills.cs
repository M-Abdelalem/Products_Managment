using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
   public class class_bills
    {
        int id;
        string first_Name;
        string last_Name;
        string tel;
        string email;

        int quantity;
        DateTime order_date;
       
        double total_price;
        double discount;
        double total_price_after_discount;
        string label_product;
        string qte_in_product;
        string price;
        string user_name;

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

        public string First_Name
        {
            get
            {
                return first_Name;
            }

            set
            {
                first_Name = value;
            }
        }

        public string Last_Name
        {
            get
            {
                return last_Name;
            }

            set
            {
                last_Name = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public DateTime Order_date
        {
            get
            {
                return order_date;
            }

            set
            {
                order_date = value;
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

        public string User_name
        {
            get
            {
                return user_name;
            }

            set
            {
                user_name = value;
            }
        }
    }
}
