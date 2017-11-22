using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project_411
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlazaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ShoppingPages/MainShoppingPage.aspx");
        }

        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ShoppingPages/ExitScreen.aspx");
        }
    }
}