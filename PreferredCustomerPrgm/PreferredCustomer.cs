using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreferredCustomerPrgm
{
    class PreferredCustomer : Customer
    {
        double _PurchaseAmount = 0;
        double _Discount;
        string _Order;

        public PreferredCustomer()
            : base()
        {
            PurchaseAmount = 0;
            Order = "";
        }

        public PreferredCustomer(string name, string address, string phoneNum, string custmrNum, double orderAmt)
            : base(name, address, phoneNum, custmrNum)
        {
            PurchaseAmount = orderAmt;
            Order = "";
        }

        public PreferredCustomer(string name, string address, string phoneNum, string custmrNum, double orderAmt, string order)
            : base(name, address, phoneNum, custmrNum, order)
        {
            PurchaseAmount = orderAmt;
            Order = order;
        }
        public double PurchaseAmount
        {
            get { return _PurchaseAmount; }
            set 
            { 
                _PurchaseAmount = value;

                if (_PurchaseAmount >= 500)
                    _Discount = .05;
                if (_PurchaseAmount >= 1000)
                    _Discount = .06;
                if (_PurchaseAmount >= 1500)
                    _Discount = .07;
                if (_PurchaseAmount >= 2000)
                    _Discount = .10;
            }
        }
        public double Discount
        {
            get { return _Discount; }
        }
        public string Order { get; set; }


    }
}
