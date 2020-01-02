using PsMvc.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PsMvc.Controllers
{
    public class PsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ps
        public async Task<ActionResult> Index()
        {
            return View(await db.Ps.ToListAsync());
        }

        // GET: Ps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ps ps = await db.Ps.FindAsync(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
        }

        // GET: Ps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Description,OwnerId,Type,StatusId,Importance,Cost,PeriodicityId")] Ps ps)
        {
            if (ModelState.IsValid)
            {
                db.Ps.Add(ps);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ps);
        }

        // GET: Ps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ps ps = await db.Ps.FindAsync(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
        }

        // POST: Ps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Description,OwnerId,Type,StatusId,Importance,Cost,PeriodicityId")] Ps ps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ps).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ps);
        }

        // GET: Ps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ps ps = await db.Ps.FindAsync(id);
            if (ps == null)
            {
                return HttpNotFound();
            }
            return View(ps);
        }

        // POST: Ps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ps ps = await db.Ps.FindAsync(id);
            db.Ps.Remove(ps);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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
