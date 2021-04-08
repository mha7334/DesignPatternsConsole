using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole.Builder
{
    public class Report
    {
        public string Type { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Content { get; set; }

        public void Display()
        {
            Console.WriteLine("Report Type : " + Type);
            Console.WriteLine("Header : " + Header);
            Console.WriteLine("Cotent : " + Content);
            Console.WriteLine("Footer : " + Footer);
        }

    }
}
