using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Register : System.Web.UI.Page
    {
        //steps:
        //1. Create database table
        //2. Create UI/ form
        //3. Apply required validations
        //4. Set up connection string in web.config
        //5. Create connection class on back end file
        //6. Write ado.net code to store data

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("insert into DBUsers values (@name,@contact,@email,@city,@dt)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCity.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = string.Empty;
            ddlCity.SelectedIndex = 0;
            Response.Write("<script>alert('Data saved..!')</script>");
        }
    }
}