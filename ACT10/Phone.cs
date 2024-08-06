using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT10
{
    internal class Phone : Product
    {
        public string PhoneType { get; set; }
        public string AddType()
        {
            string newType = "Tel+efono.";
            return newType;
        }

        public Phone(string phoneType)
        {
            PhoneType = phoneType;
        }
    }

}
