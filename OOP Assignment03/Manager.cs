﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manger is managing");
        }
    }
}
