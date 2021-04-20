using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphone.Services.Models
{
   public class SmartphoneSearchModell
    {
        public int? Id { get; set; }

        public int? MakeId { get; set; }

        public int? ModelId { get; set; }

        public int? BackCameraMpFrom { get; set; }
        public int? BackCameraMpTo { get; set; }

        public int? BatteryCapacitetyFrom { get; set; }
        public int? BatteryCapacitetyTo { get; set; }

        public decimal? PriceFrom { get; set; }

        public decimal? PriceTo { get; set; }

        public double? SizeDisplayFrom { get; set; }

        public double? SizeDisplayTo { get; set; }

        [BindProperty]
        public List<int> RamAreChecked { get; set; }
        [BindProperty]
        public List<int> MemoryAreChecked { get; set; }


    }
}
