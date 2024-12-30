using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpPortal
{
    public partial class Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["EmpId"]!=null)
            {
                if(!IsPostBack)
                {
                    GetData();
                }
                
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void GetData()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from EmpRegister where Srno=@empid",con);
            cmd.Parameters.AddWithValue("@empid", Session["EmpId"]);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();    
            if(sdr.HasRows)
            {
                sdr.Read();
                txtName.Text=sdr.GetValue(1).ToString();
                txtEmail.Text=sdr.GetValue(2).ToString();
                txtContact.Text=sdr.GetValue(3).ToString();
                txtdept.Text=sdr.GetValue(4).ToString();    
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("update Empregister set Name=@name,Email=@email,Contact=@contact where Srno=@empid",con);
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.Parameters.AddWithValue("@email",txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact",txtContact.Text);
            cmd.Parameters.AddWithValue("@empid", Session["EmpId"]);
            con.Open();
            cmd.ExecuteNonQuery();
            GetData();

        }
    }
}