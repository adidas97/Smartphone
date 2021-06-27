using Smartphone.Data;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Smartphone.Services.ServicesImplementation
{
    public class UserService : IUserService
    {
        private readonly SmartphoneDbContext database;
       
        public UserService(SmartphoneDbContext db)
        {
            database = db;
        }

        public User GetCurrentUserPersonalData(string id)
        {
            var user = database.Users
                  .Where(e=>e.Id == id)
                  .Select(e=>new User
                {
                   City = e.City,
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   PhoneNumber = e.PhoneNumber,
                   UserName = e.UserName,
                   Id = e.Id
                }).FirstOrDefault();
            return user;
        }

        public List<Advertisement> GetAdvertisementsByUserId(string id)
        {
            var advertisements = database.Advertisements.Where(e => e.UserId == id).Select
                (e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price,
                }).ToList();
            return advertisements;
        }
    }
}
