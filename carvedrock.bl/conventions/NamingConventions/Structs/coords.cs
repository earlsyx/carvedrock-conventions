﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.NamingConventions.Structs
{
    public struct Coords
    {
        public double Latitute; 
        public double Longitude;
        public override string ToString() => $"Coords({Latitute}, {Longitude})";
    }
}
