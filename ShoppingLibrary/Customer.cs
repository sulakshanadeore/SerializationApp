using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    [Serializable]
    public class Customer
    {

        public int custid { get; set; }
        public string custname { get; set; }
        public string LoginID { get; set; }



        
        private string _password;

        private string LoginPassword
        {
            get { return _password; }
            set { _password = value; }
        }

    }
}
