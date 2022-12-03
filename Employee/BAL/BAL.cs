using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Employee.BAL
{
    public class BAL
    {
        DAL.DAL dalobj = new DAL.DAL();
        private string name;
        private string age;
        private string email;
        private string phone;
        private int id;

        


        public int DID
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

        public string Age { get { return age; } set { age = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }

        public int InsertData()
        {
            return dalobj.InsertEmployeeData(this);
        }

        public DataTable ViewData()
        {
            return dalobj.ViewEmpl();
        }

        public int UpdateEmpl()
        {
            return dalobj.EmplUpdate(this);
        }
        public int DeleteEmpl()
        {
            return dalobj.EmplDelete(this);
        }
    }
}