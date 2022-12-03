using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistrationForm.Guest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       User ba = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string UserName = user.Text;
            string PassWord = pass.Text;
            DataTable dt = ba.logcheck(UserName, PassWord);
            if (dt.Rows.Count > 0)
            {
                object id=dt.Rows[0][0].ToString().Trim();
                Session["UID"] = dt.Rows[0][0].ToString().Trim();
                Session["name"] = dt.Rows[0][1].ToString().Trim();


                if (dt.Rows[0][5].ToString().Trim() == "admin" && dt.Rows[0][6].ToString().Trim()=="1")
                {

                    Response.Write("<script language=javascript>alert('Admin');</script>");
                    //Response.Write(name);
                   Response.Redirect("../admin/confirm.aspx");
                }
                else if (dt.Rows[0][5].ToString().Trim() == "user" && dt.Rows[0][6].ToString().Trim() == "1")
                        {
                    Response.Write("<script language=javascript>alert('User');</script>");
                    //Response.Write(name);
                    Response.Redirect("../UserSide/profile.aspx");
                }
                else if(dt.Rows[0][6].ToString().Trim() == "0")
                {
                    Response.Write("<script language=javascript>alert('Wait For Admin Approval');</script>");
                }
               else
                {
                    Response.Write("<script language=javascript>alert('Check Username or Password');</script>");
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }
    }
}