using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Managment.DATA
{
   public class Users
    {
        int id;
        string name;
        string password;
        string type;
        public Users()
        {


        }
        public Users(string _name, string _password)
        {
            name = _name;

            password = _password;

        }
        public Users(string _name, string _password,int _id)
        {
            id = _id;
               name = _name;

            password = _password;

        }
        public Users(string _name, string _password, int _id,string _type)
        {
            id = _id;
            name = _name;
            type = _type;
            password = _password;

        }
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
