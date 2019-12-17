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
    public class GruposController : Controller
    {
        private readonly IGrupoRepository grupoRepository;

        public GruposController(IGrupoRepository grupoRepository)
        {
            this.grupoRepository = grupoRepository;
        }

        // GET: Grupoes
        public IActionResult Index()
        {
            return View(this.grupoRepository.GetAll());
        }

        // GET: Grupoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await this.grupoRepository.GetByIdAsync(id.Value);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // GET: Grupoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Grupoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                await this.grupoRepository.CreateAsync(grupo);
                return RedirectToAction(nameof(Index));
            }
            return View(grupo);
        }

        // GET: Grupoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await this.grupoRepository.GetByIdAsync(id.Value);
            if (grupo == null)
            {
                return NotFound();
            }
            return View(grupo);
        }

        // POST: Grupoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.grupoRepository.UpdateAsync(grupo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.grupoRepository.ExistAsync(grupo.Id))
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
            return View(grupo);
        }

        // GET: Grupoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupo = await this.grupoRepository.GetByIdAsync(id.Value);
            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        // POST: Grupoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grupo = await this.grupoRepository.GetByIdAsync(id);
            await this.grupoRepository.DeleteAsync(grupo);
            return RedirectToAction(nameof(Index));
        }

        //private bool GrupoExists(int id)
        //{
        //    return _context.Grupos.Any(e => e.Id == id);
        //}
    }
}
