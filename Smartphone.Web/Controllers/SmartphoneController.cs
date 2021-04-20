using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Smartphone.Data.Models;
using Smartphone.Services.IServices;
using Smartphone.Services.Models;
using Smartphone.Web.Models;


namespace Smartphone.Web.Controllers
{
    public class SmartphoneController : Controller
    {
        private readonly ICreateSmartphoneService service;
        private readonly IHostingEnvironment env;
        private readonly IHttpContextAccessor http;

        public SmartphoneController(IHttpContextAccessor http,ICreateSmartphoneService service,IHostingEnvironment env)
        {
            this.service = service;
            this.env = env;
            this.http = http;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateSmartphone()
        {
            var makes = service.GetMakes();

            ViewBag.Makes = makes;
            return View();
        }

        public JsonResult GetModels(int MakeId)
        {

            var models = service.GetModels(MakeId);

            return Json(new SelectList(models, "ModelId", "NameOfModel"));

        }

        [HttpPost]
        public  IActionResult CreateSmartphone(CreateSmartphoneViewModel model)
        {
            bool[] array = new bool[6];
           
            if (model.Image1 != null)
            {
                array[1] = true;
            }
            
            if (model.Image2 != null)
            {
                array[2] = true;
            }
            
            if (model.Image3 != null)
            {
                array[3] = true;
            }
            
            if (model.Image4 != null)
            {
                array[4] = true;
            }
            
            if (model.Image5 != null)
            {
                array[5] = true;
            }

            string userid = http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int make = model.MakeId;
            int modeltel = model.ModelId;

            string path = env.WebRootPath + "/files/";
            bool existUserFolder = System.IO.Directory.Exists(path + userid);
            if(!existUserFolder)
            {
                var folderpath = path + userid +"/";
                System.IO.Directory.CreateDirectory(folderpath);

                bool existMakeFolder = System.IO.Directory.Exists(folderpath + make );

                if(!existMakeFolder)
                {
                    var folderpathh = folderpath + make+"/";
                    System.IO.Directory.CreateDirectory(folderpathh);

                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modeltel);

                    if(!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modeltel +"/";
                        System.IO.Directory.CreateDirectory(folderpathhh);
                        for (int i = 1; i <= 5; i++)
                        {
                            if (array[i])
                            {
                                var file = folderpathhh + i + ".jpg";
                                using (var stream = new FileStream(file, FileMode.Create))
                                {
                                    Upload(i, stream, model);

                                }}
                        } }} 
                }else
            {

                var folderpath = path + userid + "/";
                

                bool existMakeFolder = System.IO.Directory.Exists(folderpath + make);

                if (existMakeFolder)
                {
                    var folderpathh = folderpath + make + "/";
                    

                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modeltel);

                    if (!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modeltel + "/";
                        System.IO.Directory.CreateDirectory(folderpathhh);
                        for (int i = 1; i <= 5; i++)
                        {
                            if (array[i])
                            {
                                var file = folderpathhh + i + ".jpg";
                                using (var stream = new FileStream(file, FileMode.Create))
                                {
                                    Upload(i, stream, model);

                                }
                            }
                        }
                    }

                } else
                {
                    var folderpathh = folderpath + make + "/";
                    System.IO.Directory.CreateDirectory(folderpathh);

                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modeltel);

                    if (!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modeltel + "/";
                        System.IO.Directory.CreateDirectory(folderpathhh);
                        for (int i = 1; i <= 5; i++)
                        {
                            if (array[i])
                            {
                                var file = folderpathhh + i + ".jpg";
                                using (var stream = new FileStream(file, FileMode.Create))
                                {
                                   Upload(i, stream, model);

                                }
                            }
                        }
                    } else
                    {
                        var folderpathhh = folderpathh + modeltel + "/";
                        
                        var file = folderpathhh + "1.jpg";
                        using (var stream = new FileStream(file, FileMode.Create))
                        {
                            
                        }
                    }
                }

            }
           
            
            var telephone = new Telephone
            {
                MakeId = model.MakeId,
                Image1 = array[1],
                Image2 = array[2],
                Image3 = array[3],
                Image4 = array[4],
                Image5 = array[5],
                ModelId = model.ModelId,
                Price = model.Price,
                Description = model.Description,
                NameOfAdvertisement = model.NameOfAdvertisement
                
            };

            service.CreateSmartphone(telephone);

            return RedirectToAction(nameof(CurrentUserAdvertisement));
        }

        private void Upload (int i,FileStream stream,CreateSmartphoneViewModel model)
        {
            
                switch (i)
                {
                    case 1:
                         model.Image1.CopyTo(stream);
                        break;
                    case 2:
                         model.Image2.CopyTo(stream);
                        break;
                    case 3:
                         model.Image3.CopyTo(stream);
                        break;
                    case 4:
                         model.Image4.CopyTo(stream);
                        break;
                    case 5:
                         model.Image5.CopyTo(stream);
                        break;
                    default: break;
                

            }
        }

        public IActionResult CurrentUserAdvertisement()
        {
           var telephones =  service.MyUploadedSmartphones();
            return View(telephones);
        }

        public IActionResult Details(int id)
        {
            var smartphone = service.GetSmartphoneById(id);
            
            if (smartphone == null)
            {
                return NotFound();
            }

            return View(smartphone);
        }
        [HttpPost]
        public IActionResult EditById(int id, CreateSmartphoneViewModel model)
        {
            service.Edit(id, model.Description, model.Price, model.NameOfAdvertisement);
            return RedirectToAction(nameof(CurrentUserAdvertisement));
        }

        public IActionResult EditById(int id)
        {
            var telephone = service.EditById(id);
            if(telephone==null)
            {
                return NotFound();
            }
            return View(new CreateSmartphoneViewModel
            {
                NameOfAdvertisement = telephone.NameOfAdvertisement,
                Price = telephone.Price,
                Description = telephone.Description
            });
        }

        public IActionResult Destroy(int id) => View(id);

        public IActionResult DeletingSmartphone(int id)
        {

            service.DeleteSmartphone(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ShowSmartphoneByMake(int id)
        {
            var telephones = service.ShowSmartphoneByMake(id);
            return View(telephones);
        }
        
        public IActionResult Search()
        {
            var makes = service.GetMakes();
           
            ViewBag.Makes = makes;
            return View();
        }
         [HttpPost]
        public IActionResult Search( SmartphoneSearchModell model)
        {
            var telephone = service.GetTelephones(model);
            return View("Result",telephone);
        }
        




    }
}