using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Smartphone.Data;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using Smartphone.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;



namespace Smartphone.Services.IServices
{
   public interface ICreateSmartphoneService
    {
        List<Make> GetMakes();
        List<Model> GetModels(int MakeId);
        void CreateSmartphone(Telephone model);
        ICollection<Telephone> MyUploadedSmartphones();
        Telephone GetSmartphoneById(int id);
        void DeleteSmartphone(int id);
        SmartphoneEditModel EditById(int id);
        void Edit(int id, string description, decimal price, string nameOfAdvertisement);
        ICollection<Telephone> ShowSmartphoneByMake(int id);
        IQueryable<Telephone> GetTelephones(SmartphoneSearchModell model);
        




    }
}
