using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace UserRegistrationForm.UserSide
{
    public partial class profile : System.Web.UI.Page
    {
        string strConnString = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
        string str;
        SqlCommand com;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            str = "select name,phone,email from registration where name='" + Session["name"] + "'";
            com = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lbl_UserName.Text = ds.Tables[0].Rows[0]["name"].ToString();
            lbl_email.Text = ds.Tables[0].Rows[0]["phone"].ToString();
            lbl_phone.Text = ds.Tables[0].Rows[0]["email"].ToString();
        }


    }
}