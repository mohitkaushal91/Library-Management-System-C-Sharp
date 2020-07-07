using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_5
{
    class Book : Media // inherit Media class
    {
        // Declaring Property
        public int PageCount { get; private set; }
        
        public Book(string title, string type):base(title,type)
        {
            PageCount = 300;
        }
    }
}
