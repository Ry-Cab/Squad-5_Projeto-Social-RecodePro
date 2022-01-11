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
    public class AfiliacaoController : Controller
    {
        private readonly BDContext _context;

        public AfiliacaoController(BDContext context)
        {
            _context = context;
        }

        // GET: Afiliacao
        public async Task<IActionResult> Index()
        {
            return View(await _context.Afiliacao.ToListAsync());
        }

        // GET: Afiliacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliacao = await _context.Afiliacao
                .FirstOrDefaultAsync(m => m.id_afiliacao == id);
            if (afiliacao == null)
            {
                return NotFound();
            }

            return View(afiliacao);
        }

        // GET: Afiliacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Afiliacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_afiliacao,codigo_produtoServico,FK_id_afiliada,FK_id_produtoServico")] Afiliacao afiliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afiliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(afiliacao);
        }

        // GET: Afiliacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliacao = await _context.Afiliacao.FindAsync(id);
            if (afiliacao == null)
            {
                return NotFound();
            }
            return View(afiliacao);
        }

        // POST: Afiliacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_afiliacao,codigo_produtoServico,FK_id_afiliada,FK_id_produtoServico")] Afiliacao afiliacao)
        {
            if (id != afiliacao.id_afiliacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afiliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AfiliacaoExists(afiliacao.id_afiliacao))
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
            return View(afiliacao);
        }

        // GET: Afiliacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var afiliacao = await _context.Afiliacao
                .FirstOrDefaultAsync(m => m.id_afiliacao == id);
            if (afiliacao == null)
            {
                return NotFound();
            }

            return View(afiliacao);
        }

        // POST: Afiliacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var afiliacao = await _context.Afiliacao.FindAsync(id);
            _context.Afiliacao.Remove(afiliacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AfiliacaoExists(int id)
        {
            return _context.Afiliacao.Any(e => e.id_afiliacao == id);
        }
    }
}
