using Smartphone.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartphone.Services.IServices
{
   public interface IUserService
    {
        ApplicationUser GetCurrentUserPersonalData(string id);
        ICollection<Telephone> GetSmartphonesByUserId(string id);


    }
}
