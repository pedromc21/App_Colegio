using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cole.Web.Data;
using Cole.Web.Data.Entities;

namespace Cole.Web.Controllers
{
    public class CargosController : Controller
    {
        private readonly ICargoRepository cargoRepository;

        public CargosController(ICargoRepository cargoRepository)
        {
            this.cargoRepository = cargoRepository;
        }

        // GET: Cargoes
        public IActionResult Index()
        {
            return View(this.cargoRepository.GetAll());
        }

        // GET: Cargoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await this.cargoRepository.GetByIdAsync(id.Value);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // GET: Cargoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cargoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                await this.cargoRepository.CreateAsync(cargo);
                return RedirectToAction(nameof(Index));
            }
            return View(cargo);
        }

        // GET: Cargoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cargo = await this.cargoRepository.GetByIdAsync(id.Value);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }

        // POST: Cargoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.cargoRepository.UpdateAsync(cargo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.cargoRepository.ExistAsync(cargo.Id))
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
            return View(cargo);
        }

        // GET: Cargoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cargo = await this.cargoRepository.GetByIdAsync(id.Value);
            if (cargo == null)
            {
                return NotFound();
            }

            return View(cargo);
        }

        // POST: Cargoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cargo = await this.cargoRepository.GetByIdAsync(id);
            await this.cargoRepository.DeleteAsync(cargo);
            return RedirectToAction(nameof(Index));
        }

        /*private bool CargoExists(int id)
        {
            return cargoRepository.ExistAsync(e => e.Id == id);
        }*/
    }
}
