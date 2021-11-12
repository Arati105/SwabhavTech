using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Model
{
    class Product
    {
        private int _id;
        private String _name;
        private double _price;
        private double _discount;
        private static int _instanceCount;

        static Product()
        {
            _instanceCount = 0;
            Console.WriteLine("Static Constructor");
        }

        public Product(int id,string name,double price)
        {
            Console.WriteLine("Constructor 1");
            this._id = id;
            this._name = name;
            this._price = price;
           
            _instanceCount += 1;
        }
        public Product(int id,string name,double price,double discount)
        {
            Console.WriteLine("Constructor 2");
            this._id = id;
            this._name = name;
            this._price = price;
            this._discount = discount;
            _instanceCount += 1;
        }
        

        public int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }  
        }
        public String Name
        {
            get
            {
                return _name;
            }
        }
        public Double Price
        {
            get
            {
                return _price;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
        }
       public static int Occurances
        {
            
            get
            {
                return _instanceCount;
            }
        }
        public double CalculatePrice()
        {
            return _price -=((_price * _discount)/100);
        }
        
    }
}
