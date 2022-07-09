using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool hasTrunk = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Rev up that engine, let's drive!\n");
        }
    }
}
