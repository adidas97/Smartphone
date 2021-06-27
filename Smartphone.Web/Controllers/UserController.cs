using Microsoft.AspNetCore.Mvc;
using Smartphone.Services.IServices;

namespace Smartphone.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService service)
        {
            userService = service;
        }
        public IActionResult Index(string id)
        {
            var user = userService.GetCurrentUserPersonalData(id);
            return View(user);
        }
        public IActionResult GetAdvertisementsByUserId(string id)
        {
            var telephones = userService.GetAdvertisementsByUserId(id);
            return View(telephones);
        }
    }
}