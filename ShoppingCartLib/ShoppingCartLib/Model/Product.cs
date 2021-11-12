﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCartLib.Model
{
   public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discount;

        public Product(int id,string name,double price,float discount)
        {
            this._id = id;
            this._name = name;
            this._price = price;
            this._discount = discount;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float Discount
        {
            get
            {
                return _discount;
            }
        }
    }

   
}
    

