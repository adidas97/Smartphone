using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Smartphone.Data;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using Smartphone.Services.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;




namespace Smartphone.Services.ServicesImplementation
{
    public class CreateSmartphoneService : ICreateSmartphoneService
    {
        private readonly SmartphoneDbContext db;
        private readonly IHttpContextAccessor http;
        private readonly IHostingEnvironment env;

        public CreateSmartphoneService(IHostingEnvironment env, IHttpContextAccessor http, SmartphoneDbContext db)
        {
            this.db = db;
            this.http = http;
            this.env = env;
    }



        public void CreateSmartphone(Telephone model)
        {
            var currentModel = db.Models.Where(e => e.ModelId == model.ModelId).FirstOrDefault();



            var tel = new Telephone
            {
                Price = model.Price,
                Model = model.Model,
                Make = model.Make,
                User = model.User,
                Image1 = model.Image1,
                Image2 = model.Image2,
                Image3 = model.Image3,
                Image4 = model.Image4,
                Image5 = model.Image5,
                Description = model.Description,
                MakeId = model.MakeId,
                ModelId = model.ModelId,
                NameOfAdvertisement = model.NameOfAdvertisement,
                BackCamera = currentModel.BackCamera,
                Battery = currentModel.Battery,
                BuiltInMemory = currentModel.BuiltInMemory,
                ModelYear = currentModel.ModelYear,
                Network = currentModel.Network,
                Processor = currentModel.Processor,
                RAM = currentModel.RAM,
                SizeInInches = currentModel.SizeInInches,
                SlotForMemory = currentModel.SlotForMemory,
                Thickness = currentModel.Thickness,
                TypeOfSim = currentModel.TypeOfSim,
                Weight = currentModel.Weight,
                Width = currentModel.Width,
                CapacityOfBattery = currentModel.CapacityOfBattery,
                Height = currentModel.Height,
                FrontCamera = currentModel.FrontCamera,
                HasFinger = currentModel.HasFinger,
                HasTwoSim = currentModel.HasTwoSim,
                

                UserId = http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)

            };

            db.Telephones.Add(tel);

            db.SaveChanges();

        }

        public List<Make> GetMakes()
        {
            var makes = db.Makes.Select(e=>new Make
            {MakeId = e.MakeId,
            NameOfMake = e.NameOfMake
            }).ToList();
            return makes;
        }

       
        public List<Model> GetModels(int MakeId)
        {
            var models = db.Models.Where(
                e => e.Make.MakeId == MakeId).Select(e=>new Model
                {ModelId = e.ModelId,
                NameOfModel = e.NameOfModel
               
                }).OrderBy(e => e.NameOfModel).ToList();
            models.Insert(0, new Model { ModelId = 0, NameOfModel = "Select Model" });

            return models;
        }

       
        public ICollection<Telephone> MyUploadedSmartphones()
        {
            var telephones = db
                .Telephones
                .Where(e => e.UserId == http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier))
                .Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price
                    
                })
                .ToList();
            return telephones;
        }

        public Telephone GetSmartphoneById(int id)
        {
            var telephone = db.Telephones.Select(e=>new Telephone
            {    BackCamera = e.BackCamera,
            NameOfAdvertisement = e.NameOfAdvertisement,
            RAM = e.RAM,
            Battery = e.Battery,
            BuiltInMemory = e.BuiltInMemory,
            CapacityOfBattery = e.CapacityOfBattery,
            Description = e.Description,
            FrontCamera = e.FrontCamera,
            HasFinger = e.HasFinger,
            HasTwoSim = e.HasTwoSim,
            Height = e.Height,
            Id = e.Id,
            Image1 = e.Image1,
            Image2 = e.Image2,
            Image3 = e.Image3,
            Image4 = e.Image4,
            Image5 = e.Image5,
            Make = e.Make,
            MakeId = e.MakeId,
            Model = e.Model,
            ModelId = e.ModelId,
            ModelYear = e.ModelYear,
            Network = e.Network,
            Price = e.Price,
            Processor = e.Processor,
            SizeInInches = e.SizeInInches,
            SlotForMemory = e.SlotForMemory,
            Thickness = e.Thickness,
            TypeOfSim = e.TypeOfSim,
            Weight = e.Weight,
            Width = e.Width,
            UserId = e.UserId,
                User = e.User
            }).FirstOrDefault(e => e.Id == id);
            return telephone;
        }

        public void DeleteSmartphone(int id)
        {

            var telephone = db.Telephones.Find(id);
            if (telephone == null)
            {
                return;
            }
            System.IO.DirectoryInfo di = new DirectoryInfo
                (env.WebRootPath + "/files/" +
                http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
                + "/"
                + telephone.MakeId + "/" + telephone.ModelId);
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            di.Delete();
            db.Remove(telephone);
            db.SaveChanges();

            System.IO.DirectoryInfo dii = new DirectoryInfo
                (env.WebRootPath + "/files/" +
                http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
                + "/"
                + telephone.MakeId);

            
            if(dii.GetDirectories().Length==0)
            {
                dii.Delete();
            }
            
        
        }

        public SmartphoneEditModel EditById(int id)
        => db
            .Telephones
            .Where(e => e.Id == id)
            .Select(a => new SmartphoneEditModel
            {
                NameOfAdvertisement = a.NameOfAdvertisement,
                Price = a.Price,
                Description = a.Description
            }).FirstOrDefault();

        public void Edit(int id, string description, decimal price, string nameOfAdvertisement)
        {
            var telephone = db.Telephones.Find(id);
            if (telephone == null)
            {
                return;
            }
            telephone.Description = description;
            telephone.Price = price;
            telephone.NameOfAdvertisement = nameOfAdvertisement;

            db.SaveChanges();
        }

        public ICollection<Telephone> ShowSmartphoneByMake(int id)
        {
            var tel = db.Telephones.Where(e => e.Make.MakeId == id)
                .Select(e => new Telephone
                {

                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Make = e.Make,
                    Model = e.Model,
                    Price = e.Price
                    
                })
                .ToList();
            return tel;
        }

        public IQueryable<Telephone> GetTelephones(SmartphoneSearchModell model)
        {

            var result = db.Telephones.AsQueryable();
            if (model.MakeId.HasValue)
            {
                result = result.Where(e => e.Make.MakeId == model.MakeId).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.ModelId != 0 && model.ModelId.HasValue)
            {
                result = result.Where(e => e.Model.ModelId == model.ModelId).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.MemoryAreChecked != null && model.RamAreChecked != null)
            {
                result = result.Where(e => model.MemoryAreChecked.Contains(e.BuiltInMemory) && model.RamAreChecked.Contains(e.RAM)).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });


            }

            else if (model.RamAreChecked != null)
            {
                result = result.Where(e => model.RamAreChecked.Contains(e.RAM)).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });

            }

            else if (model.MemoryAreChecked != null)
            {
                result = result.Where(e => model.MemoryAreChecked.Contains(e.BuiltInMemory)).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });


            }

            

            if (model.PriceFrom.HasValue)
                {
                    result = result.Where(e => e.Price >= model.PriceFrom).Select(e => new Telephone
                    {
                        Id = e.Id,
                        NameOfAdvertisement = e.NameOfAdvertisement,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
            if (model.SizeDisplayFrom.HasValue)
            {
                result = result.Where(e => e.SizeInInches >= model.SizeDisplayFrom).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.SizeDisplayTo.HasValue)
            {
                result = result.Where(e => e.SizeInInches <= model.SizeDisplayTo).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.BatteryCapacitetyFrom.HasValue)
            {
                result = result.Where(e => e.CapacityOfBattery >= model.BatteryCapacitetyFrom).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.BatteryCapacitetyTo.HasValue)
            {
                result = result.Where(e => e.CapacityOfBattery <= model.BatteryCapacitetyTo).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.BackCameraMpFrom.HasValue)
            {
                result = result.Where(e => e.BackCamera >= model.BackCameraMpFrom).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }
            if (model.BackCameraMpTo.HasValue)
            {
                result = result.Where(e => e.BackCamera <= model.BackCameraMpTo).Select(e => new Telephone
                {
                    Id = e.Id,
                    NameOfAdvertisement = e.NameOfAdvertisement,
                    Price = e.Price,
                    Model = e.Model,
                    Make = e.Make
                });
            }

            if (model.PriceTo.HasValue)
                {
                    result = result.Where(e => e.Price <= model.PriceTo).Select(e => new Telephone
                    {
                        Id = e.Id,
                        NameOfAdvertisement = e.NameOfAdvertisement,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
                if (!(model.PriceFrom.HasValue) && !(model.PriceTo.HasValue)
                && !(model.MakeId.HasValue) && model.RamAreChecked == null && model.MemoryAreChecked == null
                && !(model.BackCameraMpFrom.HasValue) && !(model.BackCameraMpTo.HasValue)
                && !(model.BatteryCapacitetyFrom.HasValue)&& !(model.BatteryCapacitetyTo.HasValue)
                && !(model.SizeDisplayFrom.HasValue) && !(model.SizeDisplayTo.HasValue))
                {
                    result = result.Select(e => new Telephone
                    {
                        Id = e.Id,
                        NameOfAdvertisement = e.NameOfAdvertisement,
                        Price = e.Price,
                        Model = e.Model,
                        Make = e.Make
                    });
                }
                return result;

            }

        
    }
    }
