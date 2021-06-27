using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Smartphone.Services.Models
{
   public class AdvertisementSearchModell
    {
        public int? Id { get; set; }

        public int? MakeId { get; set; }

        public int? ModelId { get; set; }

        public int? BasicCameraFrom { get; set; }
        public int? BasicCameraTo { get; set; }
        
        public decimal? PriceFrom { get; set; }

        public decimal? PriceTo { get; set; }

        public int? ModelYearFrom { get; set; }

        public int? ModelYearTo { get; set; }

        [BindProperty]
        public List<int> RamAreChecked { get; set; }
        [BindProperty]
        public List<int> MemoryAreChecked { get; set; }
    }
}
