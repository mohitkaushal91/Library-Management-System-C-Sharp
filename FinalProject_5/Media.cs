using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_5
{
    // abstract class
    abstract class Media
    {
        // Declaring properties
        public string Title { get; set; }

        public string Type { get; set; }

        public int SerialNum { get; set; }

        public int LentNum { get; set; }

        public bool isAvailable { get; set; }

        public string BorrowerName { get; set; }

        // Constructor
        public Media(string title, string type)
        {
            Title = title;
            Type = type;
            isAvailable = true;
            BorrowerName = "";
            LentNum = 0;
            SerialNum = 110;
        }
    }
}
