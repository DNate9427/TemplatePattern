﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Standard
{
    internal class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }
    }
}
