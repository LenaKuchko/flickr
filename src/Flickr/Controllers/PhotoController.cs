using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Flickr.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;
using System.IO;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Flickr.Controllers
{
    public class PhotoController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public PhotoController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Photos.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string description, IFormFile image)
        {
            byte[] newImage = new byte[0];
            if (image != null)
            {
                using (Stream fileStream = image.OpenReadStream())
                using (MemoryStream ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    newImage = ms.ToArray();
                }
            }
            Photo newPhoto = new Photo(title, description, newImage);
            db.Photos.Add(newPhoto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
