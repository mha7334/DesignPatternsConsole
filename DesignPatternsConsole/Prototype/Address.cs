using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Prototype
{
    public class Address
    {
        public string address { get; set; }

        public Address GetClone()
        {
            return (Address) this.MemberwiseClone();
        }
    }
}
