using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Model
{
    public class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;
        private double _discountAmount;
        private double _taxAmount;
        private double _finalAmount;

        public Invoice(int id,string description,double amount,float tax,float discount)
        {
            this._id = id;
            this._description = description;
            this._amount = amount;
            this._tax = tax;
            this._discount = discount;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public String Description
        {
            get
            {
                return _description;
            }
        }
        public double Amount
        {
            get
            {
                return _amount;
            }
        }
        public float Tax
        {
            get
            {
                return _tax;
            }
        }
        public float Discount
        {
            get
            {
                return _discount;
            }
        }
        public double CalculateDiscount()
        {
            _discountAmount = (float)(_amount*_discount / 100);
            return _discountAmount;
        }
        public double CalculateTax()
        {
            _taxAmount =(float)(_amount * _tax) / 100;
            return _taxAmount;
        }
        public double CalculateFinalAmount()
        {
            _finalAmount = (float)_amount-_discountAmount + _taxAmount;
            return _finalAmount;
        }
       
    }
}
