using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserRegistrationForm
{
    public class User
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public User()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        private string name;
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
        public SqlConnection GetCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public DataTable UserView()
        {
            string s = "select UID,name from registration where status='0'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int userApprove(string LID)
        {
            string s = "Update registration set status = 1 where UID =" + LID;
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        public int DataInsert(string qry)
        {
            GetCon();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = qry;//quey is sql
            int i = cmd.ExecuteNonQuery();
            return i;

        }

        public DataTable logcheck(string uname,string pwd)
        {
            string qry = "SELECT * FROM registration WHERE name='" + uname + "'AND upass='" + pwd + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }

    }
}