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
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand commandlistBrands = new SqlCommand("Select * from TableBrand", SqlConnectionClass.connection);
                SqlConnectionClass.CheckConnection();
                SqlDataReader dr = commandlistBrands.ExecuteReader();

                Combobox.DataTextField = "BrandName";
                Combobox.DataValueField = "BrandID";
                Combobox.DataSource = dr;
                Combobox.DataBind();
                dr.Close();
            }


        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            SqlCommand commondAdd = new SqlCommand("insert into TableCar (CarModel,CarBrandID,CarFuelType,CarDescription,CarContact,CarSeller,CarPhoto,CarPrice) values (@pmodel,@pbrand,@pfuel,@pdes,@pcontact,@pseller,@pphoto,@pprice)", SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commondAdd.Parameters.AddWithValue("@pmodel", txt_CarModel.Text);
            commondAdd.Parameters.AddWithValue("@pbrand", Convert.ToInt32(Combobox.SelectedValue));
            commondAdd.Parameters.AddWithValue("@pfuel", txt_CarFuelType.Text);
            commondAdd.Parameters.AddWithValue("@pdes", txt_CarDescription.Text);
            commondAdd.Parameters.AddWithValue("@pcontact", txt_CarContactNumber.Text);
            commondAdd.Parameters.AddWithValue("@pseller", txt_CarSeller.Text);
            commondAdd.Parameters.AddWithValue("@pphoto", txt_CarContactNumber.Text);
            commondAdd.Parameters.AddWithValue("@pprice", txt_CarPrice.Text);

            commondAdd.ExecuteNonQuery();


        }
    }
}