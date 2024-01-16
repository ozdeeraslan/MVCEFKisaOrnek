using Microsoft.AspNetCore.Mvc;
using MvcEfOzluSozGorev.Data;
using MvcEfOzluSozGorev.Models;
using System.Diagnostics;
using System.Linq;

namespace MvcEfOzluSozGorev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(string ara, int sayfa = 1)
        {
            IQueryable<OzluSoz> ozluSozler = _db.OzluSozler;

            if (!string.IsNullOrEmpty(ara))
            {
                ozluSozler = ozluSozler.Where(x => x.Id.ToString().Contains(ara) || x.Soz.Contains(ara) || x.Yazar.Contains(ara));
            }

            int toplamSoz = ozluSozler.Count();
            int toplamSayfa = (int)Math.Ceiling((double)toplamSoz / 10);

            ozluSozler = ozluSozler.Skip((sayfa - 1) * 10).Take(10);

            ViewBag.TotalPages = toplamSayfa;
            ViewBag.CurrentPage = sayfa;

            return View(ozluSozler.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
