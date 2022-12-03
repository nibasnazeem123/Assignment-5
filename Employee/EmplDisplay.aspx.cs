using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class EmplDisplay : System.Web.UI.Page
    {
        BAL.BAL obj = new BAL.BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = obj.ViewData();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = obj.ViewData();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("txt_Name") as TextBox;
            TextBox email = GridView1.Rows[e.RowIndex].FindControl("txt_email") as TextBox;
            TextBox phone = GridView1.Rows[e.RowIndex].FindControl("txt_phone") as TextBox;
            TextBox age = GridView1.Rows[e.RowIndex].FindControl("txt_age") as TextBox;
           


            

            obj.DID = Convert.ToInt32(id.Text);
            obj.Name = name.Text;
            obj.Email = email.Text;
            obj.Phone = phone.Text;
            obj.Age = age.Text;
            obj.UpdateEmpl();
            GridView1.EditIndex = -1;




            GridView1.DataSource = obj.ViewData();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label Id = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            obj.DID = Convert.ToInt32(Id.Text);
            int i = obj.DeleteEmpl();
            GridView1.DataSource = obj.ViewData();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = obj.ViewData();
            GridView1.DataBind();
        }
    }
}