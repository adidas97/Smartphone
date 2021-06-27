using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Smartphone.Data.Models
{
   public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public List<Advertisement> Advertisements { get; set; }
    }
}
