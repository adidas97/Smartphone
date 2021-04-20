using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone.Web.Models
{
    public class CreateSmartphoneViewModel
    {
        public int MakeId { get; set; }

        

        public int ModelId { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string NameOfAdvertisement { get; set; }
        
        public IFormFile Image1 { get; set; }
        public IFormFile Image2 { get; set; }
        public IFormFile Image3 { get; set; }
        public IFormFile Image4 { get; set; }
        public IFormFile Image5 { get; set; }
    }
}
