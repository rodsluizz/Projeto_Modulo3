#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proj_Modulo3.Models;

namespace Proj_Modulo3.Controllers
{
    public class promocoesController : Controller
    {
        private readonly contexto _context;

        public promocoesController(contexto context)
        {
            _context = context;
        }

        // GET: promocoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.promocoes.ToListAsync());
        }

        // GET: promocoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promocoes = await _context.promocoes
                .FirstOrDefaultAsync(m => m.id_promocoes == id);
            if (promocoes == null)
            {
                return NotFound();
            }

            return View(promocoes);
        }

        // GET: promocoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: promocoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_promocoes,local_viagem,estado,preco_antigo,preco_atual")] promocoes promocoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(promocoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promocoes);
        }

        // GET: promocoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promocoes = await _context.promocoes.FindAsync(id);
            if (promocoes == null)
            {
                return NotFound();
            }
            return View(promocoes);
        }

        // POST: promocoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_promocoes,local_viagem,estado,preco_antigo,preco_atual")] promocoes promocoes)
        {
            if (id != promocoes.id_promocoes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promocoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!promocoesExists(promocoes.id_promocoes))
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
            return View(promocoes);
        }

        // GET: promocoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promocoes = await _context.promocoes
                .FirstOrDefaultAsync(m => m.id_promocoes == id);
            if (promocoes == null)
            {
                return NotFound();
            }

            return View(promocoes);
        }

        // POST: promocoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var promocoes = await _context.promocoes.FindAsync(id);
            _context.promocoes.Remove(promocoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool promocoesExists(int id)
        {
            return _context.promocoes.Any(e => e.id_promocoes == id);
        }
    }
}
