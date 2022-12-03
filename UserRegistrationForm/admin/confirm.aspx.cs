using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistrationForm.admin
{
    public partial class confirm : System.Web.UI.Page
    {
        User ba = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ba.UserView();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string LID = id.ToString();
            int i = ba.userApprove(LID);
            GridView1.EditIndex = -1;
            GridView1.DataSource = ba.UserView();
            GridView1.DataBind();
        }
    }
}