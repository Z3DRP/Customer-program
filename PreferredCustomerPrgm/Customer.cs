using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreferredCustomerPrgm
{
    class Customer : Person
    {
        string _CustomerNumber;
        bool _OnMailList;
        string _Order;

        public Customer(string name, string address, string phoneNum, string custmerNum)
            : base(name, address, phoneNum)
        {
            CustomerNumber = custmerNum;
            OnMailList = false;
            Order = "";
        }
        public Customer(string name, string address, string phoneNum, string custmerNum, string order)
            :base(name, address, phoneNum)
        {
            CustomerNumber = custmerNum;
            OnMailList = false;
            Order = order;
        }
        public Customer(string name, string address, string phoneNum, string custmerNum, string order,bool mailme)
    : base(name, address, phoneNum)
        {
            CustomerNumber = custmerNum;
            OnMailList = false;
            Order = order;
            OnMailList = mailme;
        }
        public Customer()
            :base()
        {
            CustomerNumber = "";
            OnMailList = false;
            Order = Order;
        }

        public string CustomerNumber { get; set; }
        public bool OnMailList { get { return _OnMailList; } set { _OnMailList = value; } }
        public string Order { get; set; }
    }
}
