using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiLabelFormats.Classes
{
    public partial class clsLabelField
    {
        // <name>Quantity</name>
        //<code>Q0</code>
        //<defaultselected>true</defaultselected>
        //<index>2</index>

        public string Name { get; set; }

        public string Code { get; set; }

        public bool defaultSelected { get; set; }

        public int ID { get; set; }
    }
}
