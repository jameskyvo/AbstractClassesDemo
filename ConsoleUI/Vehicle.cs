using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string year = "Unknown";
        public string make = "Unknown";
        public string model = "Unknown";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("And we're off to the races!\n");
        }
    }
}
