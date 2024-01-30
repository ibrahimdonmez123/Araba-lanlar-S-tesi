using Araba_İlanları_Sİtesi.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Araba_İlanları_Sİtesi
{
    public partial class Kayitol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            SqlCommand register = new SqlCommand("insert into TableUser (UserMail , UserPassword) values (@pmail , @ppassword)" , SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            register.Parameters.AddWithValue("@pmail" , txt_mail.Text);
            register.Parameters.AddWithValue("@ppassword", txt_password.Text);

            register.ExecuteNonQuery();

        }
    }
}