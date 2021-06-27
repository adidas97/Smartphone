using Microsoft.AspNetCore.Http;

namespace Smartphone.Web.Models
{
    public class CreateAdvertisementViewModel
    {
        public int MakeId { get; set; }

        public int ModelId { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public IFormFile Image1 { get; set; }
        public IFormFile Image2 { get; set; }
    }
}
