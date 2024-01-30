using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.WebSockets;
using Araba_İlanları_Sİtesi.Classes;

namespace Araba_İlanları_Sİtesi
{
    public partial class ListCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["IsUserOnline"]) == true)
            {
                if(Page.IsPostBack == false)
                {
                    SqlCommand commandlist = new SqlCommand("Select CarID , CarModel , CarBrandID , CarFueltype , CarDescription , CarContact , CarSeller , CarPhoto , CarPrice ,  CarConfirmation  , BrandID , BrandName from TableCar inner join TableBrand on TableCar.CarBrandID = TableBrand.BrandID where CarConfirmation=@pcon", SqlConnectionClass.connection);
                    SqlConnectionClass.CheckConnection();

                    commandlist.Parameters.AddWithValue("@pcon", true);

                    SqlDataReader dr = commandlist.ExecuteReader();

                    DataList1.DataSource = dr;

                    DataList1.DataBind();

                    dr.Close();
                }

            }
            else
            {
                Response.Redirect("Login.aspx");
            }


        }
    }
}