using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Smartphone.Services.IServices;

namespace Smartphone.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        public IActionResult Index(string id)
        {
            var user = service.GetCurrentUserPersonalData(id);
            return View(user);
        }
        public IActionResult GetSmartphonesByUserId(string id)
        {
            
            var telephones = service.GetSmartphonesByUserId(id);
            return View(telephones);
        }
    }
}