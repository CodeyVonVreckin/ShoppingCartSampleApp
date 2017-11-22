using Final_Project_411.Controller;
using Final_Project_411.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project_411.ShoppingPages
{
    public partial class MainShoppingPage : System.Web.UI.Page
    {
        List<CartObject> cart = new List<CartObject>();
        List<Product> allProducts = new List<Product>();
        List<Product> bookList = new List<Product>();
        List<Product> dvdList = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildProducts bp = new BuildProducts();
            allProducts = (List<Product>)Session["AllProducts"];
         
            if (!IsPostBack)
            {               
                foreach (var i in allProducts)
                {
                    if (i.ProductType == "Book")
                    {
                        BooksDropDown.Items.Add(i.Title);
                        BooksDropDown.SelectedIndex = 0;
                        bookList.Add(i);
                        int selectedBook = BooksDropDown.SelectedIndex;
                        BookPriceValueLabel.Text = bookList[selectedBook].Price.ToString("c");
                    }
                    else
                    {
                        DvdDropDown.Items.Add(i.Title);
                        DvdDropDown.SelectedIndex = 0;
                        dvdList.Add(i);
                        int selectedDvd = DvdDropDown.SelectedIndex;
                        DVDPriceValueLabel.Text = dvdList[selectedDvd].Price.ToString("c");
                    }
                }                 
            }
        }

        //Exit Button
        protected void ExitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitScreen.aspx");
        }
        // adds products to the cart list
        protected void AddButton_Click(object sender, EventArgs e)
        {
            string bookQuantity = BookQuantityTB.Text;
            string dvdQuantity = DvdQuantityTB.Text;
            Product selectedBook = allProducts[BooksDropDown.SelectedIndex];
            Product selectedDvd = allProducts[DvdDropDown.SelectedIndex + 5];

            MessageLabel.Text = "";

            if(Session["CartObjs"] == null)
            {
                if(bookQuantity != "" && dvdQuantity == "")
                {
                    CartObject book = new CartObject(int.Parse(bookQuantity), selectedBook);
                    cart.Add(book);
                    HttpContext.Current.Session["CartObjs"] = cart;
                    Label.Text = bookQuantity + " Orders of " + selectedBook.Title + " were added!";
                }
                else if(dvdQuantity != "" && bookQuantity == "")
                {
                    CartObject dvd = new CartObject(int.Parse(dvdQuantity), selectedDvd);
                    cart.Add(dvd);
                    HttpContext.Current.Session["CartObjs"] = cart;
                    Label.Text =  dvdQuantity + " Orders of " + selectedDvd.Title + " were added!";
                }
                else if( dvdQuantity  != "" && bookQuantity != "")
                {
                    CartObject book = new CartObject(int.Parse(bookQuantity), selectedBook);
                    CartObject dvd = new CartObject(int.Parse(dvdQuantity), selectedDvd);
                    cart.Add(book);
                    cart.Add(dvd);
                    HttpContext.Current.Session["CartObjs"] = cart;
                    Label.Text = bookQuantity + " Orders of " + selectedBook.Title + " & " + dvdQuantity + " Orders  of " + selectedDvd.Title + " were added!";
                }
                else
                {
                    MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
                }
            }
            else
            {
                if (bookQuantity != "" && dvdQuantity == "")
                {
                    ChangeCart(int.Parse(bookQuantity), selectedBook);
                    Label.Text = bookQuantity + " Orders of " + selectedBook.Title + " were added!";
                }
                else if (dvdQuantity != "" && bookQuantity == "")
                {
                    ChangeCart(int.Parse(dvdQuantity), selectedDvd);
                    Label.Text =  dvdQuantity + " Orders of " + selectedDvd.Title + " were added!";
                }
                else if (dvdQuantity != "" && bookQuantity != "")
                {
                    ChangeCart(int.Parse(bookQuantity), selectedBook);
                    ChangeCart(int.Parse(dvdQuantity), selectedDvd);
                    Label.Text = bookQuantity + " Orders of " + selectedBook.Title + " & " +  dvdQuantity + " Orders  of " + selectedDvd.Title + " were added!";
                }
                else
                {
                    MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
                }
            }
        
        }
        // allows you to add new items to the lsit every time you click the add button
        // instead of it creating a new list every time you click add
        public void ChangeCart (int quant, Product prod)
        {
            CartObject newItem = new CartObject(quant, prod);
            List<CartObject> newList =new List<CartObject>();
            newList = (List<CartObject>)Session["CartObjs"];
            newList.Add(newItem);
            HttpContext.Current.Session["CartObjs"] = newList;
        }

        // changes the book price label when the index changes
        protected void BooksDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int book = BooksDropDown.SelectedIndex;
            BookPriceValueLabel.Text = allProducts[book].Price.ToString("C");
        }

        // changes the dvd price label when the index changes
        protected void DvdDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dvd = DvdDropDown.SelectedIndex;
            DVDPriceValueLabel.Text = allProducts[dvd + 5].Price.ToString("C");
        }

        // there has to be at least 1 item in the cart before you can checkout
        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["CartObjs"] == null)// if no items have been added to the session
            {
                MessageLabel.Text = "One of the quantities must be more than 0. Otherwise Please Click Exit.";
            }
            else
                Response.Redirect("CheckoutScreen.aspx");
        }
    }
}