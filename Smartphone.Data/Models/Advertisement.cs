using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smartphone.Data.Models
{
   public class Advertisement
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        
        public bool Image1 { get; set; }
        public bool Image2 { get; set; }

        [ForeignKey("MakeId")]
        public int MakeId { get; set; }
        public Make Make { get; set; }

        [ForeignKey("ModelId")]
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }
    }
}
