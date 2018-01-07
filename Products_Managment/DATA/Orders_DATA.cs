using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
     class Orders_DATA
    {
        int id;
        DateTime order_date;
        Customer_DATA customer;
        List<Order_Details_DATA> order_details;
        int user_id;
        double total_paied;
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

        internal List<Order_Details_DATA> Order_details
        {
            get
            {
                if (order_details != null)
                {
                    return order_details = Order_Details_DAL.Select_ALL_Order_Details_By_Order_Id(id);
                }
                return order_details;
            }

            set
            {
                order_details = value;
            }
        }

        internal Customer_DATA Customer
        {
            get
            {
               
                    return customer;
               
            
            }

            set
            {
                customer = value;
            }
        }

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public double Total_paied
        {
            get
            {
                return total_paied;
            }

            set
            {
                total_paied = value;
            }
        }
    }
    }

