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
    public partial class ContactPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmesajigonder_Click(object sender, EventArgs e)
        {
            SqlCommand commandadd = new SqlCommand("Insert into TableContact  (ContactMessage , ContactMail , ContactName) values (@pmsg , @pmail , @pname)" , SqlConnectionClass.connection);
            SqlConnectionClass.CheckConnection();
            commandadd.Parameters.AddWithValue("@pmsg", txt_name.Text);
            commandadd.Parameters.AddWithValue("@pmail", txtMail.Text);
            commandadd.Parameters.AddWithValue("@pname", txtMesaj.Text);

            commandadd.ExecuteNonQuery();

        }
    }
}