using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class GateClass
    {
        //auto implemented properties
        public double Height { get; set; }
        public double Width { get; set; }

        public double? Price { get; set; }

        //private string(storage area for data)
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

        //TODO: HOW DO I DO THIS METHOD. WHAT AM I PASSING IN, WHAT AM I RETURNING?
        //method
        public double EstimatedGate ()
        {

        }
    }
}
