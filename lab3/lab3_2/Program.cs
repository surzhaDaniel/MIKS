using System;
using System.Collections.Generic;

namespace lab3_2
{
    // Main program class.
    class Program
    {
        // Entry point of the program.
        static void Main(string[] args)
        {
            // Creating a client instance.
            Client client = new Client();

            // Creating a composite cabinet with four boxes.
            Cabinet cabinet = new Cabinet();
            Box box1 = new Box(20, 30);
            Box box2 = new Box(20, 30);
            Box box3 = new Box(20, 30);
            Box box4 = new Box(20, 30);
            cabinet.Add(box1);
            cabinet.Add(box2);
            cabinet.Add(box3);
            cabinet.Add(box4);

            // Printing the cost of the cabinet.
            Console.Write("The cost of the cabinet, which consists of 4 boxes -> \t\t\t\t\t\t");
            client.PrintCost(cabinet);

            // Creating a composite shelf with three boxes, including one with a higher cost.
            Shelf shelf = new Shelf();
            Box box5 = new Box(50, 80);
            Cabinet cabinet1 = cabinet;
            shelf.Add(box5);
            shelf.Add(cabinet1);

            // Printing the cost of the shelf.
            Console.Write("The cost of the shelf, which consists of 1 box and one cabinet (which consists of 4 boxes) -> \t");
            client.PrintCost(shelf);

            // Creating an overall composite with both the cabinet and the shelf.
            Cabinet overallCabinet = new Cabinet();
            overallCabinet.Add(cabinet);
            overallCabinet.Add(shelf);

            // Printing the cost of the overall cabinet.
            Console.Write("The cost of the overall composite with both the cabinet and the shelf -> \t\t\t");
            client.PrintCost(overallCabinet);
        }
    }
}