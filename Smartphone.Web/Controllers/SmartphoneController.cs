using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ISmartphoneService service;
        private readonly IHostingEnvironment env;
        private readonly IHttpContextAccessor http;

        public SmartphoneController(IHttpContextAccessor http,ISmartphoneService service,IHostingEnvironment env)
        {
            this.service = service;
            this.env = env;
            this.http = http;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult CreateAdvertisement()
        {
            var makes = service.GetMakes();

            ViewBag.Makes = makes;
            return View();
        }

        public JsonResult GetModels(int MakeId)
        {

            var models = service.GetModels(MakeId);

            return Json(new SelectList(models, "ModelId", "Name"));
        }

        [HttpPost]
        public  IActionResult CreateAdvertisement(CreateAdvertisementViewModel model)
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
            
            string userId = http.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int makeId = model.MakeId;
            int modelId = model.ModelId;

            string path = env.WebRootPath + "/files/";
            bool existUserFolder = System.IO.Directory.Exists(path + userId);
            if(!existUserFolder)
            {
                var folderpath = path + userId + "/";
                System.IO.Directory.CreateDirectory(folderpath);

                bool existMakeFolder = System.IO.Directory.Exists(folderpath + makeId);

                if(!existMakeFolder)
                {
                    var folderpathh = folderpath + makeId + "/";
                    System.IO.Directory.CreateDirectory(folderpathh);

                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modelId);

                    if(!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modelId + "/";
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

                var folderpath = path + userId + "/";
                
                bool existMakeFolder = System.IO.Directory.Exists(folderpath + makeId);

                if (existMakeFolder)
                {
                    var folderpathh = folderpath + makeId + "/";
                    
                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modelId);

                    if (!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modelId + "/";
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
                    var folderpathh = folderpath + makeId + "/";
                    System.IO.Directory.CreateDirectory(folderpathh);

                    bool existModelFolder = System.IO.Directory.Exists(folderpathh + modelId);

                    if (!existModelFolder)
                    {
                        var folderpathhh = folderpathh + modelId + "/";
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
                        var folderpathhh = folderpathh + modelId + "/";
                        
                        var file = folderpathhh + "1.jpg";
                        using (var stream = new FileStream(file, FileMode.Create))
                        {
                            
                        }
                    }
                }
            }
           
            var ad = new Advertisement
            {
                MakeId = model.MakeId,
                Image1 = array[1],
                Image2 = array[2],
                ModelId = model.ModelId,
                Price = model.Price,
                Description = model.Description,
                Name = model.Name
            };
            service.CreateAdvertisement(ad);

            return RedirectToAction(nameof(CurrentUserAdvertisements));
        }

        private void Upload(int i,FileStream stream, CreateAdvertisementViewModel model)
        {
                switch (i)
                {
                    case 1:
                         model.Image1.CopyTo(stream);
                        break;
                    case 2:
                         model.Image2.CopyTo(stream);
                        break;
                    default: break;
            }
        }

        public IActionResult CurrentUserAdvertisements()
        {
           var advertisements =  service.MyUploadedAdvertisements();
            return View(advertisements);
        }

        public IActionResult Details(int id)
        {
            var advertisement = service.GetAdvertisementById(id);
            
            if (advertisement == null)
            {
                return NotFound();
            }

            return View(advertisement);
        }

        [HttpPost]
        public IActionResult EditById(int id, CreateAdvertisementViewModel model)
        {
            service.Edit(id, model.Description, model.Price, model.Name);
            return RedirectToAction(nameof(CurrentUserAdvertisements));
        }

        public IActionResult EditById(int id)
        {
            var advertisement = service.EditById(id);

            if(advertisement == null)
            {
                return NotFound();
            }

            return View(new CreateAdvertisementViewModel
            {
                Name = advertisement.Name,
                Price = advertisement.Price,
                Description = advertisement.Description
            });
        }

        public IActionResult Destroy(int id) => View(id);

        public IActionResult DeletingAdvertisement(int id)
        {
            service.DeleteAdvertisement(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ShowAdvertisementByMake(int id)
        {
            var advertisements = service.ShowAdvertisementByMake(id);
            return View(advertisements);
        }
        
        [Authorize]
        public IActionResult Search()
        {
            var makes = service.GetMakes();
           
            ViewBag.Makes = makes;
            return View();
        }

        [HttpPost]
        public IActionResult Search( AdvertisementSearchModell model)
        {
            var advertisements = service.GetAdvertisementsBySearch(model);
            return View("Result", advertisements);
        }
    }
}