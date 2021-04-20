﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphone.Data.Models
{
   public class Charachteristic
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public string Network { get; set; }

        public string Battery { get; set; }

        public int CapacityOfBattery { get; set; }

        public bool HasTwoSim { get; set; }

        public string TypeOfSim { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Thickness { get; set; }

        public double Weight { get; set; }

        public int RAM { get; set; }

        public int BuiltInMemory { get; set; }

        public string SlotForMemory { get; set; }

        public string Processor { get; set; }

        public double SizeInInches { get; set; }

        public int FrontCamera { get; set; }

        public int BackCamera { get; set; }

        public bool HasFinger { get; set; }
    }
}
