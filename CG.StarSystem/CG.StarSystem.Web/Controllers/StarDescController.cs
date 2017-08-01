using System.Collections.Generic;
using System.Web.Mvc;
using CG.StarSystem.ApplicationServices;
using CG.StarSystem.Data.Models;
using System.Threading.Tasks;

namespace CG.StarSystem.Web.Controllers
{
    public class StarDescController : Controller
    {
        private readonly IStarDescService _service;
        public StarDescController(IStarDescService service) {
            _service = service;
        }

        // GET: StarDesc
        public async Task<ActionResult> Index()
        {
            IList<StarDesc> stars = await _service.GetAllStars();
            
            return View(stars);
        }
    }
}