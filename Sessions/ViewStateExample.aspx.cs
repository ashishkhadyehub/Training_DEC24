using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class ViewStateExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (ViewState["Count"]==null)
                {
                    ViewState["Count"] = 0;
                }
                txtcount.Text = ViewState["Count"].ToString();  
            }
        }

        protected void btnclick_Click(object sender, EventArgs e)
        {
            int count = (int)ViewState["Count"] + 1;
            txtcount.Text = count.ToString();
            ViewState["Count"] = count;

        }
    }
}