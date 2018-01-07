using Products_Managment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
     class Customer_DATA
    {

        int id;
        string first_Name;
        string last_Name;
        string tel;
        string email;
       

        byte[] image;

        List<Orders_DATA> orders;


        public int ID
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

        internal List<Orders_DATA> Orders
        {
            get
            {
                return orders= Orders_DAL. Select_ALL_Orders_By_Customer_Id(id);
            }

            set
            {
                orders = value;
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
    }
}
