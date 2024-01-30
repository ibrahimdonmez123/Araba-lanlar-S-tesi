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
    public partial class CarOnayla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int selectedid = Convert.ToInt32(Request.QueryString["carid"]);
            SqlCommand caronayla = new SqlCommand("Update TableCar set CarConfirmation=@pcon where CarID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            caronayla.Parameters.AddWithValue("@pcon" , true);
            caronayla.Parameters.AddWithValue("@pid", selectedid);

            caronayla.ExecuteNonQuery();

            Response.Redirect("AdminConfirmCars.aspx");
        }
    }
}