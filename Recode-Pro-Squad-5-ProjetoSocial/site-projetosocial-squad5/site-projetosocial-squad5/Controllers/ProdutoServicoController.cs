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
    public class ProdutoServicoController : Controller
    {
        private readonly BDContext _context;

        public ProdutoServicoController(BDContext context)
        {
            _context = context;
        }

        // GET: ProdutoServico
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProdutoServico.ToListAsync());
        }

        // GET: ProdutoServico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico
                .FirstOrDefaultAsync(m => m.id_produtoServico == id);
            if (produtoServico == null)
            {
                return NotFound();
            }

            return View(produtoServico);
        }

        // GET: ProdutoServico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoServico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_produtoServico,codigo_produtoServico,tipo_produtoServico,nome_produtoServico,descricao_produtoServico,preco_produtoServico,nomeNegocio_autonoma,FK_id_autonoma")] ProdutoServico produtoServico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoServico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoServico);
        }

        // GET: ProdutoServico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico.FindAsync(id);
            if (produtoServico == null)
            {
                return NotFound();
            }
            return View(produtoServico);
        }

        // POST: ProdutoServico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_produtoServico,codigo_produtoServico,tipo_produtoServico,nome_produtoServico,descricao_produtoServico,preco_produtoServico,nomeNegocio_autonoma,FK_id_autonoma")] ProdutoServico produtoServico)
        {
            if (id != produtoServico.id_produtoServico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoServico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoServicoExists(produtoServico.id_produtoServico))
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
            return View(produtoServico);
        }

        // GET: ProdutoServico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoServico = await _context.ProdutoServico
                .FirstOrDefaultAsync(m => m.id_produtoServico == id);
            if (produtoServico == null)
            {
                return NotFound();
            }

            return View(produtoServico);
        }

        // POST: ProdutoServico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoServico = await _context.ProdutoServico.FindAsync(id);
            _context.ProdutoServico.Remove(produtoServico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoServicoExists(int id)
        {
            return _context.ProdutoServico.Any(e => e.id_produtoServico == id);
        }
    }
}
