using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;

namespace WebApplication1.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CarController : Controller
    {
        private AppDbContext _context { get; }
        public CarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() {
            return View();
        }
    }
}
