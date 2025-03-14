using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrepareTest.Models;

namespace PrepareTest.Controllers
{
    public class ToanhasController : Controller
    {
        private readonly AppDbContext _context;

        public ToanhasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Toanhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Toanhas.ToListAsync());
        }

        // GET: Toanhas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toanha = await _context.Toanhas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (toanha == null)
            {
                return NotFound();
            }

            return View(toanha);
        }

        // GET: Toanhas/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Toanhas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Ten,DiaChi")] Toanha toanha)
        {
            
                _context.Add(toanha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            return View(toanha);
        }

        // GET: Toanhas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toanha = await _context.Toanhas.FindAsync(id);
            if (toanha == null)
            {
                return NotFound();
            }
            return View(toanha);
        }

        // POST: Toanhas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,Ten,DiaChi")] Toanha toanha)
        {
            if (id != toanha.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toanha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToanhaExists(toanha.ID))
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
            return View(toanha);
        }

        // GET: Toanhas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toanha = await _context.Toanhas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (toanha == null)
            {
                return NotFound();
            }

            return View(toanha);
        }

        // POST: Toanhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var toanha = await _context.Toanhas.FindAsync(id);
            if (toanha != null)
            {
                _context.Toanhas.Remove(toanha);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToanhaExists(string id)
        {
            return _context.Toanhas.Any(e => e.ID == id);
        }
    }
}
