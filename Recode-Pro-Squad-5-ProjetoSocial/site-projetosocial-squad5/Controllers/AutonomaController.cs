using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using site_projetosocial_squad5.Data;
using site_projetosocial_squad5.Models;

namespace site_projetosocial_squad5.Controllers
{
    public class AutonomaController : Controller
    {
        private readonly BDContext _context;

        public AutonomaController(BDContext context)
        {
            _context = context;
        }

        // GET: Autonoma
        public async Task<IActionResult> Index()
        {
            return View(await _context.Autonoma.ToListAsync());
        }

        // GET: Autonoma/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autonoma = await _context.Autonoma
                .FirstOrDefaultAsync(m => m.id_autonoma == id);
            if (autonoma == null)
            {
                return NotFound();
            }

            return View(autonoma);
        }

        // GET: Autonoma/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Autonoma/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_autonoma,nome_autonoma,sobrenome_autonoma,email_autonoma,senha_autonoma,telefone_autonoma,nomeNegocio_autonoma")] Autonoma autonoma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autonoma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autonoma);
        }

        // GET: Autonoma/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autonoma = await _context.Autonoma.FindAsync(id);
            if (autonoma == null)
            {
                return NotFound();
            }
            return View(autonoma);
        }

        // POST: Autonoma/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_autonoma,nome_autonoma,sobrenome_autonoma,email_autonoma,senha_autonoma,telefone_autonoma,nomeNegocio_autonoma")] Autonoma autonoma)
        {
            if (id != autonoma.id_autonoma)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autonoma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutonomaExists(autonoma.id_autonoma))
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
            return View(autonoma);
        }

        // GET: Autonoma/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autonoma = await _context.Autonoma
                .FirstOrDefaultAsync(m => m.id_autonoma == id);
            if (autonoma == null)
            {
                return NotFound();
            }

            return View(autonoma);
        }

        // POST: Autonoma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var autonoma = await _context.Autonoma.FindAsync(id);
            _context.Autonoma.Remove(autonoma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutonomaExists(int id)
        {
            return _context.Autonoma.Any(e => e.id_autonoma == id);
        }
    }
}
