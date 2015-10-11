using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account
    {
        
        public Account()
        {
            Pin = new Random().Next(1000, 9999);
            AccountNumber = new Random().Next(1000, 9999);
        }
        public int AccountNumber
        {
            get;
            
        }

        public int Pin
        {
            get;
        
        }

       
    }
}
