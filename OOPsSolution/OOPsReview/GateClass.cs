using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
   public class GateClass
    {
        //auto implemented properties
        public double Height { get; set; }
        public double Width { get; set; }
        public double? Price { get; set; }

        //storage area for data
        private string _style;

        //fully implemented property
        public string Style
        {
            get
            {
                return _style;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _style = null;
                }
                else
                {
                    _style = value;
                }

            }
        }



        //constructors

        //default
        public GateClass()
            {

            }

        //greedy
        public GateClass(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

     //Read-only Property
     //Contains NO set{}
     //data used in this property is data that is currently
     //     within the instance of this class
     public double GateArea
        {
            get
            {
                return Height * Width;
            }
        }

    }
}
