using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarinProject
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string ISBN { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return "Title: " + title + " Author: " + author + " ISBN: " + ISBN + " Status: " + status;
        }
    }

}
