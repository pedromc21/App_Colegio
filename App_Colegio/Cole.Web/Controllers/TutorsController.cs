
namespace Cole.Web.Controllers
{
    using Data;
    using Data.Entities;
    using Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    public class TutorsController : Controller
    {
        private readonly ITutorRepository tutorRepository;
        private readonly IUserHelper userHelper;

        public TutorsController(ITutorRepository tutorRepository, IUserHelper userHelper)
        {
            this.tutorRepository = tutorRepository;
            this.userHelper = userHelper;
        }

        // GET: Tutors
        public IActionResult Index()
        {
            return View(this.tutorRepository.GetAll().OrderBy(p => p.Nombres));
        }

        // GET: Tutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutor = await this.tutorRepository.GetByIdAsync(id.Value);
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
                tutor.User = await this.userHelper.GetUserByEmailAsync("invernaderosjc@hotmail.com");
                await this.tutorRepository.CreateAsync(tutor);
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

            var tutor = await this.tutorRepository.GetByIdAsync(id.Value);
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
                    tutor.User = await this.userHelper.GetUserByEmailAsync("invernaderosjc@hotmail.com");
                    await this.tutorRepository.UpdateAsync(tutor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.tutorRepository.ExistAsync(tutor.Id))
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

            var tutor = await this.tutorRepository.GetByIdAsync(id.Value);
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
            var tutor = await this.tutorRepository.GetByIdAsync(id);
            await this.tutorRepository.DeleteAsync(tutor);
            return RedirectToAction(nameof(Index));
        }

        //private bool TutorExists(int id)
        //{
        //    return _context.Tutors.Any(e => e.Id == id);
        //}
    }
}
