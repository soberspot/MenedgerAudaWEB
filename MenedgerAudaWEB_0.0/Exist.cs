using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenedgerAudaWEB_0._0
{
    class Exist
    {

        public void ЗапросЦены(string кодДетали )
        {
           System.Diagnostics.Process.Start("http://exist.ru/price.aspx?pcode=" + кодДетали);
        }
        
    }


}
