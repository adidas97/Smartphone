using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Smartphone.Data.Models
{
   public class Make
    {
        [Key]
        public int MakeId { get; set; }

        public string Name { get; set; }

        public List<Model> Models { get; set; }
    }
}
