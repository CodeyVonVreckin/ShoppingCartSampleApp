using Final_Project_411.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project_411.Model
{
    public class BuildProducts
    {
        List<Product> prod = new List<Product>();

        public BuildProducts()
        {
            //Books
            Product b1 = new Product();
            b1.ProductType = "Book";
            b1.ProductId = 101;
            b1.Title = "Big Data: A Revolution That Will Transform How We Live, Work, and Think";
            b1.Price = 50.55;

            Product b2 = new Product();
            b2.ProductType = "Book";
            b2.ProductId =102;
            b2.Title = "Disruptive Possibilities: How Big Data Changes Everything";
            b2.Price = 65.67;


            Product b3 = new Product();
            b3.ProductType = "Book";
            b3.ProductId = 103;
            b3.Title = "Data Smart: Using Data Science to Transform Information into Insight";
            b3.Price = 32.78;


            Product b4 = new Product();
            b4.ProductType = "Book";
            b4.ProductId = 104;
            b4.Title = "Big Data: Principles and best practices of scalable realtime data systems";
            b4.Price = 90.65;

            Product b5 = new Product();
            b5.ProductType = "Book";
            b5.ProductId = 105;
            b5.Title = "Big Data Science & Analytics: A Hands-On Approach";
            b5.Price = 15.25;

            // DVDs
            Product d1 = new Product();
            d1.ProductType = "DVD";
            d1.ProductId = 201;
            d1.Title = "The Grand Tour Season 1";
            d1.Price = 10.00;

            Product d2 = new Product();
            d2.ProductType = "DVD";
            d2.ProductId = 202;
            d2.Title = "Spectre";
            d2.Price = 11.99;

            Product d3 = new Product();
            d3.ProductType = "DVD";
            d3.ProductId = 203;
            d3.Title = "Goliath Season 1";
            d3.Price = 12.99;


            Product d4 = new Product();
            d4.ProductType = "DVD";
            d4.ProductId = 204;
            d4.Title = "The Hunger Games: Mockingjay Part 2";
            d4.Price = 10.99;

            Product d5 = new Product();
            d5.ProductType = "DVD";
            d5.ProductId = 205;
            d5.Title = "Good Girls Revolt";
            d5.Price = 11.99;

            //Add Products to the List
            prod.Add(b1);
            prod.Add(b2);
            prod.Add(b3);
            prod.Add(b4);
            prod.Add(b5);
            prod.Add(d1);
            prod.Add(d2);
            prod.Add(d3);
            prod.Add(d4);
            prod.Add(d5);

            //need to add the list to the Session
            HttpContext.Current.Session["AllProducts"] = prod;
        }
    }
}