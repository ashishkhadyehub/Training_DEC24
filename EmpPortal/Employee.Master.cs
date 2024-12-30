using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpPortal
{
    public partial class Employee : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"]!=null)
            {
                lilogout.Visible = true;
                lilogin.Visible = false;
                liregister.Visible = false;
            }
            else
            {
                lilogout.Visible = false;
                lilogin.Visible = true;
                liregister.Visible = true;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Index.aspx");
        }
    }
}