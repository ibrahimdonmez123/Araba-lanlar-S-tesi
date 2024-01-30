using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Araba_İlanları_Sİtesi.Classes;
using System.Data;

namespace Araba_İlanları_Sİtesi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 5;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand login = new SqlCommand("Select  * from TableUser where UserMail = @mail and UserPassword = @password", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            login.Parameters.AddWithValue("@mail"  , txt_Mail.Text );
            login.Parameters.AddWithValue("@password", txt_Password.Text);

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(login);

            da.Fill(dt);

            if(dt.Rows.Count>0)
            {
                if (txt_Mail.Text == "donmez2k@gmail.com") 
                {
                    Session["IsUserAdmin"] = true;
                    Session["UserMail"] = "donmez2k@gmail.com";

                    Response.Redirect("AdminMesajlar.aspx");
                }
                else
                {
                    Session["IsUserOnline"] = true;
                    Session["UserMail"] = dt.Rows[0].ToString();
                    Response.Redirect("ListCars.aspx");

                }
            }
            else
            {
                Response.Write("Mail veya şifre hatalı");
            }



        }
    }
}