
namespace Cole.Web.Controllers
{
    using Cole.Web.Data;
    using Cole.Web.Data.Entities;
    using Cole.Web.Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    public class TutorsController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserHelper userHelper;

        public TutorsController(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            this.userHelper = userHelper;
        }

        // GET: Tutors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tutors.ToListAsync());
        }

        // GET: Tutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // GET: Tutors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tutors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                //TODO: CHANGE FOR THE LOGGER USER
                //TODO: SON CAMBIOS PENDIENTES QUE SE PUEDEN VER DESDE EL TAG LIST DESDE EL MENU VIEW->TASK LIST
                tutor.User = await this.userHelper.GetUserByEmailAsync("pedromc219@gmail.com");
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tutor);
        }

        // GET: Tutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }
            return View(tutor);
        }

        // POST: Tutors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //TODO: CHANGE FOR THE LOGGER USER
                    tutor.User = await this.userHelper.GetUserByEmailAsync("pedromc219@gmail.com");
                    _context.Update(tutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorExists(tutor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tutor);
        }

        // GET: Tutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // POST: Tutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tutor = await _context.Tutors.FindAsync(id);
            _context.Tutors.Remove(tutor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorExists(int id)
        {
            return _context.Tutors.Any(e => e.Id == id);
        }
    }
}
