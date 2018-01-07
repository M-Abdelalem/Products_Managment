using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Managment.DATA_BASE_LAYER
{
   static class DBL
    {

        static String connection_string;
        static DBL()
        {

            if (Properties.Settings.Default.mode == "sql")

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=True;";
            }

            else

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=false; User Id=" + Properties.Settings.Default.name + ";Password=" + Properties.Settings.Default.password + ";";


          
            }

        }
    public static DataTable get_DATA(string commend)
        {
            if (Properties.Settings.Default.mode == "sql")

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=True;";
            }

            else

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=false; User Id=" + Properties.Settings.Default.name + ";Password=" + Properties.Settings.Default.password + ";";



            }








            SqlConnection con = new SqlConnection(connection_string);
          
            SqlCommand com = new SqlCommand(commend, con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Data_adapter = new SqlDataAdapter(com);

            DataTable table = new DataTable();
            Data_adapter.Fill(table);
            return table;
        }
        public static void execute_query(string commend,List<SqlParameter> parameters) 
        {

            if (Properties.Settings.Default.mode == "sql")

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=True;";
            }

            else

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=false; User Id=" + Properties.Settings.Default.name + ";Password=" + Properties.Settings.Default.password + ";";



            }

            SqlConnection con = new SqlConnection(connection_string);

            SqlCommand com = new SqlCommand(commend, con);
            com.CommandType = CommandType.StoredProcedure;
           
            if(parameters!=null)
            com.Parameters.AddRange(parameters.ToArray());
                    con.Open();

            com.ExecuteNonQuery();
            con.Close();
        }

        public static DataRow get_DATA_row(string commend, List<SqlParameter> parameters)
        {
            if (Properties.Settings.Default.mode == "sql")

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=True;";
            }

            else

            {

                connection_string = "Data Source=" + Properties.Settings.Default.servername + ";Initial Catalog=" + Properties.Settings.Default.database + ";Integrated Security=false; User Id=" + Properties.Settings.Default.name + ";Password=" + Properties.Settings.Default.password + ";";



            }



            DataRow result = null;
            SqlConnection con = new SqlConnection(connection_string);

            SqlCommand com = new SqlCommand(commend, con);
            com.CommandType = CommandType.StoredProcedure;

            foreach (var item in parameters)
            {
                com.Parameters.Add(item);
            }
            SqlDataAdapter Data_adapter = new SqlDataAdapter(com);

            DataTable table = new DataTable();
          
            Data_adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                result = table.Rows[0];
            }
            com.Parameters.Clear();
            return result;
        }




    }
}
