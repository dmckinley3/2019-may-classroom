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

            myData aVariable = null;
            //if you use the new command with the class 
            //      the new command will physically create
            //      an instance of the class
            myData anInstance = new myData();

            if(aVariable ==  null)
            {
                Console.WriteLine("aVariable has nothing in it");
            }

            if(anInstance ==  null)
            {
                Console.WriteLine("anInstance has nothing in it");
            }
            Console.ReadLine();
        }//eom
    }//eoc

}//eon
