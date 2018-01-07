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
    static class Customer_DAL
    {


        public static List<Customer_DATA> Select_ALL_Customers()
        {
            List<Customer_DATA> Categories = new List<Customer_DATA>();
           
            DataTable table = DBL.get_DATA("CUSTOMER_select_All");
            foreach (DataRow item in table.Rows)
            {
                Customer_DATA Customer = new Customer_DATA();
                Customer.ID = Convert.ToInt16(item["ID_CUSTOMER"]);
                Customer.First_Name = item["FIRST_NAME"].ToString();
                Customer.Last_Name = item["LAST_NAME"].ToString();
                Customer.Tel = item["TEL"].ToString();
                Customer.Image =(byte[]) item["IMAGE_CUSTOMER"];
                Customer.Email = item["EMAIL"].ToString();
                Categories.Add(Customer);
            }
            return Categories;
        }
    
        public static Customer_DATA Select_Item_Customers(int Id)
        {
            Customer_DATA Customers=new Customer_DATA();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CUSTOMER", Id));

           Customers.ID =(int) DBL.get_DATA_row("CUSTOMER_select", parameters)[0];
            Customers.First_Name = DBL.get_DATA_row("CUSTOMER_select", parameters)[1].ToString();
            Customers.Last_Name = DBL.get_DATA_row("CUSTOMER_select", parameters)[2].ToString();
            Customers.Tel = DBL.get_DATA_row("CUSTOMER_select", parameters)[3].ToString();
            Customers.Email = DBL.get_DATA_row("CUSTOMER_select", parameters)[4].ToString();
         
            return Customers;



        }



      




        public static void Insert_Customers(Customer_DATA Customers)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("IMAGE_CUSTOMER", Customers.Image));
            parameters.Add(new SqlParameter("FIRST_NAME", Customers.First_Name));
            parameters.Add(new SqlParameter("LAST_NAME", Customers.Last_Name));
            parameters.Add(new SqlParameter("TEL", Customers.Tel));
            parameters.Add(new SqlParameter("EMAIL", Customers.Email));
            DBL.execute_query("CUSTOMER_insert", parameters);
   }
        public static void Update_Customers(Customer_DATA Customers)
        {

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CUSTOMER", Customers.ID));
            parameters.Add(new SqlParameter("IMAGE_CUSTOMER", Customers.Image));
            parameters.Add(new SqlParameter("FIRST_NAME", Customers.First_Name));

            parameters.Add(new SqlParameter("LAST_NAME", Customers.Last_Name));

            parameters.Add(new SqlParameter("TEL", Customers.Tel));

            parameters.Add(new SqlParameter("EMAIL", Customers.Email));

            DBL.execute_query("CUSTOMER_update", parameters);


        }
        public static void Delete_Customers(Customer_DATA Customers)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("ID_CUSTOMER", Customers.ID));

            DBL.execute_query("CUSTOMER_delete", parameters);
        }

    }
}

