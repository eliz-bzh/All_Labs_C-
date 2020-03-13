using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsC_
{
    class MailAdressComparer : IComparer<MailAdress>
    {
        public int Compare(MailAdress x, MailAdress y)
        {
            return x.House - y.House;
        }
    }
}
