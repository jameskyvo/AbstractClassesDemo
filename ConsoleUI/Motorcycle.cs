using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool hasSidePouch = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("Put on your helmet, it's time to ride!\n");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("It's like riding a bike!");
        }
    }
}
