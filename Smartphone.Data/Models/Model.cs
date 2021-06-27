using System.ComponentModel.DataAnnotations;

namespace Smartphone.Data.Models
{
   public class Model
    {
        [Key]
        public int ModelId { get; set; }

        public string Name { get; set; }

        public int? MakeId { get; set; }

        public Make Make { get; set; }

        public int ModelYear { get; set; }
        
        public int RAM { get; set; }
        
        public int BasicCamera { get; set; }

        public int Memory { get; set; }
    }
}
