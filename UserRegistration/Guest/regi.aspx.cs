using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistration.Guest
{
    public partial class regi : System.Web.UI.Page
    {
        User ba = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string sql = "insert into employee values('" + txtname.Text + "','" + txtdesignation.Text + "','" + txtsalary.Text + "')";
            int i = db.exenonquery(sql);
            // int n = ba.logInsert();
            if (i == 1)
            {
                Response.Write("<script language=javascript>alert('SUCESS');</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('ERROR');</script>");
            }
        }
    }
}