using PsMvc.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PsMvc.Controllers
{
    public class PeriodiciesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Periodicies
        public async Task<ActionResult> Index()
        {
            return View(await db.Periodicies.ToListAsync());
        }

        // GET: Periodicies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Periodicy periodicy = await db.Periodicies.FindAsync(id);
            if (periodicy == null)
            {
                return HttpNotFound();
            }
            return View(periodicy);
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
