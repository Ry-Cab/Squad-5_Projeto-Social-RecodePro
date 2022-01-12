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
    public class AfiliadaController : Controller
    {
        private readonly BDContext _context;

        public AfiliadaController(BDContext context)
        {
            _context = context;
        }

        // GET: Afiliada
        public async Task<IActionResult> Index()
        {
            return View(await _context.Afiliada.ToListAsync());
        }

        // GET: Afiliada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada
                .FirstOrDefaultAsync(m => m.id_afiliada == id);
            if (afiliada == null)
            {
                return NotFound();
            }

            return View(afiliada);
        }

        // GET: Afiliada/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

        // POST: Afiliada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_afiliada,nome_afiliada,sobrenome_afiliada,email_afiliada,senha_afiliada,telefone_afiliada")] Afiliada afiliada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afiliada);
                await _context.SaveChangesAsync();
                return RedirectToAction("Resumo");
            }
            return View(afiliada);
        }

        // GET: Afiliada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada.FindAsync(id);
            if (afiliada == null)
            {
                return NotFound();
            }
            return View(afiliada);
        }

        // POST: Afiliada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_afiliada,nome_afiliada,sobrenome_afiliada,email_afiliada,senha_afiliada,telefone_afiliada")] Afiliada afiliada)
        {
            if (id != afiliada.id_afiliada)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afiliada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfiliadaExists(afiliada.id_afiliada))
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
            return View(afiliada);
        }

        // GET: Afiliada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliada = await _context.Afiliada
                .FirstOrDefaultAsync(m => m.id_afiliada == id);
            if (afiliada == null)
            {
                return NotFound();
            }

            return View(afiliada);
        }

        // POST: Afiliada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var afiliada = await _context.Afiliada.FindAsync(id);
            _context.Afiliada.Remove(afiliada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfiliadaExists(int id)
        {
            return _context.Afiliada.Any(e => e.id_afiliada == id);
        }
    }
}
