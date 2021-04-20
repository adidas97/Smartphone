using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Smartphone.Data;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using System;
using System.Collections.Generic;

using System.Text;
using System.Linq;

namespace Smartphone.Services.ServicesImplementation
{
    public class UserService : IUserService
    {

        private readonly SmartphoneDbContext db;
       
        public UserService(IHostingEnvironment env, IHttpContextAccessor http, SmartphoneDbContext db)
        {
            this.db = db;
            
        }

        public ApplicationUser GetCurrentUserPersonalData(string id)
        {
            var user = db.Users
                .Where(e=>e.Id == id)
                .Select(e=>new ApplicationUser
                {City = e.City,
                FirstName = e.FirstName,
                LastName = e.LastName,
                PhoneNumber = e.PhoneNumber,
                UserName = e.UserName,
                Id = e.Id
                }).FirstOrDefault();
            return user;
        }

        public ICollection<Telephone> GetSmartphonesByUserId(string id)
        {
            var telephones = db.Telephones.Where(e => e.UserId == id).Select
                (e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price,
                    

                }).ToList();
            return telephones;
        }
        
    }
}
