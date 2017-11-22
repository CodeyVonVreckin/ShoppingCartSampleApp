using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project_411.Controller
{
    public class Product
    {
        private string _productType;
        private int _productId;
        private string _titles;
        private double _price;

        public string ProductType
        {
            get
            {
                return _productType;
            }
            set
            {
                _productType = value;
            }
        }
        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
            }
        }
        public string Title
        {
            get
            {
                return _titles;
            }
            set
            {
                _titles = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public double discountPercentage(int quantity)
        {
            double discount;

            if (quantity < 2)
            {
                discount = 0.0;
               
            }
            else if (quantity == 2 || quantity == 3 || quantity == 4)
            {
                discount = 0.02;
                
            }
            else
            {
                discount = 0.05;

            }

            return discount;
        }

    }
}