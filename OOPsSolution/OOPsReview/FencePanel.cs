﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //the default access permissions is private
    //if an outside user of this class wanted 
    //      access to the class contents then
    //      the access permissions needs to be public
    //if this class was static the class would not
    //      hold data
    //For a class to hold data, DO NOT make it static
    //      unless you want everyone to have access 
    //      to that data(Read and Change)
    public class FencePanel
    {
        public int Height;
        public int Width;


    }
}