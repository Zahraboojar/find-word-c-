using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person2
{
    internal class DvgDisplayNameAttribute : Attribute
    {
        public string DisplayName { get; set; }
        public DvgDisplayNameAttribute(string displayName = "header")
        {
            DisplayName = displayName;
        }
    }
}
