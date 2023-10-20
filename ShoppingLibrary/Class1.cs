using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    //class has given the permission that its object can be written to  a file.
    [Serializable()]
    public class Orders
    {
        public int Custid { get; set; }

        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }

        private int _qty;

        public int Quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private  int _price;

        public  int Price
        {
            get { return _price; }
            set { _price = value; }
        }


        [NonSerialized]
        private long _debitcardNo;
        public long DebitCardNo
        {
            get { return _debitcardNo; }
            set { _debitcardNo = value; }
       }






    }
}
