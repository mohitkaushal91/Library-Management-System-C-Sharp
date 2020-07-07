using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_5
{
   
    class Movie: Media // Inherit Media Class
    {
        // Declaring Property
        public int RunTime { get; set; }

        public Movie(string title):base(title, "Movie")
        {
            RunTime = 3;
        }
    }
}
