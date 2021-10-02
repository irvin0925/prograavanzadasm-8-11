using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VeterinariaSJ.Data;
using VeterinariaSJ.Models;

namespace VeterinariaSJ
{
    public class VeterinariaController : Controller
    {
        private readonly VeterinariaSJContext _context;

        public VeterinariaController(VeterinariaSJContext context)
        {
            _context = context;
        }

        // GET: Veterinaria
        public async Task<IActionResult> Index()
        {
            return View(await _context.Veterinaria.ToListAsync());
        }

        // GET: Veterinaria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaria = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veterinaria == null)
            {
                return NotFound();
            }

            return View(veterinaria);
        }

        // GET: Veterinaria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veterinaria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Raza,Edad,Motivo,Peso")] Veterinaria veterinaria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(veterinaria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veterinaria);
        }

        // GET: Veterinaria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaria = await _context.Veterinaria.FindAsync(id);
            if (veterinaria == null)
            {
                return NotFound();
            }
            return View(veterinaria);
        }

        // POST: Veterinaria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Raza,Edad,Motivo,Peso")] Veterinaria veterinaria)
        {
            if (id != veterinaria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veterinaria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeterinariaExists(veterinaria.Id))
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
            return View(veterinaria);
        }

        // GET: Veterinaria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veterinaria = await _context.Veterinaria
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veterinaria == null)
            {
                return NotFound();
            }

            return View(veterinaria);
        }

        // POST: Veterinaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veterinaria = await _context.Veterinaria.FindAsync(id);
            _context.Veterinaria.Remove(veterinaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeterinariaExists(int id)
        {
            return _context.Veterinaria.Any(e => e.Id == id);
        }
    }
}
