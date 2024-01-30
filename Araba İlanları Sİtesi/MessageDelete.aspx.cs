using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Araba_İlanları_Sİtesi.Classes;

namespace Araba_İlanları_Sİtesi
{
    public partial class MessageDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int selectedid = Convert.ToInt32(Request.QueryString["id"]);

            SqlCommand messagedelete = new SqlCommand("Delete from TableContact where ContactID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            messagedelete.Parameters.AddWithValue("@pid" , selectedid);

            messagedelete.ExecuteNonQuery();

            Response.Redirect("AdminMesajlar.aspx");
        }
    }
}