using Smartphone.Data.Models;
using System.Collections.Generic;

namespace Smartphone.Services.IServices
{
   public interface IUserService
    {
        User GetCurrentUserPersonalData(string id);
        List<Advertisement> GetAdvertisementsByUserId(string id);
    }
}
