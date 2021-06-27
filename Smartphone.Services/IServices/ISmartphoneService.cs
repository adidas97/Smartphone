using Smartphone.Data.Models;
using Smartphone.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Smartphone.Services.IServices
{
   public interface ISmartphoneService
    {
        List<Make> GetMakes();
        List<Model> GetModels(int makeId);
        void CreateAdvertisement(Advertisement model);
        List<Advertisement> MyUploadedAdvertisements();
        Advertisement GetAdvertisementById(int id);
        void DeleteAdvertisement(int id);
        AdvertisementEditModel EditById(int id);
        void Edit(int id, string description, decimal price, string name);
        List<Advertisement> ShowAdvertisementByMake(int id);
        IQueryable<Advertisement> GetAdvertisementsBySearch(AdvertisementSearchModell model);
    }
}
