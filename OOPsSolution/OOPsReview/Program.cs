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

        //greedy constructor
            FencePanel anGInstance = new FencePanel(4.0,6.8,"private", 32.89);
            Console.WriteLine("height is: " + anGInstance.Height.ToString());
            Console.WriteLine("Width is: " + anGInstance.Width.ToString());
            Console.WriteLine("Style is: " + anGInstance.Style.ToString());
            Console.WriteLine("price is:" + anGInstance.Price.ToString() + "\n");

            //using instances of classes
            string menuItem = "0";
            FenceEstimate CustomerFence = new FenceEstimate();
            //place data from right side into left side
         
            CustomerFence.Fence = anGInstance;
            CustomerFence.Gates = null;
            string inputValue;
            GateClass theGate = null;
            do
            {
                theGate = new GateClass();
                Console.WriteLine("Height: ");
                inputValue = Console.ReadLine();
                theGate.Height = double.Parse(inputValue);

                theGate = new GateClass();
                Console.WriteLine("Width: ");
                inputValue = Console.ReadLine();
                theGate.Width = double.Parse(inputValue);

                theGate = new GateClass();
                Console.WriteLine("style: ");
                inputValue = Console.ReadLine();
                theGate.Style = inputValue;

                theGate = new GateClass();
                Console.WriteLine("Price: ");
                inputValue = Console.ReadLine();
                if (string.IsNullOrEmpty(inputValue))
                {
                    theGate.Price = null;
                }
                else
                {
                    theGate.Height = double.Parse(inputValue);
                }
                //The local instance of gate needs to be saved
                //      into the Fence Estimate
                CustomerFence.Gates.Add(theGate);
                Console.WriteLine("Another gate (Y or N): ");
                inputValue = Console.ReadLine();
                //                 conditions          true value : false value
                menuItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";




            }
            while (menuItem != "0");

            Console.WriteLine("Fence Length: ");
            inputValue = Console.ReadLine();
            double linearLength = double.Parse(inputValue);
            //using the CustomerFence data calculate the cost
            double numberOfPanels = CustomerFence.Fence.EstimatedNumberOfPanels(linearLength);
            double FencePrice = numberOfPanels * Math.Ceiling(numberOfPanels) * double.Parse(CustomerFence.Fence.Price.ToString());

            double gateCost = 0.0;
            foreach (GateClass item in CustomerFence.Gates)
            {
                gateCost += double.Parse(item.Price.ToString());
            }

            Console.WriteLine("Total Fence Estimate");
            Console.WriteLine("Number of panels: " + numberOfPanels.ToString());
            Console.WriteLine("Cost Of Panels: " + FencePrice);
            Console.WriteLine("Number Of Gates: " + CustomerFence.Gates.Count);
            Console.WriteLine("Cost Of Gates: " + gateCost.ToString());
            Console.WriteLine("Total: " + (FencePrice + gateCost).ToString());

            Console.ReadLine();
        }//eom
    }//eoc

}//eon
