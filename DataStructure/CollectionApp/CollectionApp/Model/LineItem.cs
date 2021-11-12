using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        string _productName;
         double _price;
         int _qty;

        public LineItem(string productname,double price,int qty)
        {
            this._productName = productname;
            this._price = price;
            this._qty = qty;
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public int Quantity
        {
            get
            {
                return _qty;
            }
        }
        public double TotalPrice()
        {
            double totalPrice = _qty * _price;
            return totalPrice;
        }
    }

}
