using Final_Project_411.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project_411.ShoppingPages
{
    public partial class CheckoutScreen : System.Web.UI.Page
    {
        List<CartObject> cartObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack == true)
            {
                cartObj = (List<CartObject>)Session["CartObjs"];
                
                foreach ( var i in cartObj)
                {
                    ListBox.Items.Add(string.Format("{0}-{1}", i.Obj.Title, i.Obj.Price.ToString("C")));
                }
                QuantityTB.Enabled = false;
            }                 

        }

        protected void AcceptChangeButton_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            QuantityTB.Enabled = true;
            int selectedItem = ListBox.SelectedIndex;
            if (QuantityTB.Text == "0")
            {

                var removedItem = ListBox.SelectedItem;
                ListBox.Items.Remove(removedItem.ToString());
                cartObj.Remove(cartObj[selectedItem]);
                HttpContext.Current.Session["CartObjs"] = cartObj;
            }
            else
            {
                cartObj[selectedItem].Quantity = int.Parse(QuantityTB.Text);

                HttpContext.Current.Session["CartObjs"] = cartObj;
            }
        }

        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitScreen.aspx");
        }

        protected void PayButton_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            Product prod = new Product();          
            double Price = 0;
            int count = 0;
            double totalPrice;

           foreach( var i in cartObj)
            {                
                Price += i.Obj.Price *i.Quantity;
                count += i.Quantity;
            }

            var discount = prod.discountPercentage(count);
            totalPrice = Price - (Price * discount);

            TotalLabel.Text = "Total amount to pay is " + totalPrice.ToString("c") + ". You got a discount of " + discount.ToString("c");
           
        }

        protected void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["CartObjs"];
            QuantityTB.Enabled = true;            
            int selectedItem = ListBox.SelectedIndex;

            QuantityTB.Text = cartObj[selectedItem].Quantity.ToString();
           
        }
    }
}