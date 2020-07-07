using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_5
{
    class Magazine : Book // inherit book class
    {
        // Declaring Property
        public int IssueNumber { get; set; }
        
        public Magazine(string title) :base(title, "Magazine")
        {
            IssueNumber = 300;
        }

    }
}
