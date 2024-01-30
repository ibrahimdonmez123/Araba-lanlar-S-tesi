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
    public partial class AdminConfirmCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserAdmin"]) == true)
            {
                SqlCommand commandlist = new SqlCommand("Select * from TableCar where CarConfirmation=@pcon", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();

                commandlist.Parameters.AddWithValue("@pcon", false);

                SqlDataReader dr = commandlist.ExecuteReader();

                DataList1.DataSource = dr;

                DataList1.DataBind();

                dr.Close();
            }

            else
            {
                Response.Redirect("Login.aspx");
            }

        }

       
    }
}