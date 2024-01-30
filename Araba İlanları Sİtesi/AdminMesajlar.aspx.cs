using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Araba_İlanları_Sİtesi.Classes;
using System.Web.WebSockets;

namespace Araba_İlanları_Sİtesi
{
    public partial class AdminMesajlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserAdmin"]) == true)
            {
                SqlCommand listmessages = new SqlCommand("Select * from TableContact", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();

                SqlDataReader dr = listmessages.ExecuteReader();

                DataList1.DataSource = dr;

                DataList1.DataBind();
                dr.Close();
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}