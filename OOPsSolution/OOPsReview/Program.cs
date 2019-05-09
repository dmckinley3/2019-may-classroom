using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console is a reference to a system static class
            //static classes are used by typing the class name
            //static classes do not store variable data
            //static classes are used by everyone

            //methods of a static class will be placed after
            //the object dot operator

            Console.WriteLine("Hello World");

            //create an instance of a non-static class
            //If you create a declareative using JUST the 
            //      class name then this is only a pointer
            //      that can hold an instance of the class
            //      specified
            //current value of aVariable is null

            FencePanel aVariable = null;
            //if you use the new command with the class 
            //      the new command will physically create
            //      an instance of the class

            //when this statement is executed, the default 
            //      constructor of the FencePanel class will be called on
            //      your behalf
            FencePanel anInstance = new FencePanel();
            anInstance.Height = 5.8;
            anInstance.Width = 8.0;
            anInstance.Style = "Neighbor Friendly";

            Console.WriteLine("height is: " + anInstance.Height.ToString());
            Console.WriteLine("Width is: " + anInstance.Width.ToString());
            Console.WriteLine("Style is: " + anInstance.Style.ToString());
            Console.WriteLine("price is:" + anInstance.Price.ToString() + "\n");

        
            FencePanel anGInstance = new FencePanel(4.0,6.8,"private", 32.89);
            Console.WriteLine("height is: " + anGInstance.Height.ToString());
            Console.WriteLine("Width is: " + anGInstance.Width.ToString());
            Console.WriteLine("Style is: " + anGInstance.Style.ToString());
            Console.WriteLine("price is:" + anGInstance.Price.ToString() + "\n");

            Console.ReadLine();
        }//eom
    }//eoc

}//eon
