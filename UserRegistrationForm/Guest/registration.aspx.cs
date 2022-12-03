using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistrationForm.Guest
{
    public partial class registration : System.Web.UI.Page
    {
        User ba = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int UserStatus = 0;
            string qry = "insert into registration values('" + name.Text + "','" + phone.Text + "','" + email.Text + "','" + pass.Text + "','user','" + UserStatus + "')";
            //string qry1 = "insert into login values('" + name.Text + "','" + pass.Text + "','user','" + UserStatus + "','" + ob + "')";
            
            int i = ba.DataInsert(qry);
            // int n = ba.logInsert();
            if (i == 1)
            {
                
                Response.Write("<script language=javascript>alert('User Regestred Succesfully');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }
    }
}