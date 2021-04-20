using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Smartphone.Data.Models
{
   public class Telephone
    {
        [Key]
        public int Id { get; set; }

        public string NameOfAdvertisement { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        
        public bool Image1 { get; set; }
        public bool Image2 { get; set; }
        public bool Image3 { get; set; }
        public bool Image4 { get; set; }
        public bool Image5 { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
        public Make Make { get; set; }

        [ForeignKey("ModelId")]
        public int ModelId { get; set; }
        public Model Model { get; set; }

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

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
