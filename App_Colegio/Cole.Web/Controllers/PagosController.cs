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
    public class PagosController : Controller
    {
        private readonly IPagoRepository pagoRepository;

        public PagosController(IPagoRepository pagoRepository)
        {
            this.pagoRepository = pagoRepository;
        }

        // GET: Pagos
        public IActionResult Index()
        {
            return View(this.pagoRepository.GetAll());
        }

        // GET: Pagos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await this.pagoRepository.GetByIdAsync(id.Value);
            if (pago == null)
            {
                return NotFound();
            }

            return View(pago);
        }

        // GET: Pagos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pagos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pago pago)
        {
            if (ModelState.IsValid)
            {
                await this.pagoRepository.CreateAsync(pago);
                return RedirectToAction(nameof(Index));
            }
            return View(pago);
        }

        // GET: Pagos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await this.pagoRepository.GetByIdAsync(id.Value);
            if (pago == null)
            {
                return NotFound();
            }
            return View(pago);
        }

        // POST: Pagos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Pago pago)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.pagoRepository.UpdateAsync(pago);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.pagoRepository.ExistAsync(pago.Id))
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
            return View(pago);
        }

        // GET: Pagos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await this.pagoRepository.GetByIdAsync(id.Value);
            if (pago == null)
            {
                return NotFound();
            }

            return View(pago);
        }

        // POST: Pagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pago = await this.pagoRepository.GetByIdAsync(id);
            await this.pagoRepository.DeleteAsync(pago);
            return RedirectToAction(nameof(Index));
        }

        //private bool PagoExists(int id)
        //{
        //    return _context.Pagos.Any(e => e.Id == id);
        //}
    }
}
