using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Web.Models
{
    public class SmartphoneSearchModel
    {
        public int? Id { get; set; }

        public decimal? PriceFrom { get; set; }

        public decimal? PriceTo { get; set; }
    }
}
