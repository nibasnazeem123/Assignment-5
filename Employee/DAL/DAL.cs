using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Employee.DAL
{
    
    public class DAL
    {
        
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public DAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;

        }

        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int InsertEmployeeData(BAL.BAL obj)
        {

            string qry = "insert into Employee values ('" + obj.Name + "','" + obj.Email + "','" + obj.Phone + "','" + obj.Age + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable ViewEmpl()
        {
            string s = "SELECT EmployeeId,Name,Email, Phone,Age FROM Employee";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int EmplUpdate(BAL.BAL obj)
        {
            string s = "update Employee set Name='" + obj.Name + "',Email='" + obj.Email + "',Phone='" + obj.Phone + "',Age=" + obj.Age + " where EmployeeId='" + obj.DID + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public int EmplDelete(BAL.BAL obj)
        {
            string qry = "Delete from Employee where EmployeeId = '" + obj.DID + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}