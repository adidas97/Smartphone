using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Smartphone.Data;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using Smartphone.Services.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Smartphone.Services.ServicesImplementation
{
    public class SmartphoneService : ISmartphoneService
    {
        private readonly SmartphoneDbContext db;
        private readonly IHttpContextAccessor http;
        private readonly IHostingEnvironment env;

        public SmartphoneService(IHostingEnvironment env, IHttpContextAccessor http, SmartphoneDbContext db)
        {
            this.db = db;
            this.http = http;
            this.env = env;
        }   
        
        public void CreateAdvertisement(Advertisement model)
        {
            var ad = new Advertisement
            {
                Price = model.Price,
                Model = model.Model,
                Make = model.Make,
                User = model.User,
                Image1 = model.Image1,
                Image2 = model.Image2,
                Description = model.Description,
                MakeId = model.MakeId,
                ModelId = model.ModelId,
                Name = model.Name,
                UserId = http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
            };
            db.Advertisements.Add(ad);
            db.SaveChanges();
        }

        public List<Make> GetMakes()
        {
            var makes = db.Makes.Select(e=>new Make
            {
                MakeId = e.MakeId,
                Name = e.Name

            }).ToList();
            return makes;
        }
        
        public List<Model> GetModels(int MakeId)
        {
            var models = db.Models.Where(
                e => e.Make.MakeId == MakeId).Select(e=>new Model
                {
                    ModelId = e.ModelId,
                    Name = e.Name

                }).OrderBy(e => e.Name).ToList();
            models.Insert(0, new Model { ModelId = 0, Name = "Select Model" });

            return models;
        }
        
        public List<Advertisement> MyUploadedAdvertisements()
        {
            var advertisements = db
                .Advertisements
                .Where(e => e.UserId == http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price
                })
                .ToList();

            return advertisements;
        }

        public Advertisement GetAdvertisementById(int id)
        {
            var ad = db.Advertisements.Select(e=>new Advertisement
            {    
               Name = e.Name,
               Description = e.Description,
               Price = e.Price,
               Id = e.Id,
               Image1 = e.Image1,
               Image2 = e.Image2,
               Make = e.Make,
               MakeId = e.MakeId,
               Model = e.Model,
               ModelId = e.ModelId,
               UserId = e.UserId,
               User = e.User
            }).FirstOrDefault(e => e.Id == id);

            return ad;
        }

        public void DeleteAdvertisement(int id)
        {
            var ad = db.Advertisements.Find(id);
            if (ad == null)
            {
                return;
            }
            System.IO.DirectoryInfo di = new DirectoryInfo
                (env.WebRootPath + "/files/" +
                http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
                + "/"
                + ad.MakeId + "/" + ad.ModelId);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            di.Delete();
            db.Remove(ad);
            db.SaveChanges();

            System.IO.DirectoryInfo dii = new DirectoryInfo
                (env.WebRootPath + "/files/" +
                http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
                + "/"
                + ad.MakeId);
            
            if(dii.GetDirectories().Length==0)
            {
                dii.Delete();
            }
        }

        public AdvertisementEditModel EditById(int id)
        => db
            .Advertisements
            .Where(e => e.Id == id)
            .Select(a => new AdvertisementEditModel
            {
                Name = a.Name,
                Price = a.Price,
                Description = a.Description
            }).FirstOrDefault();

        public void Edit(int id, string description, decimal price, string name)
        {
            var ad = db.Advertisements.Find(id);
            if (ad == null)
            {
                return;
            }
            ad.Description = description;
            ad.Price = price;
            ad.Name = name;

            db.SaveChanges();
        }

        public List<Advertisement> ShowAdvertisementByMake(int id)
        {
            var ad = db.Advertisements.Where(e => e.Make.MakeId == id)
                .Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price
                })
                .ToList();

            return ad;
        }

        public IQueryable<Advertisement> GetAdvertisementsBySearch(AdvertisementSearchModell model)
        {
            var result = db.Advertisements.AsQueryable();

            if (model.MakeId.HasValue)
            {
                result = result.Where(e => e.Make.MakeId == model.MakeId).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.ModelId != 0 && model.ModelId.HasValue)
            {
                result = result.Where(e => e.Model.ModelId == model.ModelId).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.MemoryAreChecked != null && model.RamAreChecked != null)
            {
                result = result.Where(e => model.MemoryAreChecked.Contains(e.Model.Memory) && model.RamAreChecked.Contains(e.Model.RAM)).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }

            else if (model.RamAreChecked != null)
            {
                result = result.Where(e => model.RamAreChecked.Contains(e.Model.RAM)).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }

            else if (model.MemoryAreChecked != null)
            {
                result = result.Where(e => model.MemoryAreChecked.Contains(e.Model.Memory)).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            
            if (model.PriceFrom.HasValue)
                {
                    result = result.Where(e => e.Price >= model.PriceFrom).Select(e => new Advertisement
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
            if (model.ModelYearFrom.HasValue)
            {
                result = result.Where(e => e.Model.ModelYear >= model.ModelYearFrom).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.ModelYearTo.HasValue)
            {
                result = result.Where(e => e.Model.ModelYear <= model.ModelYearTo).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            
            if (model.BasicCameraFrom.HasValue)
            {
                result = result.Where(e => e.Model.BasicCamera >= model.BasicCameraFrom).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.BasicCameraTo.HasValue)
            {
                result = result.Where(e => e.Model.BasicCamera <= model.BasicCameraTo).Select(e => new Advertisement
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }

            if (model.PriceTo.HasValue)
                {
                    result = result.Where(e => e.Price <= model.PriceTo).Select(e => new Advertisement
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
                if (!(model.PriceFrom.HasValue) && !(model.PriceTo.HasValue)
                && !(model.MakeId.HasValue) && model.RamAreChecked == null && model.MemoryAreChecked == null
                && !(model.BasicCameraFrom.HasValue) && !(model.BasicCameraTo.HasValue)
                && !(model.ModelYearFrom.HasValue) && !(model.ModelYearTo.HasValue))
                {
                    result = result.Select(e => new Advertisement
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
                return result;
        }
    }
}