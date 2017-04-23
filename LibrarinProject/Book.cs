﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//just to hold book object
namespace LibrarinProject
{
 
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string ISBN { get; set; }
        public string status { get; set; }

        public override string ToString() //overriden to string so that the list view calls this
        {
            return "Title: " + title + " Author: " + author + " ISBN: " + ISBN + " Status: " + status;
        }
    }

}
